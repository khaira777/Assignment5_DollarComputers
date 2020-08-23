using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Gurkirat Khaira
 * Student: 301112565
 * Programming-2
 * Dollar Computers
 * Assignment-5
 */

namespace Assignment5_DollarComputers
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        //Hides splash form, shows the start form and disables the timer of splash form.
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            Program.startform.Show();
            SplashFormTimer.Enabled = false;
        }
    }
}
