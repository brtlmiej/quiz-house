using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w61929_quiz
{
    public partial class LoadingPanel : UserControl
    {
        public LoadingPanel()
        {
            InitializeComponent();
        }

        public void showLoadingScreen()
        {
            panelLoad.Width = 50;
            Visible = true;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            panelLoad.Width += 10;
            if (panelLoad.Width >= panelLoadBack.Width)
            {
                timer.Stop();
                Visible = false;
            }
        }
    }
}
