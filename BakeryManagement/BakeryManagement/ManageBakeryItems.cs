using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BakeryManagement
{
    public partial class ManageBakeryItems : Form
    {
        public ManageBakeryItems()
        {
            InitializeComponent();
        }

        private void ManageBakeryItems_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BakeryItemsCount form = new BakeryItemsCount();
            form.Visible = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateItems f9 = new UpdateItems();
            f9.Visible = true;
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
