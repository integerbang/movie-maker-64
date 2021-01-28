using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MovieMaker64.UserInterface
{
    public partial class ProcessListForm : Form
    {
        public ProcessListForm() => InitializeComponent();

        #region Events
        private void AttachProcess(object sender, EventArgs e)
        {
            if (ProcessesListBox.SelectedItem == null)
            {
                MessageBox.Show(Properties.Resources.ProcessNotSelectedMessageText, Properties.Resources.ProcessNotSelectedMessageCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Close();
            }
        }

        private void CancelOperation(object sender, EventArgs e)
        {
            if (ProcessesListBox.SelectedItem != null)
                ProcessesListBox.ClearSelected();

            Application.Exit();
        }

        private void FormLoad(object sender, EventArgs e) => Utils.ToggleControls(false, this);

        private void RefreshList(object sender, EventArgs e)
        {
            Utils.ToggleControls(false, this);
            RefreshTimer.Start();
        }

        private void RefreshTick(object sender, EventArgs e)
        {
            ProcessesListBox.DataSource =
                Utils.ReturnEmulatorProcesses().Select(x => x.ProcessName).ToList();

            Utils.ToggleControls(true, this);
            RefreshTimer.Stop();
        }
        #endregion
    }
}