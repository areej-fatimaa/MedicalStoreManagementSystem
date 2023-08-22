using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuisnessApplication.BL;
using BuisnessApplication.DL;


namespace MedicalStoreMnagementSystem.View
{
    public partial class CustomerBillFrm : Form
    {
        public CustomerBillFrm()
        {
            InitializeComponent();
        }

        private void icCash_Click(object sender, EventArgs e)
        {
            float bill = Customer.Bill();
            MessageBox.Show("Your bill is" + bill);
            Customer customer = new Customer();
            AdminDL.SaveTransactionsToFile(customer.ReturnCustomer(), Customer.ReturnCart(), bill);
           Customer.DestroyCart();
            dataGridView1.DataSource = null;
        }

        private void CustomerBillFrm_Load(object sender, EventArgs e)
        {

            DataBind();
        }
        private void refresh()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Customer.ReturnCart();
        }
        private void icCard_Click(object sender, EventArgs e)
        {

            float bill = Customer.Bill();
            bill =bill- (bill * 0.05F);
            MessageBox.Show("Your bill after discount is is" + bill);
            Customer customer = new Customer();
            AdminDL.SaveTransactionsToFile(customer.ReturnCustomer(), Customer.ReturnCart(), bill);
            Customer.DestroyCart();
            dataGridView1.DataSource = null;
        }
        private void DataBind()
        {
            dataGridView1.DataSource = null;
            Customer customer = new Customer();
            List<CartItem> cart = Customer.ReturnCart();
            foreach (CartItem c in cart)
            {
                dataGridView1.DataSource = cart.Select(m => new { m.Id, m.Name, m.Price }).ToList();
            }
            dataGridView1.Refresh();
        }
        public DataGridViewRow selectedRow;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
