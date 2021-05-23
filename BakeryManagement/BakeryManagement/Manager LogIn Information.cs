using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BakeryManagement
{
    public partial class Manager_LogIn_Information : Form
    {
        public Manager_LogIn_Information()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerTasks f10 = new ManagerTasks();
            f10.Visible=true;
            this.Hide();

        }
    }
}
