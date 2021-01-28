using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieMaker64.UserInterface
{
    public partial class AboutForm : Form
    {
        public AboutForm() => InitializeComponent();

        #region Events
        private void AboutFormLoad(object sender, EventArgs e) => ProductInformationLabel.Text = Application.ProductName;

        private void OkayButtonClick(object sender, EventArgs e) => Close();
        #endregion
    }
}