using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BakeryManagement
{
    public partial class generateReceipt : Form
    {
        public generateReceipt()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Receipt f8 = new Receipt();
            f8.Visible = true;
            this.Hide();
        }
    }
}
