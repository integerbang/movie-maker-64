namespace MovieMaker64.UserInterface
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.OkayButton = new System.Windows.Forms.Button();
            this.ProductInformationLabel = new System.Windows.Forms.Label();
            this.LogotypePictureBox = new System.Windows.Forms.PictureBox();
            this.AboutInformationLabel = new System.Windows.Forms.Label();
            this.LicenseLinkLabel = new System.Windows.Forms.LinkLabel();
            this.GitHubSeperatorLabel = new System.Windows.Forms.Label();
            this.GitHubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.LicenseSeperatorLabel = new System.Windows.Forms.Label();
            this.WebsiteLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.LogotypePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OkayButton
            // 
            resources.ApplyResources(this.OkayButton, "OkayButton");
            this.OkayButton.BackColor = System.Drawing.Color.Transparent;
            this.OkayButton.Name = "OkayButton";
            this.OkayButton.UseVisualStyleBackColor = false;
            this.OkayButton.Click += new System.EventHandler(this.OkayButtonClick);
            // 
            // ProductInformationLabel
            // 
            this.ProductInformationLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ProductInformationLabel, "ProductInformationLabel");
            this.ProductInformationLabel.ForeColor = System.Drawing.Color.Black;
            this.ProductInformationLabel.Name = "ProductInformationLabel";
            // 
            // LogotypePictureBox
            // 
            this.LogotypePictureBox.BackgroundImage = global::MovieMaker64.UserInterface.Properties.Resources.AboutBoxImage;
            resources.ApplyResources(this.LogotypePictureBox, "LogotypePictureBox");
            this.LogotypePictureBox.Name = "LogotypePictureBox";
            this.LogotypePictureBox.TabStop = false;
            // 
            // AboutInformationLabel
            // 
            resources.ApplyResources(this.AboutInformationLabel, "AboutInformationLabel");
            this.AboutInformationLabel.ForeColor = System.Drawing.Color.DimGray;
            this.AboutInformationLabel.Name = "AboutInformationLabel";
            // 
            // LicenseLinkLabel
            // 
            resources.ApplyResources(this.LicenseLinkLabel, "LicenseLinkLabel");
            this.LicenseLinkLabel.Name = "LicenseLinkLabel";
            this.LicenseLinkLabel.TabStop = true;
            // 
            // GitHubSeperatorLabel
            // 
            resources.ApplyResources(this.GitHubSeperatorLabel, "GitHubSeperatorLabel");
            this.GitHubSeperatorLabel.Name = "GitHubSeperatorLabel";
            // 
            // GitHubLinkLabel
            // 
            resources.ApplyResources(this.GitHubLinkLabel, "GitHubLinkLabel");
            this.GitHubLinkLabel.Name = "GitHubLinkLabel";
            this.GitHubLinkLabel.TabStop = true;
            // 
            // LicenseSeperatorLabel
            // 
            resources.ApplyResources(this.LicenseSeperatorLabel, "LicenseSeperatorLabel");
            this.LicenseSeperatorLabel.Name = "LicenseSeperatorLabel";
            // 
            // WebsiteLinkLabel
            // 
            resources.ApplyResources(this.WebsiteLinkLabel, "WebsiteLinkLabel");
            this.WebsiteLinkLabel.Name = "WebsiteLinkLabel";
            this.WebsiteLinkLabel.TabStop = true;
            // 
            // AboutForm
            // 
            this.AcceptButton = this.OkayButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ControlBox = false;
            this.Controls.Add(this.WebsiteLinkLabel);
            this.Controls.Add(this.LicenseSeperatorLabel);
            this.Controls.Add(this.GitHubLinkLabel);
            this.Controls.Add(this.GitHubSeperatorLabel);
            this.Controls.Add(this.LicenseLinkLabel);
            this.Controls.Add(this.AboutInformationLabel);
            this.Controls.Add(this.LogotypePictureBox);
            this.Controls.Add(this.ProductInformationLabel);
            this.Controls.Add(this.OkayButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.AboutFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.LogotypePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkayButton;
        private System.Windows.Forms.Label ProductInformationLabel;
        private System.Windows.Forms.PictureBox LogotypePictureBox;
        private System.Windows.Forms.Label AboutInformationLabel;
        private System.Windows.Forms.LinkLabel LicenseLinkLabel;
        private System.Windows.Forms.Label GitHubSeperatorLabel;
        private System.Windows.Forms.LinkLabel GitHubLinkLabel;
        private System.Windows.Forms.Label LicenseSeperatorLabel;
        private System.Windows.Forms.LinkLabel WebsiteLinkLabel;
    }
}