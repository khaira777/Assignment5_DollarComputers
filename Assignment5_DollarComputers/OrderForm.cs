using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5_DollarComputers
{
    public partial class OrderForm : Form
    {
        private List<string> productDetails;
        public OrderForm(List<string> productDetails)
        {
            InitializeComponent();
            this.productDetails = productDetails;

            manufacturerTextBox.Text = this.productDetails[2];
            modelTextBox.Text = this.productDetails[3];
            conditionTextBox.Text = this.productDetails[14];
            platformTextBox.Text = this.productDetails[11];

            productDetailsListBox.Items.Add(productDetails.ElementAt(7));
            productDetailsListBox.Items.Add("");
            productDetailsListBox.Items.Add(productDetails.ElementAt(5));
            productDetailsListBox.Items.Add("");
            productDetailsListBox.Items.Add(productDetails.ElementAt(10));
            productDetailsListBox.Items.Add("");
            productDetailsListBox.Items.Add(productDetails.ElementAt(9));
            productDetailsListBox.Items.Add("");
            productDetailsListBox.Items.Add(productDetails.ElementAt(6));
            productDetailsListBox.Items.Add("");
            productDetailsListBox.Items.Add(productDetails.ElementAt(13));
            productDetailsListBox.Items.Add("");
            productDetailsListBox.Items.Add(productDetails.ElementAt(4));
            productDetailsListBox.Items.Add("");
            productDetailsListBox.Items.Add(productDetails.ElementAt(15));
            

            costTextBox.Text = productDetails[1];
            string cost = productDetails[1].Trim('$');
            double salesTax = Convert.ToDouble(cost) * 0.13;
            double total = Convert.ToDouble(cost) * 1.13;
            salesTaxTextBox.Text = "$" + salesTax.ToString();
            totalTextBox.Text = "$" + total.ToString();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm productInfoForm = new ProductInfoForm(productDetails);
            productInfoForm.Show();
            this.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            DialogResult end = MessageBox.Show("Thank you for your business. Your order will be processed in 7 - 10 business days.", "Thank You!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (end == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order is printing...", "Printing", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductInfoForm productInfoForm = new ProductInfoForm(productDetails);
            productInfoForm.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Name : Gurkirat Khaira\n Student:301112565\n v : 1.0  \n Contact : gkhaira9@my.centennialcollege.ca", "About");
        }
    }
}
