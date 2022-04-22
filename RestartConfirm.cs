/* https://twitter.com/HoodStrats || https://github.com/Hoodstrats */

using System;
using System.Windows.Forms;

namespace Hood.Core
{
    public partial class RestartConfirm : Form
    {
        public RestartConfirm()
        {
            InitializeComponent();
        }

        private void ConfirmClicked(object sender, EventArgs e)
        {
            Close();
        }
    }
}
