using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessApplication.BL;
using BuisnessApplication.DL;
using System.Windows.Forms;

namespace MedicalStoreMnagementSystem.View
{
    public partial class RemoveFromCartFrm : Form
    {
        public RemoveFromCartFrm()
        {
            InitializeComponent();
            DataBind();
        }
        private void DataBind()
        {
            CartGridView1.DataSource = null;
            Customer customer = new Customer();
            List<CartItem> cart = Customer.ReturnCart();
            foreach (CartItem c in cart)
            {
                CartGridView1.DataSource = cart.Select(m => new { m.Id, m.Name, m.Price }).ToList();
            }
            CartGridView1.Refresh();
        }
        public DataGridViewRow selectedRow;
        int row = 0;
        private void CartGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CartGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            selectedRow = CartGridView1.Rows[e.RowIndex];
            txtBoxRemoveItem.Text = selectedRow.Cells[1].Value.ToString();
        }

        private void RemoveFromCartFrm_Load(object sender, EventArgs e)
        {

        }

        private void refresh()
        {
            CartGridView1.DataSource = null;
            CartGridView1.DataSource = Customer.ReturnCart();
        }
        private void icRemove_Click(object sender, EventArgs e)
        {
            int x = Customer.ReturnCart().Count;
            row = CartGridView1.CurrentCell.RowIndex;
            Customer.RemoveFromCart(row);
            int y = Customer.ReturnCart().Count;
            refresh();
            if(y<x)
            {
                MessageBox.Show("Item Removed Successfully");
            }
            else
            {
                MessageBox.Show("Item not removed Try again");
            }
        }

        private void txtBoxRemoveItem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
