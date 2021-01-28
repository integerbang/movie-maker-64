using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MovieMaker64.UserInterface
{
    public class Utils
    {
        public static readonly string[] EmulatorProcessName =
            new[] { "Project64", "Project64d" };

        public static List<Process> ReturnEmulatorProcesses()
        {
            var _list = new List<Process>();

            foreach (string _emulator in EmulatorProcessName)
            {
                _list.AddRange(Process.GetProcessesByName(_emulator));
            }

            return _list;
        }

        public static void ToggleControls(bool _boolean, Form _form)
        {
            foreach (Control _control in _form.Controls)
                _control.Enabled = _boolean;
        }
    }
}