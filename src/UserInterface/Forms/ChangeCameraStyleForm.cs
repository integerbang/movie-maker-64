using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieMaker64.UserInterface
{
    public partial class ChangeCameraStyleForm : Form
    {
        public ChangeCameraStyleForm()
        {
            InitializeComponent();
        }

        #region Events
        private void CancelOperation(object sender, EventArgs e) => Close();
        #endregion
    }
}