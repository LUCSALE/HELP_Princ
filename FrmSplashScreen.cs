using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HELP_Princ
{
    public partial class FrmSplashScreen : Form
    {
        public FrmSplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 5; 
            if (progressBar1.Value >= 100) 
            { 
                timer1.Stop();
                FrmMenuPrincipal frm = new FrmMenuPrincipal(); 
                frm.Show(); 
                this.Hide(); 
            }
        }

        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0; 
            timer1.Start();
        }
    }
}
