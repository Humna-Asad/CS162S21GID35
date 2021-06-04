using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BakeryManagement
{
    public partial class CashierLogin : Form
    {
        String name;
        String password;
        public CashierLogin()
        {
            InitializeComponent();
        }

        public Boolean Validname(String name)
        {
            Boolean flag = false;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] >= 'A' && name[i] <= 'Z' || name[i] >= 'a' && name[i] <= 'z' || name[i] == ' ')
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }

            }
            return flag;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            CashierTask f4 = new CashierTask();
            String name = textBox1.Text;
            Validname(name);
            String password = textBox2.Text;
            if(password == "@6859humra")
            {
                   f4.Visible = true;
                   this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid LogIn information");
            }
            
        }
    }
} 
