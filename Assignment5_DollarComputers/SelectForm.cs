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
        private List<string> getSelectedValue()
        {
            List<string> hardware = new List<string>
            {
                productDataGridView.SelectedRows[0].Cells[0].Value.ToString(),
                productDataGridView.SelectedRows[0].Cells[1].Value.ToString(),
                productDataGridView.SelectedRows[0].Cells[2].Value.ToString(),
                productDataGridView.SelectedRows[0].Cells[3].Value.ToString(),
                productDataGridView.SelectedRows[0].Cells[4].Value.ToString(),
                productDataGridView.SelectedRows[0].Cells[5].Value.ToString(),
                productDataGridView.SelectedRows[0].Cells[6].Value.ToString(),
                productDataGridView.SelectedRows[0].Cells[7].Value.ToString(),
                productDataGridView.SelectedRows[0].Cells[8].Value.ToString(),
                productDataGridView.SelectedRows[0].Cells[9].Value.ToString(),
                productDataGridView.SelectedRows[0].Cells[10].Value.ToString(),
                productDataGridView.SelectedRows[0].Cells[11].Value.ToString(),
                productDataGridView.SelectedRows[0].Cells[12].Value.ToString(),
                productDataGridView.SelectedRows[0].Cells[13].Value.ToString(),
                productDataGridView.SelectedRows[0].Cells[14].Value.ToString(),
                productDataGridView.SelectedRows[0].Cells[15].Value.ToString()
            };


            return hardware;
        }

        public void nextButton_Click_1(object sender, EventArgs e)
        {
            ProductInfoForm productInfoForm = new ProductInfoForm(getSelectedValue());
            productInfoForm.Show();
            this.Hide();
        }
    }
}
