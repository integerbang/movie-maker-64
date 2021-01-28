using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace MovieMaker64.UserInterface
{
    static class Program
    {
        /// <summary>
        /// Represents the main entry point for this application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var _process_list_form = new ProcessListForm();

            Application.Run(_process_list_form);
            _process_list_form.Dispose();

            if (_process_list_form.ProcessesListBox.SelectedItem != null)
            {
                try
                {
                    var _process_id = Process.GetProcessesByName(_process_list_form.ProcessesListBox.SelectedItem.ToString()).ElementAt
                        (_process_list_form.ProcessesListBox.SelectedIndex).Id;

                    var _primary_form = new PrimaryForm(_process_id);

                    Application.Run(_primary_form);
                    _primary_form.Dispose();
                }
                catch (Exception _exception)
                {
                    MessageBox.Show(_exception.Message, _exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}