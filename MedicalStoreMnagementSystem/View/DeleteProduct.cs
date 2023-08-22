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
    public partial class DeleteProduct : Form
    {
        public DeleteProduct()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeletedataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MedicinedataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            selectedRow = MedicinedataGridView.Rows[e.RowIndex];
            textBoxDelete.Text = selectedRow.Cells[1].Value.ToString();
        }
        private void DataBind()
        {
            MedicinedataGridView.DataSource = null;
            foreach (Product med in ProductDL.productList)
            {
                if (med is Medicine)
                {
                    Medicine medicine = (Medicine)(med as Product);
                    MedicinedataGridView.DataSource = ProductDL.ReturnMedicines().Select(m => new { m.ID, m.Name, m.Price, m.Stock, m.MinQuantity, medicine.DosageForm1, medicine.Strength1, medicine.Manufacture, medicine.Expiry1 }).ToList();
                }
            }
            EquipmentdataGridView.Refresh();
        }
        private void DataBindEquipment()
        {
            EquipmentdataGridView.DataSource = null;
            foreach (Product equip in ProductDL.productList)
            {
                if (equip is Equipments)
                {

                    Equipments equipment = (Equipments)(equip as Product);
                    EquipmentdataGridView.DataSource = ProductDL.ReturnMedicines().Select(m => new { m.ID, m.Name, m.Price, m.Stock, m.MinQuantity, equipment.Warrenty }).ToList();
                }
            }
            EquipmentdataGridView.Refresh();
        }
        public DataGridViewRow selectedRow;
        int row = 0;
        string type = null;
        private void icMedicine_Click(object sender, EventArgs e)
        {
            DataBind();
            type = "medicine";
        }

        private void icEquipment_Click(object sender, EventArgs e)
        {
            DataBindEquipment();
            type = "equipment";
        }
        private void refresh()
        {
            MedicinedataGridView.DataSource = null;
            MedicinedataGridView.DataSource = ProductDL.productList;

            MedicinedataGridView.DataSource = null;
            MedicinedataGridView.DataSource = ProductDL.productList;
        }
        private void refreshEquipment()
        {
            EquipmentdataGridView.DataSource = null;
            EquipmentdataGridView.DataSource = ProductDL.productList;

            EquipmentdataGridView.DataSource = null;
            EquipmentdataGridView.DataSource = ProductDL.productList;
        }
        private void icDelete_Click(object sender, EventArgs e)
        {
            int x = ProductDL.productList.Count;
            if (type == "medicine")
            {
                row = MedicinedataGridView.CurrentCell.RowIndex;
            }
            else if(type=="equipment")
            {
                row = EquipmentdataGridView.CurrentCell.RowIndex;
            }
            ProductDL.DeleteProduct(row);
            int y = ProductDL.productList.Count;
            refresh();
            refreshEquipment();
            if (y < x)
            {
                MessageBox.Show("Item Deleted Successfully");
                EquipmentDL.StoreInFileEquipments();
                MedicineDL.StoreInFileMedicine();
            }
            else
            {
                MessageBox.Show("Item not Deleted Try again");
            }
        }

        private void EquipmentdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EquipmentdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            selectedRow = EquipmentdataGridView.Rows[e.RowIndex];
            textBoxDelete.Text = selectedRow.Cells[1].Value.ToString();
        }

        private void DeleteProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
