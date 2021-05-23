using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BakeryManagement
{
    public partial class ManagerTasks : Form
    {
        public ManagerTasks()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manage_Employees f11 = new Manage_Employees();
            f11.Visible = true;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnalyzeSales f12 = new AnalyzeSales();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manage_Salary f13 = new Manage_Salary();
            f13.Visible = true;
            this.Hide();
        }
    }
}
