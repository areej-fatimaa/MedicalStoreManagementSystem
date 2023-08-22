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
    public partial class AddToCartFrm : Form
    {
        public AddToCartFrm()
        {
            InitializeComponent();
        }

        private void cbListMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public DataGridViewRow selectedRow;

        public object CustomerBL { get; private set; }

        private void MedicineGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MedicineGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            selectedRow = MedicineGridView.Rows[e.RowIndex];
            textBox1.Text = selectedRow.Cells[0].Value.ToString();
            textBox2.Text = selectedRow.Cells[1].Value.ToString();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DataBind()
        {


            MedicineGridView.DataSource = null;
            foreach (Product med in ProductDL.productList)
            {
                if (med is Medicine)
                {
                    Medicine medicine = (Medicine)(med as Product);
                    MedicineGridView.DataSource = ProductDL.ReturnMedicines().Select(m => new { m.ID, m.Name, m.Price, m.Stock, m.MinQuantity, medicine.DosageForm1, medicine.Strength1, medicine.Manufacture, medicine.Expiry1 }).ToList();
                }
            }
            MedicineGridView.Refresh();
        }
        private void DataBindEqupments()
        {
            EquipmentGridView.DataSource = null;
            foreach (Product equip in ProductDL.productList)
            {
                if(equip is Equipments)
                { 
                EquipmentGridView.DataSource = ProductDL.ReturnEquipments().Select(m => new { m.ID, m.Name, m.Price }).ToList();
                }
            }
            EquipmentGridView.Refresh();
        }
        private void AddToCartFrm_Load(object sender, EventArgs e)
        {
            CartGridView.Columns.Add("Id", "Id");
            CartGridView.Columns.Add("Name", "Name");
            CartGridView.Columns.Add("Price", "Price");
            CartGridView.Columns.Add("Quantity", "Quantity");

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DataBind();
            iconButton1.BackColor = Color.SlateGray;
        }

        private void MedicineGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MedicineGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            selectedRow = MedicineGridView.Rows[e.RowIndex];
            textBox1.Text = selectedRow.Cells[0].Value.ToString();
            textBox2.Text = selectedRow.Cells[1].Value.ToString();
            textBox3.Text = selectedRow.Cells[2].Value.ToString();
        }

        private void icAddToCart_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                CartItem cartitem;
               // DataGridViewRow row = MedicineGridView.SelectedRows[0];
                float price = float.Parse(selectedRow.Cells["Price"].Value.ToString());
                
                    cartitem = new CartItem(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), int.Parse(textBox4.Text));
                    Customer customer = new Customer();
                    customer.AddToCart(cartitem);
                    CartGridView.Rows.Add(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), int.Parse(textBox4.Text));
                //textBox1.Text = string.Empty;
                //textBox2.Text = string.Empty;
                //textBox3.Text = string.Empty;
                //textBox4.Text = string.Empty;
            }

        }

        private void CartGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void icCart_Click(object sender, EventArgs e)
        {
           
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            DataBindEqupments();
            iconButton2.BackColor=Color.SlateGray;
        }

        private void EquipmentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = EquipmentGridView.Rows[e.RowIndex];
            textBox1.Text = selectedRow.Cells[0].Value.ToString();
            textBox2.Text = selectedRow.Cells[1].Value.ToString();
            textBox3.Text = selectedRow.Cells[2].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
