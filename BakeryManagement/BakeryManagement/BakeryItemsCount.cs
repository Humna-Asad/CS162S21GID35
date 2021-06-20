using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BakeryManagement
{ 
    
    public partial class BakeryItemsCount : Form
    {
        DataTable dt = new DataTable();
        public BakeryItemsCount()
        {
            InitializeComponent();
        }
        public BakeryItemsCount(string []value,int size)
        {
            InitializeComponent();

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BakeryItemsCount_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("counts of cake", Type.GetType("System.Int32"));
            dt.Columns.Add("counts of cupcake", Type.GetType("System.Int32"));
            dt.Columns.Add("counts of biscuits", Type.GetType("System.Int32"));
            dt.Columns.Add("counts of brownies", Type.GetType("System.Int32"));
            dataGridView1.DataSource = dt;

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(textBox1.Text, textBox2.Text, textBox2.Text, textBox2.Text);
    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
