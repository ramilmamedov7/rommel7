using System;
using System.Windows.Forms;
using Phonebook.Models;
using System.Linq;

namespace Phonebook
{
    public partial class PhonebookForm : Form
    {
        private PhonebookDBEntities db = new PhonebookDBEntities();
        public PhonebookForm()
        {
            InitializeComponent();
            LoadDatas();
            BtnSearch.Enabled = true;
            BtnSave.Enabled = false;
            lblName.Visible = false;
            lblNumber.Visible = false;
            txtName.Visible = false;
            txtNumber.Visible = false;
        }
        private void LoadDatas()
        {
            dgv.DataSource = db.Contacts.Select(c => new
            {
                c.ID,
                c.Name,
                c.Number
            }).ToList();
        }
        private void View(object sender, EventArgs e)
        {
            LoadDatas();
            BtnSearch.Enabled = true;
            BtnSave.Enabled = false;
            lblName.Visible = false;
            lblNumber.Visible = false;
            txtName.Visible = false;
            txtNumber.Visible = false;
            BtnSearch.Visible = true;
            txtSearch.Visible = true;
        }

        private void Insert(object sender, EventArgs e)
        {
            BtnSave.Enabled = true;
            lblName.Visible = true;
            lblNumber.Visible = true;
            txtName.Visible = true;
            txtNumber.Visible = true;
            BtnSearch.Visible = false;
            txtSearch.Visible = false;
        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string number = txtNumber.Text;
            int count = 0;
            // Int64


            if (name == string.Empty || number == string.Empty)
            {
                MessageBox.Show("Fill the boxs!");
                return;
            }
            if (!int.TryParse(txtNumber.Text, out count))
            {
                MessageBox.Show("Enter valid number!");
                return;
            }

            Contact newContact = new Contact();
            newContact.Name = name;
            newContact.Number = number;
            db.Contacts.Add(newContact);
            db.SaveChanges();
            db.SaveChangesAsync();
            LoadDatas();
            Reset();
        }
        private void Reset()
        {
            txtName.Text = "";
            txtNumber.Text = "";
        }

        private void BtnSearchClick(object sender, EventArgs e)
        {

        }

        private void About(object sender, EventArgs e)
        {
            MessageBox.Show("By Ramil Mamedov");
        }
        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
