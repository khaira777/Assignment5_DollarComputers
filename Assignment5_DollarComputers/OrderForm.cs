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
    public partial class OrderForm : Form
    {
        //local list declared to stored product details
        private List<string> productDetails;

        /// <summary>
        /// When form is instantiated in product info form, this constructor will add add values of product to list.
        /// This also add text to textboxes and to List Box with proper formatting.
        /// This calculates the cost and taxes and display accordingly
        /// </summary>
        /// <param name="productDetails"></param>
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

        // Takes user to previous form.
        private void backButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm productInfoForm = new ProductInfoForm(productDetails);
            productInfoForm.Show();
            this.Hide();
        }

        // Exits the application.
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Finish button will give message and then exits the application
        private void finishButton_Click(object sender, EventArgs e)
        {
            DialogResult end = MessageBox.Show("Thank you for your business. Your order will be processed in 7 - 10 business days.", "Thank You!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (end == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        // This will show message that your order is printing.
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order is printing...", "Printing", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // This show details of programmer, version and other stuff.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmer's Name : Gurkirat Khaira\n  Version : 1.0  \n Website:dollarcomputer.ca\n Contact : 6475555555", "About");
        }
    }
}
