using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inveentory__system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

      
    
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(textBoxItemName.Text))
            {
                MessageBox.Show("Please enter an item name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxPrice.Text) ||
                string.IsNullOrWhiteSpace(textBoxStock.Text) ||
                string.IsNullOrWhiteSpace(textBoxCostPrice.Text) ||
                string.IsNullOrWhiteSpace(textBoxSellingPrice.Text))
            {
                MessageBox.Show("Please fill in all price and stock fields.");
                return;
            }

            // Validate numeric inputs
            if (!int.TryParse(textBoxStock.Text, out int totalStock))
            {
                MessageBox.Show("Stock must be a valid integer.");
                return;
            }

            if (!decimal.TryParse(textBoxPrice.Text, out decimal price))
            {
                MessageBox.Show("Price must be a valid decimal number.");
                return;
            }

            if (!decimal.TryParse(textBoxCostPrice.Text, out decimal costPrice))
            {
                MessageBox.Show("Cost Price must be a valid decimal number.");
                return;
            }

            if (!decimal.TryParse(textBoxSellingPrice.Text, out decimal sellingPrice))
            {
                MessageBox.Show("Selling Price must be a valid decimal number.");
                return;
            }

            int quantityUsed = (int)numericUpDownQuantity.Value;

            // Calculate stock status (adjust as per your logic)
            string stockStatus = (totalStock - quantityUsed) > 0 ? "Available" : "Out of Stock";
            string stockResult = (totalStock - quantityUsed).ToString();

            // Add new row to DataGridView
            int rowIndex = dataGridViewInventory.Rows.Add();

            dataGridViewInventory.Rows[rowIndex].Cells["dataGridViewTextBoxColumn1"].Value = textBoxItemName.Text;
            dataGridViewInventory.Rows[rowIndex].Cells["dataGridViewTextBoxColumn3"].Value = quantityUsed;
            dataGridViewInventory.Rows[rowIndex].Cells["dataGridViewTextBoxColumn4"].Value = price.ToString("F2");
            dataGridViewInventory.Rows[rowIndex].Cells["dataGridViewTextBoxColumnSupplier"].Value = textBoxSupplier.Text;
            dataGridViewInventory.Rows[rowIndex].Cells["dataGridViewTextBoxColumnCostPrice"].Value = costPrice.ToString("F2");
            dataGridViewInventory.Rows[rowIndex].Cells["dataGridViewTextBoxColumnSellingPrice"].Value = sellingPrice.ToString("F2");
            dataGridViewInventory.Rows[rowIndex].Cells["dataGridViewTextBoxColumn6"].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            dataGridViewInventory.Rows[rowIndex].Cells["dataGridViewTextBoxColumn7"].Value = stockStatus;
            dataGridViewInventory.Rows[rowIndex].Cells["dataGridViewTextBoxColumn8"].Value = stockResult;

            MessageBox.Show("Item saved successfully!");

            // Clear inputs after save
            textBoxItemName.Clear();
            numericUpDownQuantity.Value = 0;
            textBoxPrice.Clear();
            textBoxStock.Clear();
            textBoxSupplier.Clear();
            textBoxCostPrice.Clear();
            textBoxSellingPrice.Clear();
        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {
            // Optional click event for date label
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("MMMM dd, yyyy  hh:mm:ss tt");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCler_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewInventory.Rows)
            {
                row.Visible = true;
            }
        }
    }
}