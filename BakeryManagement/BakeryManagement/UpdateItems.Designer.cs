
namespace BakeryManagement
{
    partial class UpdateItems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateItems));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddItemComboBox = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(298, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Bakery Items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(245, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Items";
            // 
            // AddButton
            // 
            this.AddButton.AccessibleName = "";
            this.AddButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Location = new System.Drawing.Point(557, 329);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(131, 36);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddItemComboBox
            // 
            this.AddItemComboBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddItemComboBox.FormattingEnabled = true;
            this.AddItemComboBox.Items.AddRange(new object[] {
            "Spring Rolls",
            "Puffs (Sugar coated)",
            "Chocolate puffs",
            "Haleem Rolls",
            "chocolate Pastries",
            "Pineapple Pastries",
            "Lemon Tart",
            "Donuts (chocolate)",
            "Donuts (Vanilla)",
            "Pizza(Small)",
            "Pizza(Medium)",
            "Pizza(Large)",
            "Nankhatai",
            "Biscuits",
            "Barfi (250 g)",
            "Barfi (500 g)",
            "Barfi (1 kg)",
            "Gulab jamun (250 g)",
            "Gulab jamun (500 g)",
            "Gulab Jamun (1 kg)",
            "Club Sandwich ",
            "Cold Sandwich",
            "Shawarma",
            "chicken Burger",
            "Crispy shots",
            "Peri peri Burger",
            "Chocolate cake (1 pound)",
            "Chocolate cake (2 pound)",
            "Pineapple cake (1 pound)",
            "Pineapple cake (2 pound)",
            "Red velvet Cake (2 pound)",
            "Marble cake (2 pound)",
            "Strawberry cake (2 pound)",
            "cupcake",
            "Mango Slush",
            "Orange Slush",
            "Blueberry Slush"});
            this.AddItemComboBox.Location = new System.Drawing.Point(411, 125);
            this.AddItemComboBox.Name = "AddItemComboBox";
            this.AddItemComboBox.Size = new System.Drawing.Size(190, 23);
            this.AddItemComboBox.TabIndex = 3;
            this.AddItemComboBox.SelectedIndexChanged += new System.EventHandler(this.AddItemComboBox_SelectedIndexChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.AccessibleName = "";
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkedListBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Haleem Rolls",
            "Cup Cakes",
            "Chocolate Cake (1 pound)",
            "Chocolate Cake (2 pound)",
            "Puffs(Sugar coated)",
            "Donuts"});
            this.checkedListBox1.Location = new System.Drawing.Point(451, 235);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(214, 88);
            this.checkedListBox1.TabIndex = 4;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // UpdateItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.AddItemComboBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateItems";
            this.Text = "UpdateItems";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox AddItemComboBox;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}