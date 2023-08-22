using BuisnessApplication.BL;
using BuisnessApplication.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStoreMnagementSystem.View
{
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            InitializeComponent();
        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {
            if (Validations.CheckName(txtBoxName.Text))
            {
                txtBoxName.Focus();
                epName.SetError(this.txtBoxName, "User name Already Exists");
            }
            else if (string.IsNullOrEmpty(txtBoxName.Text) == true)
            {
                txtBoxName.Focus();
                epPassword.SetError(this.txtBoxName, "This field is required");
            }
            else
            {
                epName.Clear();
                epPassword.Clear();
            }
        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {

            string password = txtBoxPassword.Text;
            if (!Validations.CheckPassword(password))
            {
                txtBoxPassword.Focus();
                epPassword.SetError(this.txtBoxPassword, "Password must have length eight an uppercase,lowercase or special character");
            }
            else
            {
                epPassword.Clear();
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxName.Text) == true)
            {
                txtBoxName.Focus();
                epName.SetError(this.txtBoxName, "This field is required");
            }
            else if (string.IsNullOrEmpty(txtBoxPassword.Text) == true)
            {
                txtBoxPassword.Focus();
                epPassword.SetError(this.txtBoxPassword, "This field is required");
            }
           
            else
            {
                Admin admin = new Admin(txtBoxName.Text, txtBoxPassword.Text);
                PersonDL.personList.Add(admin);
                AdminDL.StoreInFileAdmin();
                MessageBox.Show(txtBoxName.Text + " Added Successfully");
               
            }

        }

        private void AddAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
