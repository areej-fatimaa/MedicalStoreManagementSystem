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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
                string medId = textBox1.Text;
                //    row = MedicineGridView1.CurrentCell.RowIndex;
                //    row1 = MedicineGridView1.CurrentCell.RowIndex;  
                foreach (Product product in ProductDL.productList)
                {
                    if (medId == product.ID)
                    {
                        product.Price = int.Parse(textBox2.Text);
                        product.Stock = int.Parse(textBox3.Text);
                    MessageBox.Show("Item updated successfully!");
                    }
                }
            refresh();
            refreshEquipment();
            MedicineDL.StoreInFileMedicine();
            EquipmentDL.StoreInFileEquipments();
            
        }
        private void DataBind()
        {
           MedicineGridView1 .DataSource = null;
            foreach (Product med in ProductDL.productList)
            {
                if (med is Medicine)
                {
                    Medicine medicine = (Medicine)(med as Product);
                    MedicineGridView1.DataSource = ProductDL.ReturnMedicines().Select(m => new { m.ID, m.Name, m.Price, m.Stock, m.MinQuantity, medicine.DosageForm1, medicine.Strength1, medicine.Manufacture, medicine.Expiry1 }).ToList();
                }
            }
            MedicineGridView1.Refresh();
        }
        private void DataBindEquipment()
        {
            EquipmentGridViewGridView1.DataSource = null;
            foreach (Product equip in ProductDL.productList)
            {
                if (equip is Equipments)
                {

                    Equipments equipment = (Equipments)(equip as Product);
                    EquipmentGridViewGridView1.DataSource = ProductDL.ReturnEquipments().Select(m => new { m.ID, m.Name, m.Price, m.Stock, m.MinQuantity, equipment.Warrenty }).ToList();
                }
            }
            EquipmentGridViewGridView1.Refresh();
        }
        private void refresh()
        {
            MedicineGridView1.DataSource = null;
            MedicineGridView1.DataSource = ProductDL.productList;

            MedicineGridView1.DataSource = null;
            MedicineGridView1.DataSource = ProductDL.productList;
        }
        public DataGridViewRow selectedRow;
        int row = 0;
        int row1 = 0;
        string type = null;
        private void refreshEquipment()
        {
            EquipmentGridViewGridView1.DataSource = null;
            EquipmentGridViewGridView1.DataSource = ProductDL.productList;

            EquipmentGridViewGridView1.DataSource = null;
            EquipmentGridViewGridView1.DataSource = ProductDL.productList;
        }

        private void EquipmentGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MedicineGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            selectedRow = MedicineGridView1.Rows[e.RowIndex];
            textBox1.Text = selectedRow.Cells[0].Value.ToString();
            textBox2.Text = selectedRow.Cells[2].Value.ToString();
            textBox3.Text = selectedRow.Cells[3].Value.ToString();
        }

        private void EquipmentGridViewGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = EquipmentGridViewGridView1.Rows[e.RowIndex];
            textBox1.Text = selectedRow.Cells[0].Value.ToString();
            textBox2.Text = selectedRow.Cells[2].Value.ToString();
            textBox3.Text = selectedRow.Cells[3].Value.ToString();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            DataBind();
            type = "medicine";
        }

        private void icEquipment_Click(object sender, EventArgs e)
        {
            DataBindEquipment();
            type = "equipment";
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
