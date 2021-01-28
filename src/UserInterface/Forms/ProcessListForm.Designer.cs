namespace MovieMaker64.UserInterface
{
    partial class ProcessListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessListForm));
            this.ProcessesListBox = new System.Windows.Forms.ListBox();
            this.AttachButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ContextLabel = new System.Windows.Forms.Label();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProcessesListBox
            // 
            this.ProcessesListBox.FormattingEnabled = true;
            resources.ApplyResources(this.ProcessesListBox, "ProcessesListBox");
            this.ProcessesListBox.Name = "ProcessesListBox";
            // 
            // AttachButton
            // 
            resources.ApplyResources(this.AttachButton, "AttachButton");
            this.AttachButton.Name = "AttachButton";
            this.AttachButton.UseVisualStyleBackColor = true;
            this.AttachButton.Click += new System.EventHandler(this.AttachProcess);
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.ExitButton, "ExitButton");
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.CancelOperation);
            // 
            // ContextLabel
            // 
            resources.ApplyResources(this.ContextLabel, "ContextLabel");
            this.ContextLabel.Name = "ContextLabel";
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Enabled = true;
            this.RefreshTimer.Interval = 1000;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTick);
            // 
            // RefreshButton
            // 
            resources.ApplyResources(this.RefreshButton, "RefreshButton");
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshList);
            // 
            // ProcessListForm
            // 
            this.AcceptButton = this.AttachButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ControlBox = false;
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.ContextLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AttachButton);
            this.Controls.Add(this.ProcessesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProcessListForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox ProcessesListBox;
        private System.Windows.Forms.Button AttachButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label ContextLabel;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.Button RefreshButton;
    }
}