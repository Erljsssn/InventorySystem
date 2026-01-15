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