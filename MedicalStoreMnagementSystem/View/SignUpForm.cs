using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BuisnessApplication.BL;
using BuisnessApplication.DL;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace MedicalStoreMnagementSystem.View
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {
            string name = txtBoxName.Text;
            if (Validations.CheckName(name))
            {
                txtBoxName.Focus();
               epname.SetError(this.txtBoxName, "User name Already Exists");
            }
            else if (string.IsNullOrEmpty(name) == true)
            {
                txtBoxName.Focus();
                epname.SetError(this.txtBoxName, "This field is required");
            }
            else
            {
                epname.Clear();
            }
        }

        private void txtBoxAddress_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxAddress .Text) == true)
            {
                txtBoxAddress.Focus();
                epAddress.SetError(this.txtBoxAddress, "This field is required");
            }
            else
            {
                epAddress.Clear();
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
                epname.SetError(this.txtBoxName, "This field is required");
            }
            else if (string.IsNullOrEmpty(txtBoxPassword.Text) == true)
            {
                txtBoxPassword.Focus();
                epPassword.SetError(this.txtBoxPassword, "This field is required");
            }
            else if (string.IsNullOrEmpty(txtBoxAddress.Text) == true)
            {
                txtBoxAddress.Focus();
                epAddress.SetError(this.txtBoxAddress, "This field is required");
            }
            else
            {
                Customer customer = new Customer(txtBoxName.Text, txtBoxPassword.Text, txtBoxAddress.Text);
                PersonDL.personList.Add(customer);
                CustomerDL.StoreInFileCustomer(); 
                MessageBox.Show(txtBoxName.Text + " Signed Up Successfully");
                //else if(rdAdmin.AutoCheck)
                //{
                //    Admin admin = new Admin(txtBoxName.Text, txtBoxPassword.Text);
                //    AdminDL.StoreInFileAdmin(admin);
                //    MessageBox.Show(txtBoxName.Text + " Signed Up Successfully");
                //}
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.Show();
            }
        }

        private void rdAdmin_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxAddress.Visible = false;
            lblAddress.Visible = false;
        }

        private void rdCustomer_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxAddress.Visible = true;
            lblAddress.Visible = true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }
    }
}
