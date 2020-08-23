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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        // This close the application.
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Takes user to select form.
        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            Program.selectform.Show();
            this.Hide();
        }

        // Triggers product info form constructor and hide current form.
        public void SavedOrderButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm productinfoform = new ProductInfoForm();
            this.Hide();
        }
    }
}
