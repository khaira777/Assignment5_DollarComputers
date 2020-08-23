using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5_DollarComputers
{
    public partial class ProductInfoForm : Form
    {
        private List<string> productDetails;

        public ProductInfoForm(List<string> productDetails)
        {
            this.productDetails = productDetails;

            InitializeComponent();

            productIdTextBox.Text = productDetails[0];
            costTextBox.Text = productDetails[1];
            manufacturerTextBox.Text = productDetails[2];
            modelTextBox.Text = productDetails[3];
            memoryTextBox.Text = productDetails[5];
            lcdSizeTextBox.Text = productDetails[7];
            cpuBrandTextBox.Text = productDetails[10];
            cpuTypeTextBox.Text = productDetails[11];
            cpuNumberTextBox.Text = productDetails[13];
            cpuSpeedTextBox.Text = productDetails[12];
            conditionTextBox.Text = productDetails[14];
            platformTextBox.Text = productDetails[16];
            osTextBox.Text = productDetails[15];
            hddTextBox.Text = productDetails[17];
            gpuTextBox.Text = productDetails[19];
            webCamTextBox.Text = productDetails[30];

            nextButton.Enabled = true;
        }
        public ProductInfoForm()
        {
            InitializeComponent();
            this.openToolStripMenuItem.PerformClick();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter outputStream = new StreamWriter(saveFileDialog.FileName);
                    foreach (var t in this.productDetails)
                    {
                        outputStream.WriteLine(t);
                    }
                    outputStream.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            DialogResult result = this.openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.Show();
                StreamReader inputStream = new StreamReader(openFileDialog.FileName);

                this.productDetails = File.ReadAllLines(openFileDialog.FileName).ToList();
                productIdTextBox.Text = this.productDetails[0];
                costTextBox.Text = this.productDetails[1];
                manufacturerTextBox.Text = this.productDetails[2];
                modelTextBox.Text = this.productDetails[3];
                memoryTextBox.Text = this.productDetails[5];
                lcdSizeTextBox.Text = this.productDetails[7];
                cpuBrandTextBox.Text = this.productDetails[10];
                cpuTypeTextBox.Text = this.productDetails[11];
                cpuNumberTextBox.Text = this.productDetails[13];
                cpuSpeedTextBox.Text = this.productDetails[12];
                conditionTextBox.Text = this.productDetails[14];
                platformTextBox.Text = this.productDetails[16];
                osTextBox.Text = this.productDetails[15];
                hddTextBox.Text = this.productDetails[17];
                gpuTextBox.Text = this.productDetails[19];
                webCamTextBox.Text = this.productDetails[30];

                inputStream.Close();

                nextButton.Enabled = true;
            }
            else
            {
                foreach (Form f in Application.OpenForms)
                {
                    f.Hide();
                }
                Program.selectform.Show();
                
            }
        }
        private void selectAnotherProductButton_Click(object sender, EventArgs e)
        {
            Program.selectform.Show();
            this.Hide();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            OrderForm orderform = new OrderForm(this.productDetails);
            orderform.Show();
            this.Hide();
        }
    }
}
