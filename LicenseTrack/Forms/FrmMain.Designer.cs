namespace LicenseTrack
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlDynamic = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnDrivers = new System.Windows.Forms.Button();
            this.btnPeople = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnApplications = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lnkLblEngenMe = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnHide = new System.Windows.Forms.Button();
            this.lblCurrentWindowName = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDateAndTime = new System.Windows.Forms.Label();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.btnShutDown = new System.Windows.Forms.Button();
            this.tMain = new System.Windows.Forms.Timer(this.components);
            this.ttMain = new System.Windows.Forms.ToolTip(this.components);
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(330, 143);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1067, 635);
            this.pnlMain.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel3.Controls.Add(this.pnlDynamic);
            this.panel3.Controls.Add(this.btnSettings);
            this.panel3.Controls.Add(this.btnUsers);
            this.panel3.Controls.Add(this.btnDrivers);
            this.panel3.Controls.Add(this.btnPeople);
            this.panel3.Controls.Add(this.btnInfo);
            this.panel3.Controls.Add(this.btnApplications);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 778);
            this.panel3.TabIndex = 0;
            // 
            // pnlDynamic
            // 
            this.pnlDynamic.BackColor = System.Drawing.Color.LightCoral;
            this.pnlDynamic.Location = new System.Drawing.Point(3, 152);
            this.pnlDynamic.Name = "pnlDynamic";
            this.pnlDynamic.Size = new System.Drawing.Size(42, 104);
            this.pnlDynamic.TabIndex = 0;
            this.pnlDynamic.Tag = "0";
            this.pnlDynamic.Visible = false;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.Location = new System.Drawing.Point(51, 592);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(257, 104);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Tag = "4";
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsers.Location = new System.Drawing.Point(51, 482);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(257, 104);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Tag = "3";
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            // 
            // btnDrivers
            // 
            this.btnDrivers.FlatAppearance.BorderSize = 0;
            this.btnDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrivers.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrivers.Image = ((System.Drawing.Image)(resources.GetObject("btnDrivers.Image")));
            this.btnDrivers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDrivers.Location = new System.Drawing.Point(51, 372);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Size = new System.Drawing.Size(257, 104);
            this.btnDrivers.TabIndex = 1;
            this.btnDrivers.Tag = "2";
            this.btnDrivers.Text = "Drivers";
            this.btnDrivers.UseVisualStyleBackColor = true;
            // 
            // btnPeople
            // 
            this.btnPeople.FlatAppearance.BorderSize = 0;
            this.btnPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeople.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeople.Image = ((System.Drawing.Image)(resources.GetObject("btnPeople.Image")));
            this.btnPeople.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPeople.Location = new System.Drawing.Point(51, 262);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(257, 104);
            this.btnPeople.TabIndex = 1;
            this.btnPeople.Tag = "1";
            this.btnPeople.Text = "People";
            this.btnPeople.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            this.btnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.Location = new System.Drawing.Point(3, 730);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(45, 45);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // btnApplications
            // 
            this.btnApplications.FlatAppearance.BorderSize = 0;
            this.btnApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplications.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplications.Image = ((System.Drawing.Image)(resources.GetObject("btnApplications.Image")));
            this.btnApplications.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApplications.Location = new System.Drawing.Point(51, 152);
            this.btnApplications.Name = "btnApplications";
            this.btnApplications.Size = new System.Drawing.Size(257, 104);
            this.btnApplications.TabIndex = 1;
            this.btnApplications.Tag = "0";
            this.btnApplications.Text = "Applications";
            this.btnApplications.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.panel5.Controls.Add(this.lnkLblEngenMe);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(330, 146);
            this.panel5.TabIndex = 0;
            // 
            // lnkLblEngenMe
            // 
            this.lnkLblEngenMe.AutoSize = true;
            this.lnkLblEngenMe.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLblEngenMe.Location = new System.Drawing.Point(166, 91);
            this.lnkLblEngenMe.Name = "lnkLblEngenMe";
            this.lnkLblEngenMe.Size = new System.Drawing.Size(143, 37);
            this.lnkLblEngenMe.TabIndex = 0;
            this.lnkLblEngenMe.TabStop = true;
            this.lnkLblEngenMe.Text = "EngenMe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 74);
            this.label1.TabIndex = 1;
            this.label1.Text = "License\r\n        Track";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel4.Controls.Add(this.btnHide);
            this.panel4.Controls.Add(this.lblCurrentWindowName);
            this.panel4.Controls.Add(this.lblUser);
            this.panel4.Controls.Add(this.lblDateAndTime);
            this.panel4.Controls.Add(this.btnFullScreen);
            this.panel4.Controls.Add(this.btnShutDown);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(330, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1067, 143);
            this.panel4.TabIndex = 0;
            // 
            // btnHide
            // 
            this.btnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Image = ((System.Drawing.Image)(resources.GetObject("btnHide.Image")));
            this.btnHide.Location = new System.Drawing.Point(917, 3);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(45, 45);
            this.btnHide.TabIndex = 0;
            this.btnHide.UseVisualStyleBackColor = true;
            // 
            // lblCurrentWindowName
            // 
            this.lblCurrentWindowName.AutoSize = true;
            this.lblCurrentWindowName.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentWindowName.Location = new System.Drawing.Point(117, 47);
            this.lblCurrentWindowName.Name = "lblCurrentWindowName";
            this.lblCurrentWindowName.Size = new System.Drawing.Size(199, 48);
            this.lblCurrentWindowName.TabIndex = 1;
            this.lblCurrentWindowName.Text = "Welcome!";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(15, 10);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(51, 24);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "User";
            // 
            // lblDateAndTime
            // 
            this.lblDateAndTime.AutoSize = true;
            this.lblDateAndTime.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAndTime.Location = new System.Drawing.Point(551, 10);
            this.lblDateAndTime.Name = "lblDateAndTime";
            this.lblDateAndTime.Size = new System.Drawing.Size(141, 24);
            this.lblDateAndTime.TabIndex = 1;
            this.lblDateAndTime.Text = "Date and Time";
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullScreen.FlatAppearance.BorderSize = 0;
            this.btnFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullScreen.Image = ((System.Drawing.Image)(resources.GetObject("btnFullScreen.Image")));
            this.btnFullScreen.Location = new System.Drawing.Point(968, 3);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(45, 45);
            this.btnFullScreen.TabIndex = 0;
            this.btnFullScreen.UseVisualStyleBackColor = true;
            // 
            // btnShutDown
            // 
            this.btnShutDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShutDown.FlatAppearance.BorderSize = 0;
            this.btnShutDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutDown.Image = ((System.Drawing.Image)(resources.GetObject("btnShutDown.Image")));
            this.btnShutDown.Location = new System.Drawing.Point(1019, 3);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(45, 45);
            this.btnShutDown.TabIndex = 0;
            this.btnShutDown.UseVisualStyleBackColor = true;
            // 
            // tMain
            // 
            this.tMain.Enabled = true;
            // 
            // ttMain
            // 
            this.ttMain.AutoPopDelay = 5000;
            this.ttMain.InitialDelay = 1000;
            this.ttMain.ReshowDelay = 500;
            this.ttMain.ShowAlways = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1397, 778);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnShutDown;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnFullScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnApplications;
        private System.Windows.Forms.Panel pnlDynamic;
        private System.Windows.Forms.Label lblDateAndTime;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblCurrentWindowName;
        private System.Windows.Forms.Button btnPeople;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnDrivers;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Timer tMain;
        private System.Windows.Forms.LinkLabel lnkLblEngenMe;
        private System.Windows.Forms.ToolTip ttMain;
    }
}

