namespace MovieMaker64.UserInterface
{
    partial class ChangeCameraStyleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeCameraStyleForm));
            this.CancelOperationButton = new System.Windows.Forms.Button();
            this.OkayButton = new System.Windows.Forms.Button();
            this.CameraStyleListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CancelOperationButton
            // 
            resources.ApplyResources(this.CancelOperationButton, "CancelOperationButton");
            this.CancelOperationButton.Name = "CancelOperationButton";
            this.CancelOperationButton.UseVisualStyleBackColor = true;
            this.CancelOperationButton.Click += new System.EventHandler(this.CancelOperation);
            // 
            // OkayButton
            // 
            resources.ApplyResources(this.OkayButton, "OkayButton");
            this.OkayButton.Name = "OkayButton";
            this.OkayButton.UseVisualStyleBackColor = true;
            // 
            // CameraStyleListBox
            // 
            this.CameraStyleListBox.FormattingEnabled = true;
            resources.ApplyResources(this.CameraStyleListBox, "CameraStyleListBox");
            this.CameraStyleListBox.Name = "CameraStyleListBox";
            // 
            // ChangeCameraStyleForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.CameraStyleListBox);
            this.Controls.Add(this.OkayButton);
            this.Controls.Add(this.CancelOperationButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeCameraStyleForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelOperationButton;
        private System.Windows.Forms.Button OkayButton;
        private System.Windows.Forms.ListBox CameraStyleListBox;
    }
}