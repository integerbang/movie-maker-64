namespace MovieMaker64.UserInterface
{
    partial class PrimaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimaryForm));
            this.PrimaryMenuStrip = new System.Windows.Forms.MenuStrip();
            this.TrainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CameraToggleButton = new System.Windows.Forms.Button();
            this.CameraControlsGroupBox = new System.Windows.Forms.GroupBox();
            this.SoftCameraToggleButton = new System.Windows.Forms.Button();
            this.ChangeCameraTypeButton = new System.Windows.Forms.Button();
            this.AnimationControlsGroupBox = new System.Windows.Forms.GroupBox();
            this.ReplaceWithLabel = new System.Windows.Forms.Label();
            this.SelectAnimationLabel = new System.Windows.Forms.Label();
            this.ReplaceWithComboBox = new System.Windows.Forms.ComboBox();
            this.SelectAnimationComboBox = new System.Windows.Forms.ComboBox();
            this.ResetAllButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ReplaceButton = new System.Windows.Forms.Button();
            this.PrimaryStatusStrip = new System.Windows.Forms.StatusStrip();
            this.BaseAddressToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CourseToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.ControlTimer = new System.Windows.Forms.Timer(this.components);
            this.PrimaryMenuStrip.SuspendLayout();
            this.CameraControlsGroupBox.SuspendLayout();
            this.AnimationControlsGroupBox.SuspendLayout();
            this.PrimaryStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrimaryMenuStrip
            // 
            this.PrimaryMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrainerToolStripMenuItem,
            this.HelpToolStripMenuItem});
            resources.ApplyResources(this.PrimaryMenuStrip, "PrimaryMenuStrip");
            this.PrimaryMenuStrip.Name = "PrimaryMenuStrip";
            this.PrimaryMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // TrainerToolStripMenuItem
            // 
            this.TrainerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshToolStripMenuItem,
            this.ToolStripSeparator1,
            this.ExitToolStripMenuItem});
            this.TrainerToolStripMenuItem.Name = "TrainerToolStripMenuItem";
            resources.ApplyResources(this.TrainerToolStripMenuItem, "TrainerToolStripMenuItem");
            // 
            // RefreshToolStripMenuItem
            // 
            this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
            resources.ApplyResources(this.RefreshToolStripMenuItem, "RefreshToolStripMenuItem");
            this.RefreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshBaseAddress);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            resources.ApplyResources(this.ToolStripSeparator1, "ToolStripSeparator1");
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            resources.ApplyResources(this.ExitToolStripMenuItem, "ExitToolStripMenuItem");
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            resources.ApplyResources(this.HelpToolStripMenuItem, "HelpToolStripMenuItem");
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            resources.ApplyResources(this.AboutToolStripMenuItem, "AboutToolStripMenuItem");
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
            // 
            // CameraToggleButton
            // 
            resources.ApplyResources(this.CameraToggleButton, "CameraToggleButton");
            this.CameraToggleButton.Name = "CameraToggleButton";
            this.CameraToggleButton.UseVisualStyleBackColor = true;
            this.CameraToggleButton.Click += new System.EventHandler(this.CameraToggleButtonClick);
            // 
            // CameraControlsGroupBox
            // 
            resources.ApplyResources(this.CameraControlsGroupBox, "CameraControlsGroupBox");
            this.CameraControlsGroupBox.Controls.Add(this.SoftCameraToggleButton);
            this.CameraControlsGroupBox.Controls.Add(this.ChangeCameraTypeButton);
            this.CameraControlsGroupBox.Controls.Add(this.CameraToggleButton);
            this.CameraControlsGroupBox.Name = "CameraControlsGroupBox";
            this.CameraControlsGroupBox.TabStop = false;
            // 
            // SoftCameraToggleButton
            // 
            resources.ApplyResources(this.SoftCameraToggleButton, "SoftCameraToggleButton");
            this.SoftCameraToggleButton.Name = "SoftCameraToggleButton";
            this.SoftCameraToggleButton.UseVisualStyleBackColor = true;
            this.SoftCameraToggleButton.Click += new System.EventHandler(this.SoftCameraToggleButtonClick);
            // 
            // ChangeCameraTypeButton
            // 
            resources.ApplyResources(this.ChangeCameraTypeButton, "ChangeCameraTypeButton");
            this.ChangeCameraTypeButton.Name = "ChangeCameraTypeButton";
            this.ChangeCameraTypeButton.UseVisualStyleBackColor = true;
            this.ChangeCameraTypeButton.Click += new System.EventHandler(this.ChangeCameraTypeClick);
            // 
            // AnimationControlsGroupBox
            // 
            resources.ApplyResources(this.AnimationControlsGroupBox, "AnimationControlsGroupBox");
            this.AnimationControlsGroupBox.Controls.Add(this.ReplaceWithLabel);
            this.AnimationControlsGroupBox.Controls.Add(this.SelectAnimationLabel);
            this.AnimationControlsGroupBox.Controls.Add(this.ReplaceWithComboBox);
            this.AnimationControlsGroupBox.Controls.Add(this.SelectAnimationComboBox);
            this.AnimationControlsGroupBox.Controls.Add(this.ResetAllButton);
            this.AnimationControlsGroupBox.Controls.Add(this.ResetButton);
            this.AnimationControlsGroupBox.Controls.Add(this.ReplaceButton);
            this.AnimationControlsGroupBox.Name = "AnimationControlsGroupBox";
            this.AnimationControlsGroupBox.TabStop = false;
            // 
            // ReplaceWithLabel
            // 
            this.ReplaceWithLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ReplaceWithLabel, "ReplaceWithLabel");
            this.ReplaceWithLabel.Name = "ReplaceWithLabel";
            // 
            // SelectAnimationLabel
            // 
            this.SelectAnimationLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.SelectAnimationLabel, "SelectAnimationLabel");
            this.SelectAnimationLabel.Name = "SelectAnimationLabel";
            // 
            // ReplaceWithComboBox
            // 
            resources.ApplyResources(this.ReplaceWithComboBox, "ReplaceWithComboBox");
            this.ReplaceWithComboBox.FormattingEnabled = true;
            this.ReplaceWithComboBox.Name = "ReplaceWithComboBox";
            // 
            // SelectAnimationComboBox
            // 
            resources.ApplyResources(this.SelectAnimationComboBox, "SelectAnimationComboBox");
            this.SelectAnimationComboBox.FormattingEnabled = true;
            this.SelectAnimationComboBox.Name = "SelectAnimationComboBox";
            // 
            // ResetAllButton
            // 
            resources.ApplyResources(this.ResetAllButton, "ResetAllButton");
            this.ResetAllButton.Name = "ResetAllButton";
            this.ResetAllButton.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            resources.ApplyResources(this.ResetButton, "ResetButton");
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // ReplaceButton
            // 
            resources.ApplyResources(this.ReplaceButton, "ReplaceButton");
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.UseVisualStyleBackColor = true;
            // 
            // PrimaryStatusStrip
            // 
            this.PrimaryStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BaseAddressToolStripStatusLabel,
            this.CourseToolStripStatusLabel});
            resources.ApplyResources(this.PrimaryStatusStrip, "PrimaryStatusStrip");
            this.PrimaryStatusStrip.Name = "PrimaryStatusStrip";
            this.PrimaryStatusStrip.SizingGrip = false;
            // 
            // BaseAddressToolStripStatusLabel
            // 
            this.BaseAddressToolStripStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.BaseAddressToolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.BaseAddressToolStripStatusLabel.Name = "BaseAddressToolStripStatusLabel";
            resources.ApplyResources(this.BaseAddressToolStripStatusLabel, "BaseAddressToolStripStatusLabel");
            // 
            // CourseToolStripStatusLabel
            // 
            this.CourseToolStripStatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CourseToolStripStatusLabel.Name = "CourseToolStripStatusLabel";
            resources.ApplyResources(this.CourseToolStripStatusLabel, "CourseToolStripStatusLabel");
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Interval = 1000;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTick);
            // 
            // ControlTimer
            // 
            this.ControlTimer.Enabled = true;
            this.ControlTimer.Tick += new System.EventHandler(this.ControlTick);
            // 
            // PrimaryForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PrimaryStatusStrip);
            this.Controls.Add(this.AnimationControlsGroupBox);
            this.Controls.Add(this.CameraControlsGroupBox);
            this.Controls.Add(this.PrimaryMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.PrimaryMenuStrip;
            this.MaximizeBox = false;
            this.Name = "PrimaryForm";
            this.Load += new System.EventHandler(this.FormLoad);
            this.PrimaryMenuStrip.ResumeLayout(false);
            this.PrimaryMenuStrip.PerformLayout();
            this.CameraControlsGroupBox.ResumeLayout(false);
            this.AnimationControlsGroupBox.ResumeLayout(false);
            this.PrimaryStatusStrip.ResumeLayout(false);
            this.PrimaryStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip PrimaryMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TrainerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.Button CameraToggleButton;
        private System.Windows.Forms.GroupBox CameraControlsGroupBox;
        private System.Windows.Forms.Button SoftCameraToggleButton;
        private System.Windows.Forms.GroupBox AnimationControlsGroupBox;
        private System.Windows.Forms.Label ReplaceWithLabel;
        private System.Windows.Forms.Label SelectAnimationLabel;
        private System.Windows.Forms.ComboBox ReplaceWithComboBox;
        private System.Windows.Forms.ComboBox SelectAnimationComboBox;
        private System.Windows.Forms.Button ResetAllButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ReplaceButton;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip PrimaryStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel BaseAddressToolStripStatusLabel;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.Timer ControlTimer;
        private System.Windows.Forms.Button ChangeCameraTypeButton;
        private System.Windows.Forms.ToolStripStatusLabel CourseToolStripStatusLabel;
    }
}

