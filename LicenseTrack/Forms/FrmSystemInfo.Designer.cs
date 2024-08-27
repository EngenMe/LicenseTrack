namespace LicenseTrack.Forms
{
    partial class FrmSystemInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSystemInfo));
            this.ctrlSystemInfoCard = new LicenseTrack.Controls.CtrlSystemInfoCard();
            this.SuspendLayout();
            // 
            // ctrlSystemInfoCard
            // 
            this.ctrlSystemInfoCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ctrlSystemInfoCard.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlSystemInfoCard.Location = new System.Drawing.Point(12, 13);
            this.ctrlSystemInfoCard.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlSystemInfoCard.Name = "ctrlSystemInfoCard";
            this.ctrlSystemInfoCard.Size = new System.Drawing.Size(710, 291);
            this.ctrlSystemInfoCard.TabIndex = 0;
            // 
            // FrmSystemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(735, 319);
            this.Controls.Add(this.ctrlSystemInfoCard);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSystemInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Info";
            this.ResumeLayout(false);

        }

        #endregion

        internal Controls.CtrlSystemInfoCard ctrlSystemInfoCard;
    }
}