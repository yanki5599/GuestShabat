using GuestShabat.DAL;
using GuestShabat.Model;
using GuestShabat.Reposetory;
using ShabatHost.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuestShabat
{
    public partial class CategoryAndFoodForm : Form
    {
        FormHandler _fromHandler;
        CategoryModel _currentCategory;
        GuestModel _currentGuest;
        DBContext _dBContext;
        FoodRepository _foodRepository;
        public CategoryAndFoodForm(FormHandler formHandler, DBContext dBContext, CategoryModel categoryModel, GuestModel guestModel)
        {
            _fromHandler = formHandler;
            _dBContext = dBContext;
            _currentCategory = categoryModel;
            _currentGuest = guestModel;
            _foodRepository = new FoodRepository(dBContext);
            InitializeComponent();

            label_categoryName.Text = categoryModel.Name;
            dataGridView_allGuestsFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_currentGuestFoods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// adds the food to the db and refreshes the dataTable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_addFood_Click(object sender, EventArgs e)
        {
            string foodName = textBox_newFood.Text.Trim();
            if (string.IsNullOrEmpty(foodName))
            {
                MessageBox.Show("נא הכנס שם מאכל", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_newFood.Focus();
                return;
            }
            AddFood(new FoodModel(foodName, _currentGuest.ID, _currentCategory.ID));
            LoadCurrentGuestFood();
        }


        private void AddFood(FoodModel foodModel)
        {
            bool success = _foodRepository.Create(foodModel);
            if (!success)
            {
                MessageBox.Show("לא ניתן להוסיף את המאכל כי הוא קיים כבר.", "פריט קיים!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // maybe highlight item.
        }

        internal void LoadData()
        {
            LoadAllGuestsFood();
            LoadCurrentGuestFood();
        }
        private void LoadCurrentGuestFood()
        {
            var foods = _foodRepository.GetAllNameBy(_currentCategory, _currentGuest);
            dataGridView_currentGuestFoods.DataSource = foods;
        }

        private void LoadAllGuestsFood()
        {
            var foods = _foodRepository.GetAllByExcept(_currentCategory, _currentGuest);
            dataGridView_allGuestsFood.DataSource = foods;
        }

        private void CategoryAndFoodForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            _fromHandler.Next();
        }

        private void button_previous_Click(object sender, EventArgs e)
        {
            _fromHandler.Previous();
        }
    }
}
