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
    public partial class DeleteAccountAdmin : Form
    {
        public DeleteAccountAdmin()
        {
            InitializeComponent();
        }

        private void icCOnfirmPassword_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < PersonDL.personList.Count; i++)
                {
                Person person = PersonDL.personList[i];
                if (person.Name==txtBoxConfirm.Text&&person.Password==txtBoxConform2.Text)
                {
                    if(person is Admin)
                    {
                        if(PersonDL.ReturnAdmin().Count>1)
                        {
                            PersonDL.RemoveCustomer(person);
                            AdminDL.StoreInFileAdmin();
                            MessageBox.Show("Account Deleted");
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Add Another admin to delete your account");
                        }
                    }
                    else if(person is Customer)
                    {
                        PersonDL.RemoveCustomer(person);
                        CustomerDL.StoreInFileCustomer();
                        MessageBox.Show("Account Deleted");
                        this.Hide();
                    }
                }
            }
        }

        private void DeleteAccountAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
