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
    public partial class RemoveUser : Form
    {
        public RemoveUser()
        {
            InitializeComponent();
        }
        public DataGridViewRow selectedRow;
        int row = 0;
        private void DataBind()
        {
            UsersGridView1.DataSource = null;
            foreach (Person person in PersonDL.personList)
            {
                    UsersGridView1.DataSource = PersonDL.ReturnAdmin().Select(m => new {m.Name,m.Password}).ToList();
            }
            UsersGridView1.Refresh();
        }
        private void UsersGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UsersGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            selectedRow = UsersGridView1.Rows[e.RowIndex];
            txtBoxRemoveUsers.Text = selectedRow.Cells[0].Value.ToString();
        }
        private void refresh()
        {
            UsersGridView1.DataSource = null;
            UsersGridView1.DataSource = PersonDL.ReturnAdmin();

            UsersGridView1.DataSource = null;
            UsersGridView1.DataSource = PersonDL.ReturnAdmin();
        }
        private void txtBoxRemoveUsers_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void RemoveUser_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void icRemove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < PersonDL.personList.Count; i++)
            {
                Person person = PersonDL.personList[i];
                if (person.Name==txtBoxRemoveUsers.Text)
                {
                    PersonDL.RemoveCustomer(person);
                }
            }
            
            int y = PersonDL.ReturnAdmin().Count;
            if (y > 0)
            {
                MessageBox.Show( " Deleted Successfully");
                AdminDL.StoreInFileAdmin();
                refresh();
            }
            else
            {
                MessageBox.Show("Admin not removed");
            }
        }
    }
}
