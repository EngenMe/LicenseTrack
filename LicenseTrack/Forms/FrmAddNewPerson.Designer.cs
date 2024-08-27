namespace LicenseTrack.Forms
{
    partial class FrmAddNewPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddNewPerson));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ctrlInputPersonInfo = new LicenseTrack.Controls.ctrlInputPersonInfo();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(269, 31);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(321, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add New Person";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnAddNewPerson.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewPerson.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewPerson.Image")));
            this.btnAddNewPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewPerson.Location = new System.Drawing.Point(737, 772);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(110, 41);
            this.btnAddNewPerson.TabIndex = 17;
            this.btnAddNewPerson.Text = "Save";
            this.btnAddNewPerson.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewPerson.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.button1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(621, 772);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 41);
            this.button1.TabIndex = 16;
            this.button1.Text = "Close";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ctrlInputPersonInfo
            // 
            this.ctrlInputPersonInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ctrlInputPersonInfo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlInputPersonInfo.Location = new System.Drawing.Point(12, 130);
            this.ctrlInputPersonInfo.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlInputPersonInfo.Name = "ctrlInputPersonInfo";
            this.ctrlInputPersonInfo.Size = new System.Drawing.Size(835, 619);
            this.ctrlInputPersonInfo.TabIndex = 1;
            // 
            // FrmAddNewPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(860, 844);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddNewPerson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlInputPersonInfo);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAddNewPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Person";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        internal Controls.ctrlInputPersonInfo ctrlInputPersonInfo;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.Button button1;
    }
}