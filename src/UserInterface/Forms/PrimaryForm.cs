using MovieMaker64.Core;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieMaker64.UserInterface
{
    public partial class PrimaryForm : Form
    {
        public Session UserSession;

        public PrimaryForm(int _process_id)
        {
            UserSession = new Session()
            {
                Emulator = new Stream(_process_id)
            };

            InitializeComponent();
        }

        #region Events
        private void AboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            var _about = new AboutForm();
            _about.ShowDialog(this);

            _about.Dispose();
        }

        private void CameraToggleButtonClick(object sender, EventArgs e)
        {
            byte _data;

            if (UserSession.Emulator.AttachedProcessBaseAddress != 0)
                UserSession.CameraIsFrozen = !UserSession.CameraIsFrozen;

            if (UserSession.CameraIsFrozen == true)
            {
                _data = 0x80;
            }
            else
            {
                _data = 0x00;
            }

            UserSession.CameraState = _data;
        }

        private void ChangeCameraTypeClick(object sender, EventArgs e)
        {
            var _change_camera_style_form = new ChangeCameraStyleForm();
            _change_camera_style_form.ShowDialog(this);

            _change_camera_style_form.Dispose();
        }

        private void ControlTick(object sender, EventArgs e)
        {
            if (UserSession.Emulator.AttachedProcessBaseAddress != 0)
            {
                // Checks the camera state.
                if (UserSession.CameraState == 0x00)
                {
                    CameraToggleButton.Text = Properties.Resources.FreezeCameraButtonLabel;
                    UserSession.CameraIsFrozen = false;
                }
                else if (UserSession.CameraState >= 0x80)
                {
                    CameraToggleButton.Text = Properties.Resources.UnfreezeCameraButtonLabel;
                    UserSession.CameraIsFrozen = true;
                }

                // Checks the soft-camera state.
                if (UserSession.SoftCameraState[0] == 0x00 || UserSession.SoftCameraState[1] == 0x33)
                {
                    SoftCameraToggleButton.Text = Properties.Resources.SoftfreezeCameraButtonLabel;
                    UserSession.CameraIsSoftFrozen = false;
                }
                else if (UserSession.SoftCameraState[1] != 0x33)
                {
                    SoftCameraToggleButton.Text = Properties.Resources.SoftunfreezeCameraButtonLabel;
                    UserSession.CameraIsSoftFrozen = true;
                }
            }
        }

        private void ExitToolStripMenuItemClick(object sender, EventArgs e) => Application.Exit();

        private void FormLoad(object sender, EventArgs e)
        {
            BaseAddressToolStripStatusLabel.Text = string.Format(Properties.Resources.CurrentBaseAddressStatusLabel,
                    string.Empty);

            CourseToolStripStatusLabel.Text = string.Format(Properties.Resources.CurrentCourseStatusLabel,
                    string.Empty);

            Text = string.Format("{0} - [{1}] {2}", Application.ProductName,
                UserSession.Emulator.AttachedProcess.Id, UserSession.Emulator.AttachedProcess.ProcessName);
        }

        private void RefreshBaseAddress(object sender, EventArgs e) => UserSession.Emulator.RefetchBaseAddress();

        private void SoftCameraToggleButtonClick(object sender, EventArgs e)
        {
            byte[] _data;

            if (UserSession.Emulator.AttachedProcessBaseAddress != 0)
                UserSession.CameraIsSoftFrozen = !UserSession.CameraIsSoftFrozen;

            if (UserSession.CameraIsSoftFrozen == true)
            {
                _data = BitConverter.GetBytes(0x8000C520);
            }
            else
            {
                _data = BitConverter.GetBytes(0x8033C520);
            }

            UserSession.SoftCameraState = _data;
        }

        private void UpdateTick(object sender, EventArgs e)
        {
            if (!UserSession.Emulator.AttachedProcessIsRunning)
            { // Exits if the attached process has also exited.
                Application.Exit();
            }

            // Ensures that the camera state is not overwritten while entering a new course or in first-person view.
            if (UserSession.CameraIsFrozen && (UserSession.CameraState < 0x80 || UserSession.CameraState == 0xA2))
                UserSession.CameraState = 0x80;

            if (UserSession.Emulator.AttachedProcessBaseAddress != 0)
            { // Sets the status label's text to the current base address.
                BaseAddressToolStripStatusLabel.Text = string.Format(Properties.Resources.CurrentBaseAddressStatusLabel,
                    "0×" + UserSession.Emulator.AttachedProcessBaseAddress.ToString("X"));
            }
            else
            { // Outputs this if the base address returns as a zero.
                BaseAddressToolStripStatusLabel.Text = string.Format(Properties.Resources.CurrentBaseAddressStatusLabel,
                    Properties.Resources.UnknownLabel);
            }

            if (UserSession.InternalCourseID != 0)
            {
                CourseToolStripStatusLabel.Text = string.Format(Properties.Resources.CurrentCourseStatusLabel,
                    UserSession.InternalCourseID.ToString());
            }
            else
            {
                CourseToolStripStatusLabel.Text = string.Format(Properties.Resources.CurrentCourseStatusLabel,
                    Properties.Resources.UnassignedLabel);
            }
        }
        #endregion
    }
}