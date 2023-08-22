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
    public partial class ViewProductAdmin : Form
    {
        public ViewProductAdmin()
        {
            InitializeComponent();
        }
         private void DataBind()
        {
            dataGridView1.DataSource = null;
           foreach (Product med in ProductDL.productList)
            {
                if(med is Medicine)
                {
                    Medicine medicine = (Medicine)(med as Product);
                dataGridView1.DataSource = ProductDL.ReturnMedicines().Select(m => new { m.ID, m.Name, m.Price ,m.Stock,m.MinQuantity,medicine.DosageForm1,medicine.Strength1,medicine.Manufacture,medicine.Expiry1}).ToList();
                }
            }
            dataGridView1.Refresh();
        }
        private void ViewProductAdmin_Load(object sender, EventArgs e)
        {
           // DataBind();
          //  DataBindEquipment();
        }
        private void DataBindEquipment()
        {
            EquipmentGridView.DataSource = null;
            foreach (Product equip in ProductDL.productList)
            {
               if(equip is Equipments)
                {

                    Equipments equipment = (Equipments)(equip as Product);
                    EquipmentGridView.DataSource = ProductDL.ReturnEquipments().Select(m => new { m.ID, m.Name, m.Price, m.Stock, m.MinQuantity, equipment.Warrenty }).ToList();
                }
            }
            EquipmentGridView.Refresh();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void icMed_Click(object sender, EventArgs e)
        {
            DataBind();
        }

        private void icequip_Click(object sender, EventArgs e)
        {
            DataBindEquipment();
        }
    }
}
