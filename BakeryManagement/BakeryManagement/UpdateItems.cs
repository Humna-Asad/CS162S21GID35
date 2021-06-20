using System.Windows.Forms;

namespace BakeryManagement
{
    public partial class UpdateItems : Form
    {
        string[] SelectedItems = new string[50];
        public UpdateItems()
        {
            InitializeComponent();
            
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
           
        }

        private void AddItemComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
           
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            int no_of_selectedItems = checkedListBox1.SelectedItems.Count;
            for (int i = 0; i < no_of_selectedItems; i++)
            { 
               SelectedItems[i]= checkedListBox1.SelectedItem.ToString();
            }
            
        }
    }
}
