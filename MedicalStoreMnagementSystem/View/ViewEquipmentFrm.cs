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
    public partial class ViewEquipmentFrm : Form
    {
        public ViewEquipmentFrm()
        {
            InitializeComponent();
        }
        private void DataBind()
        {
            EquipmentGridView.DataSource = null;
              foreach (Product equip in ProductDL.productList)
            {
                EquipmentGridView.DataSource = ProductDL.ReturnEquipments().Select(m => new { m.ID, m.Name, m.Price }).ToList();
            }
            EquipmentGridView.Refresh();
        }
        private void EquipmentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void ViewEquipmentFrm_Load(object sender, EventArgs e)
        {
            DataBind();
        }
    }
}
