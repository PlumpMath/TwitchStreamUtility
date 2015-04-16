using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TwitchStreams
{
    public partial class TwitchStreamForm : Form
    {
        private WebClient wc;
        private bool refreshing = true;

        public TwitchStreamForm()
        {
            InitializeComponent();

            initializeBatch();

            wc = new WebClient();

            getUser();

            setListboxContents();
            lstQuality.SelectedIndex = 0;
        }

        private void initializeBatch()
        {
            try
            {
                string path = Application.StartupPath + "/twitch.bat";

                if (!File.Exists(path))
                {
                    StreamWriter writer = new StreamWriter(path, false, Encoding.ASCII);
                    writer.WriteLine("livestreamer twitch.tv/%1 %2");
                    writer.Close();
                }
            }
            catch
            {
                //
            }
        }

        private async void setListboxContents()
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "day9tv";
            }
            Task<string> followJsonTask = wc.DownloadStringTaskAsync("https://api.twitch.tv/kraken/users/" + txtUser.Text + "/follows/channels");
            string followJson = await followJsonTask;
            JObject follows = JObject.Parse(followJson);
            string[] followedStreams = getFollowedStreams(follows);

            lstStreams.Items.Clear();
            
            foreach (string streamName in followedStreams)
            {
                Task<string> streamJsonTask = wc.DownloadStringTaskAsync("https://api.twitch.tv/kraken/streams/" + streamName);
                string streamJson = await streamJsonTask;
                JObject stream = JObject.Parse(streamJson);

                if (checkStream(stream))
                {
                    lstStreams.Items.Add(streamName);
                }
            }

            if (lstStreams.Items.Count < 1)
            {
                lstStreams.Items.Add("No available streams.");
            }

            refreshing = false;
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            if (lstStreams.SelectedIndex > -1)
            {
                string streamJson = wc.DownloadString("https://api.twitch.tv/kraken/streams/" + lstStreams.SelectedItem.ToString());
                JObject stream = JObject.Parse(streamJson);

                if (checkStream(stream))
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();

                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.WorkingDirectory = Application.StartupPath;
                    startInfo.FileName = "twitch.bat";
                    startInfo.Arguments = lstStreams.SelectedItem.ToString() + " " + lstQuality.SelectedItem.ToString();

                    process.StartInfo = startInfo;
                    process.Start();
                }
                else
                {
                    btnRefresh_Click(sender, e);
                    MessageBox.Show("This stream is no longer live.");
                }
            }
        }

        private string[] getFollowedStreams(JObject follows)
        {
            JArray followedChannels = (JArray)follows["follows"];

            List<string> channelNames = new List<string>();

            foreach (JObject item in followedChannels.Children())
            {
                channelNames.Add(item["channel"]["name"].ToString());
            }

            return channelNames.ToArray();
        }

        private bool checkStream(JObject stream)
        {
            if (stream["stream"].HasValues)
            {
                return true;
            }

            return false;
        }

        private async void lstStreams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStreams.SelectedIndex > -1)
            {
                try
                {
                    Task<string> jsonTask = wc.DownloadStringTaskAsync("https://api.twitch.tv/kraken/streams/" + lstStreams.SelectedItem);
                    string streamJson = await jsonTask;
                    JObject stream = JObject.Parse(streamJson);

                    setDetails(stream);
                }
                catch
                {
                    //
                }
            }
        }

        private void setDetails(JObject stream)
        {
            picPreview.Load(stream["stream"]["preview"]["medium"].ToString());
            try
            {
                lblTitle.Text = stream["stream"]["channel"]["status"].ToString();
            }
            catch
            {
                lblTitle.Text = "Could not retrieve title.";
            }
            lblGame.Text = stream["stream"]["game"].ToString();
            lblViewers.Text = stream["stream"]["viewers"].ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (!refreshing)
            {
                refreshing = true;

                object currentItem = lstStreams.SelectedItem;

                lstStreams.Items.Clear();
                lstStreams.Items.Add("Refreshing...");
                setListboxContents();

                if (currentItem != null &&
                    lstStreams.Items.Contains(currentItem))
                {
                    lstStreams.SelectedItem = currentItem;
                }
            }
        }

        private void btnSetUser_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter writer = new StreamWriter(Application.StartupPath + "/user.txt", false);
                writer.Write(txtUser.Text);
                writer.Close();
                btnRefresh_Click(sender, e);
            }
            catch
            {
                MessageBox.Show("Error when saving default user.");
            }
        }

        private void getUser()
        {
            try
            {
                StreamReader reader = new StreamReader(Application.StartupPath + "/user.txt");
                txtUser.Text = reader.ReadLine();
            }
            catch
            {
                //
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
