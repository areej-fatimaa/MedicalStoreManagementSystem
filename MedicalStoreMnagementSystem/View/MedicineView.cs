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
    public partial class MedicineView : Form
    {
        public MedicineView()
        {
            InitializeComponent();
        }
        private void DataBind()
        {
            dataGridView1.DataSource = null;
           foreach (Product med in ProductDL.productList)
            {
                dataGridView1.DataSource = ProductDL.ReturnMedicines().Select(m => new { m.ID, m.Name, m.Price }).ToList();
            }
            dataGridView1.Refresh();
        }
        private void MedicineView_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
