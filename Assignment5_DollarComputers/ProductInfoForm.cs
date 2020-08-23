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
            memoryTextBox.Text = productDetails[4];
            lcdSizeTextBox.Text = productDetails[5];
            cpuBrandTextBox.Text = productDetails[6];
            cpuTypeTextBox.Text = productDetails[7];
            cpuNumberTextBox.Text = productDetails[8];
            cpuSpeedTextBox.Text = productDetails[9];
            conditionTextBox.Text = productDetails[10];
            platformTextBox.Text = productDetails[11];
            osTextBox.Text = productDetails[12];
            hddTextBox.Text = productDetails[13];
            gpuTextBox.Text = productDetails[14];
            webCamTextBox.Text = productDetails[15];
        }
        public ProductInfoForm()
        {
            InitializeComponent();
            this.openToolStripMenuItem.PerformClick();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter outputStream = new StreamWriter(saveFileDialog.FileName);
                    for (int i = 0; i < this.productDetails.Count; i++)
                    {
                        outputStream.WriteLine(this.productDetails[i]);
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
            if(result == DialogResult.OK)
            {
                StreamReader inputStream = new StreamReader(File.Open(openFileDialog.FileName, FileMode.Open));
                productIdTextBox.Text = inputStream.ReadLine();

                costTextBox.Text = inputStream.ReadLine();
                manufacturerTextBox.Text = inputStream.ReadLine();
                modelTextBox.Text = inputStream.ReadLine();
                memoryTextBox.Text = inputStream.ReadLine();
                lcdSizeTextBox.Text = inputStream.ReadLine();
                cpuBrandTextBox.Text = inputStream.ReadLine();
                cpuTypeTextBox.Text = inputStream.ReadLine();
                cpuNumberTextBox.Text = inputStream.ReadLine();
                cpuSpeedTextBox.Text = inputStream.ReadLine();
                conditionTextBox.Text = inputStream.ReadLine();
                platformTextBox.Text = inputStream.ReadLine();
                osTextBox.Text = inputStream.ReadLine();
                hddTextBox.Text = inputStream.ReadLine();
                gpuTextBox.Text = inputStream.ReadLine();
                webCamTextBox.Text = inputStream.ReadLine();

                inputStream.Close();
            }
            else
            {
                Program.selectform.Show();
                this.Hide();
            }
        }

        private void selectAnotherProductButton_Click(object sender, EventArgs e)
        {
            Program.selectform.Show();
            this.Hide();
        }

        private void selectAnotherProductToolStripMenuItem_Click(object sender, EventArgs e)
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
