using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwgEmuTool
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            lblProgress.Text = "";
            progressBar1.Value = 0;
        }

        public void UpdateProgess(string text, int step)
        {
            lblProgress.Text = text;
            progressBar1.Value = step;
        }
    }
}
