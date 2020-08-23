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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDBDataSet1.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.productDBDataSet1.products);

        }

        private void productDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (productDataGridView.SelectedRows.Count > 0)
            {
                // display selected product details in the selection Text Box
                selectionTextBox.Text = productDataGridView.SelectedCells[2].Value.ToString() + " "
                    + productDataGridView.SelectedCells[3].Value.ToString() + " Priced at: "
                    + productDataGridView.SelectedCells[1].Value.ToString();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Program.productinfoform.Show();
            this.Hide();
        }
    }
}
