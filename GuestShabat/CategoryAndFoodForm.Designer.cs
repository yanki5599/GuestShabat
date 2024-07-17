namespace GuestShabat
{
    partial class CategoryAndFoodForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryAndFoodForm));
            label_categoryName = new Label();
            dataGridView_allGuestsFood = new DataGridView();
            button_addFood = new Button();
            dataGridView_currentGuestFoods = new DataGridView();
            button_next = new Button();
            button_previous = new Button();
            textBox_newFood = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_allGuestsFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_currentGuestFoods).BeginInit();
            SuspendLayout();
            // 
            // label_categoryName
            // 
            label_categoryName.AutoSize = true;
            label_categoryName.BackColor = Color.Transparent;
            label_categoryName.Font = new Font("Segoe UI", 16F);
            label_categoryName.Location = new Point(264, 30);
            label_categoryName.Name = "label_categoryName";
            label_categoryName.Size = new Size(160, 30);
            label_categoryName.TabIndex = 0;
            label_categoryName.Text = "<שם קטגוריה>";
            // 
            // dataGridView_allGuestsFood
            // 
            dataGridView_allGuestsFood.AllowUserToAddRows = false;
            dataGridView_allGuestsFood.AllowUserToDeleteRows = false;
            dataGridView_allGuestsFood.BackgroundColor = Color.White;
            dataGridView_allGuestsFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_allGuestsFood.Location = new Point(109, 79);
            dataGridView_allGuestsFood.Name = "dataGridView_allGuestsFood";
            dataGridView_allGuestsFood.ReadOnly = true;
            dataGridView_allGuestsFood.RightToLeft = RightToLeft.Yes;
            dataGridView_allGuestsFood.Size = new Size(458, 150);
            dataGridView_allGuestsFood.TabIndex = 1;
            // 
            // button_addFood
            // 
            button_addFood.Font = new Font("Segoe UI", 12F);
            button_addFood.Location = new Point(450, 277);
            button_addFood.Name = "button_addFood";
            button_addFood.Size = new Size(117, 29);
            button_addFood.TabIndex = 2;
            button_addFood.Text = "הוסף";
            button_addFood.UseVisualStyleBackColor = true;
            button_addFood.Click += button_addFood_Click;
            // 
            // dataGridView_currentGuestFoods
            // 
            dataGridView_currentGuestFoods.AllowUserToAddRows = false;
            dataGridView_currentGuestFoods.AllowUserToDeleteRows = false;
            dataGridView_currentGuestFoods.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView_currentGuestFoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_currentGuestFoods.Location = new Point(109, 355);
            dataGridView_currentGuestFoods.Name = "dataGridView_currentGuestFoods";
            dataGridView_currentGuestFoods.ReadOnly = true;
            dataGridView_currentGuestFoods.RightToLeft = RightToLeft.Yes;
            dataGridView_currentGuestFoods.Size = new Size(458, 150);
            dataGridView_currentGuestFoods.TabIndex = 1;
            // 
            // button_next
            // 
            button_next.Font = new Font("Segoe UI", 12F);
            button_next.Location = new Point(177, 537);
            button_next.Name = "button_next";
            button_next.Size = new Size(117, 40);
            button_next.TabIndex = 2;
            button_next.Text = "<<< הבא";
            button_next.UseVisualStyleBackColor = true;
            button_next.Click += button_next_Click;
            // 
            // button_previous
            // 
            button_previous.Font = new Font("Segoe UI", 12F);
            button_previous.Location = new Point(375, 537);
            button_previous.Name = "button_previous";
            button_previous.Size = new Size(117, 40);
            button_previous.TabIndex = 2;
            button_previous.Text = "הקודם >>>";
            button_previous.UseVisualStyleBackColor = true;
            button_previous.Click += button_previous_Click;
            // 
            // textBox_newFood
            // 
            textBox_newFood.Font = new Font("Segoe UI", 12F);
            textBox_newFood.Location = new Point(285, 277);
            textBox_newFood.Margin = new Padding(3, 3, 10, 3);
            textBox_newFood.Name = "textBox_newFood";
            textBox_newFood.PlaceholderText = "הכנס שם מאכל";
            textBox_newFood.Size = new Size(139, 29);
            textBox_newFood.TabIndex = 3;
            textBox_newFood.TextAlign = HorizontalAlignment.Right;
            // 
            // CategoryAndFoodForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(653, 625);
            Controls.Add(textBox_newFood);
            Controls.Add(button_previous);
            Controls.Add(button_next);
            Controls.Add(button_addFood);
            Controls.Add(dataGridView_currentGuestFoods);
            Controls.Add(dataGridView_allGuestsFood);
            Controls.Add(label_categoryName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(669, 664);
            MinimumSize = new Size(669, 664);
            Name = "CategoryAndFoodForm";
            RightToLeft = RightToLeft.No;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "רשימת מאכלים בקטגוריה";
            FormClosed += CategoryAndFoodForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridView_allGuestsFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_currentGuestFoods).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_categoryName;
        private DataGridView dataGridView_allGuestsFood;
        private Button button_addFood;
        private DataGridView dataGridView_currentGuestFoods;
        private Button button_next;
        private Button button_previous;
        private TextBox textBox_newFood;
    }
}