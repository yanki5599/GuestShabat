using GuestShabat.DAL;
using GuestShabat.Model;
using GuestShabat.Reposetory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestShabat
{
    public  class FormHandler
    {
        DBContext _dbContex;
        private GuestLoginForm _guestLoginForm;
        private List<CategoryAndFoodForm> _listCategoryAndFoodForms = 
            new List<CategoryAndFoodForm>();
        private CategoryRepository _categoryRepository;
        private int index;
        private GuestModel? _guest = null;

        public FormHandler(DBContext dbContex)
        {
            _dbContex = dbContex;
            _categoryRepository = new CategoryRepository(dbContex);
            _guestLoginForm = new GuestLoginForm(this,_dbContex);

        }


        private void LoadCategoryForms()
        {
            foreach (var category in _categoryRepository.GetAll())
                _listCategoryAndFoodForms.Add(new CategoryAndFoodForm(this,_dbContex,category,_guest!));
        }

        public void Next()
        {
            _listCategoryAndFoodForms[index].Hide();
            index = (index + 1) % _listCategoryAndFoodForms.Count;
            ShowCategory();
        }
        public void Previous()
        {
            _listCategoryAndFoodForms[index].Hide();
            index = (index - 1 + _listCategoryAndFoodForms.Count) % _listCategoryAndFoodForms.Count;
            ShowCategory();
        }

        public void Run()
        {
            _guestLoginForm.Show();
        }

        public void ShowCategory()
        {
            if (index >= 0)
            {
                _listCategoryAndFoodForms[index].LoadData();
                _listCategoryAndFoodForms[index].Show();
            }
            else
                throw new Exception("something went worng , from index was negative.");
        }

        public void ShowFirstCategoryForm(GuestModel guest)
        {
            _guest = guest;
            LoadCategoryForms();
            if(_listCategoryAndFoodForms.Count <= 0)
            {
                MessageBox.Show("אין קטגוריות עדיין, בקש מהמארח להוסיף קטגוריות","אופס",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                Application.Exit();
                return; // the app doesn't exit without that. need investigation.
            }
            _guestLoginForm.CloseWithOutExit();
            ShowCategory();

        }
    }
}
