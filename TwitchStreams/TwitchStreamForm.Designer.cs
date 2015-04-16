namespace TwitchStreams
{
    partial class TwitchStreamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TwitchStreamForm));
            this.btnLaunch = new System.Windows.Forms.Button();
            this.lstStreams = new System.Windows.Forms.ListBox();
            this.btnSetUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstQuality = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGame = new System.Windows.Forms.Label();
            this.lblViewers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLaunch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLaunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnLaunch.Location = new System.Drawing.Point(0, 488);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(639, 36);
            this.btnLaunch.TabIndex = 0;
            this.btnLaunch.Text = "Launch Stream";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // lstStreams
            // 
            this.lstStreams.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstStreams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstStreams.FormattingEnabled = true;
            this.lstStreams.ItemHeight = 20;
            this.lstStreams.Location = new System.Drawing.Point(0, 26);
            this.lstStreams.Name = "lstStreams";
            this.lstStreams.Size = new System.Drawing.Size(171, 524);
            this.lstStreams.TabIndex = 1;
            this.lstStreams.SelectedIndexChanged += new System.EventHandler(this.lstStreams_SelectedIndexChanged);
            // 
            // btnSetUser
            // 
            this.btnSetUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSetUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSetUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSetUser.Location = new System.Drawing.Point(639, 0);
            this.btnSetUser.Name = "btnSetUser";
            this.btnSetUser.Size = new System.Drawing.Size(171, 26);
            this.btnSetUser.TabIndex = 3;
            this.btnSetUser.Text = "Set Default Username";
            this.btnSetUser.UseVisualStyleBackColor = false;
            this.btnSetUser.Click += new System.EventHandler(this.btnSetUser_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnSetUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 26);
            this.panel1.TabIndex = 4;
            // 
            // txtUser
            // 
            this.txtUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUser.Location = new System.Drawing.Point(171, 0);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(468, 26);
            this.txtUser.TabIndex = 6;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRefresh.Location = new System.Drawing.Point(0, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(171, 26);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh Streams";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLaunch);
            this.panel2.Controls.Add(this.lstQuality);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.lblGame);
            this.panel2.Controls.Add(this.lblViewers);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.picPreview);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(171, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 524);
            this.panel2.TabIndex = 5;
            // 
            // lstQuality
            // 
            this.lstQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lstQuality.FormattingEnabled = true;
            this.lstQuality.ItemHeight = 18;
            this.lstQuality.Items.AddRange(new object[] {
            "Best",
            "Source",
            "High",
            "Medium",
            "Low",
            "Mobile",
            "Audio"});
            this.lstQuality.Location = new System.Drawing.Point(0, 359);
            this.lstQuality.Name = "lstQuality";
            this.lstQuality.Size = new System.Drawing.Size(64, 130);
            this.lstQuality.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTitle.Location = new System.Drawing.Point(73, 373);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(554, 41);
            this.lblTitle.TabIndex = 6;
            // 
            // lblGame
            // 
            this.lblGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblGame.Location = new System.Drawing.Point(140, 424);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(487, 18);
            this.lblGame.TabIndex = 5;
            // 
            // lblViewers
            // 
            this.lblViewers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblViewers.Location = new System.Drawing.Point(140, 455);
            this.lblViewers.Name = "lblViewers";
            this.lblViewers.Size = new System.Drawing.Size(487, 18);
            this.lblViewers.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(70, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Viewers:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(70, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Playing:";
            // 
            // picPreview
            // 
            this.picPreview.Location = new System.Drawing.Point(0, 0);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(640, 360);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 0;
            this.picPreview.TabStop = false;
            // 
            // TwitchStreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(810, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lstStreams);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TwitchStreamForm";
            this.Text = "Twitch Stream Utility";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.ListBox lstStreams;
        private System.Windows.Forms.Button btnSetUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.Label lblViewers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstQuality;
    }
}

