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
using System.Xml.Linq;


namespace MedicalStoreMnagementSystem.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtBoxName.Text;
            string password = txtBoxPassword.Text;
            Person person = Validations.CheckPersonInList(name, password);
            if (person == null)
            {
                lblValidateUser.Visible = true;
            }
            else
            { 
                    if(person is Admin)
                    {
                        AdminForm adminForm = new AdminForm();
                        this .Hide();
                        MessageBox.Show("Welcome " + name);
                        adminForm.Show();
                        
                    }
                   else  if (person is Customer)
                    {
                        FrmCustomer frmCustomer = new FrmCustomer();
                        this.Hide();
                        MessageBox.Show("Welcome " + name);
                        frmCustomer.Show();

                    }
            }
        }

        private void linkLblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUp = new SignUpForm();
            this.Hide();
            signUp.Show();
        }

        private void lblValidateUser_Click(object sender, EventArgs e)
        {

        }
    }
}
