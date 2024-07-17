using GuestShabat.DAL;
using GuestShabat.Model;
using GuestShabat.Reposetory;

namespace GuestShabat
{
    public partial class GuestLoginForm : Form
    {
        private bool IsNavigating = false;
        FormHandler _formHandler;
        DBContext _dbContext;
        private GuestRepository _guestRepository;
        AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
        public GuestLoginForm(FormHandler formHandler, DBContext dBContext)
        {
            _formHandler = formHandler;
            _dbContext = dBContext;
            _guestRepository = new GuestRepository(_dbContext);

            InitializeComponent();
            textBox_guestName.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox_guestName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            LoadGuestList(coll);
            textBox_guestName.AutoCompleteCustomSource = coll;
        }

        private void LoadGuestList(AutoCompleteStringCollection? coll = null)
        {
            foreach (var guest in _guestRepository.GetAll())
            {
                string guestName = guest.Name;
                if (coll != null)
                {
                    coll.Add(guestName);
                }
                listBox_GuestNames.Items.Add(guestName);
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string guestName = textBox_guestName.Text.Trim();

            if (string.IsNullOrEmpty(guestName))
            {
                MessageBox.Show("נא הכנס שם תקין", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!isGuestExist(guestName, out GuestModel? guest))
            {
                guest = _guestRepository.createAndReturn(guestName);
                MessageBox.Show("creating new guest...", "debug");
            }
            MessageBox.Show("loging you in...", "debug");
            _formHandler.ShowFirstCategoryForm(guest!);

        }

        private bool isGuestExist(string guestName, out GuestModel? guest)
        {
            guest = _guestRepository.FindByName(guestName)!;
            if (guest == null)
            {
                return false;
            }
            return true;
        }


        private void GuestLoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!IsNavigating)
                Application.Exit();
        }

        public void CloseWithOutExit()
        {
            IsNavigating = true;
            this.Close();
        }

        private void textBox_guestName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_login_Click(this, new EventArgs());// 
            }
        }

        private void listBox_GuestNames_DoubleClick(object sender, EventArgs e)
        {
            string name = (string)listBox_GuestNames.SelectedItem!;
            textBox_guestName.Text = name;
        }
    }
}
