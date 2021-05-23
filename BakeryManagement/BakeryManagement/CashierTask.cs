using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BakeryManagement
{
    public partial class CashierTask : Form
    {
        public CashierTask()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generateReceipt f5 = new generateReceipt();
            f5.Visible = true;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageBakeryItems f6 = new ManageBakeryItems();
            f6.Visible = true;
            this.Hide();
        }
    }
}
