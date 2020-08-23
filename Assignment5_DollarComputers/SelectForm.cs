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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        // This exits application.
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // OnLoad of this form the database is added to the data grid view.
        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDBDataSet1.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.productDBDataSet1.products);

        }

        /// <summary>
        /// When a product is selected the event will add the values of the product to the selection text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (productDataGridView.SelectedRows.Count > 0)
            {
                // display selected product details in the selection Text Box
                selectionTextBox.Text = productDataGridView.SelectedCells[2].Value.ToString() + " "
                    + productDataGridView.SelectedCells[3].Value.ToString() + " Price: "
                    + productDataGridView.SelectedCells[1].Value.ToString();

                nextButton.Enabled = true;
            }
        }

        // This method add the details to a list so that it can be passed to another form.
        private List<string> getSelectedValue()
        {
            List<string> hardware= new List<string>{};
            for (int i = 0; i <= 30; i++)
            {
                hardware.Add(productDataGridView.SelectedRows[0].Cells[i].Value.ToString());
            }
            return hardware;
        }

        // Next button will call above method to be passed as an argument to the product info form constructor
        public void nextButton_Click_1(object sender, EventArgs e)
        {
            ProductInfoForm productInfoForm = new ProductInfoForm(getSelectedValue());
            productInfoForm.Show();
            this.Hide();
        }
    }
}