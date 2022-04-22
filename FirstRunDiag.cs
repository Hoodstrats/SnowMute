/* https://twitter.com/HoodStrats || https://github.com/Hoodstrats */

using System;
using System.Timers;
using System.Windows.Forms;

namespace Hood.Core
{
    public partial class FirstRunDiag : Form
    {
        static bool _canRun = false;
        static System.Timers.Timer timer;

        public delegate void InvokeDelegate();
        public FirstRunDiag()
        {
            InitializeComponent();
            _okBut.Text = "Take a sec to read";

            timer = new System.Timers.Timer();
            //in ms
            timer.Interval = 5000;
            timer.Elapsed += new ElapsedEventHandler(CanRun);
            timer.Start();
        }

        private void CanRun(object sender, ElapsedEventArgs e)
        {
            timer.Stop();
            _okBut.Invoke((InvokeDelegate)ChangeText);
            _canRun = true;
        }
        private void ChangeText()
        {
            _okBut.Text = "OK";
        }

        private void OkClicked(object sender, EventArgs e)
        {
            if (!_canRun)
            {
                return;
            }
            Close();
        }
    }
}
