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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }
        string Type = null;
        private void icMed_Click(object sender, EventArgs e)
        {

            textBoxDosage.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            textBoxStrength.Visible = true;
            lblDosage.Visible = true;
            lblExpiry.Visible = true;
            lblManfufacture.Visible = true;
            lblStrength.Visible = true;
            txtBoxWarrenty.Visible = false;
            lblWarrenty.Visible = false;
            Type = "medicine";
        }

        private void icEquip_Click(object sender, EventArgs e)
        {

            textBoxDosage.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            textBoxStrength.Visible = false;
            lblDosage.Visible = false;
            lblExpiry.Visible = false;
            lblManfufacture.Visible = false;
            lblStrength.Visible = false;
            txtBoxWarrenty.Visible = true;
            lblWarrenty.Visible = true;
            Type = "Equipment";
        }

        private void txtBoxid_TextChanged(object sender, EventArgs e)
        {
            string id = txtBoxid.Text;
            if ((ProductValidation.CheckProduct(id)))
            {
                txtBoxid.Focus();
                errorProviderID.SetError(this.txtBoxid, "Product Already exists.");
            }
            else if (id == null)
            {
                txtBoxid.Focus();
                errorProviderID.SetError(this.txtBoxid, "This field is required.");
            }
            else
            {
                errorProviderID.Clear();
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            if (name == null)
            {
                textBoxName.Focus();
                errorProviderID.SetError(textBoxName, "This field is required.");
            }
            else
            {
                errorProviderName.Clear();
            }
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            string price = textBoxPrice.Text;
            try
            {
                int Price = int.Parse(price);
            }
            catch
            {
                textBoxPrice.Focus();
                errorProviderPrice.SetError(textBoxPrice, "Must be an integer");
            }
            if (price == null)
            {
                textBoxPrice.Focus();
                errorProviderPrice.SetError(textBoxPrice, "This field is required.");
            }
            else
            {
                errorProviderPrice.Clear();
            }
        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            int Quantity = 0;
            string quantity = textBoxQuantity.Text;
            try
            {
                Quantity = int.Parse(quantity);
            }
            catch
            {
                textBoxQuantity.Focus();
                errorProviderQuantity.SetError(textBoxQuantity, "Must be an integer");
            }
            if (!ProductValidation.IsValidQuantity(Quantity))
            {
                textBoxQuantity.Focus();
                errorProviderQuantity.SetError(textBoxQuantity, "Quantity must be between 1 and 100");
            }
            if (quantity == null)
            {
                textBoxQuantity.Focus();
                errorProviderQuantity.SetError(textBoxQuantity, "This field is required.");
            }
            else
            {
                errorProviderQuantity.Clear();
            }
        }

        private void textBoxMinQuantity_TextChanged(object sender, EventArgs e)
        {
            int Quantity = 0;
            string quantity = textBoxMinQuantity.Text;
            try
            {
                Quantity = int.Parse(quantity);
            }
            catch
            {
                textBoxMinQuantity.Focus();
                errorProviderMinQuantity.SetError(textBoxMinQuantity, "Must be an integer");
            }
            if (!ProductValidation.IsValidMinQuantity(Quantity))
            {
                textBoxMinQuantity.Focus();
                errorProviderMinQuantity.SetError(textBoxMinQuantity, "Quantity must be between 1 and 10");
            }
            if (quantity == null)
            {
                textBoxMinQuantity.Focus();
                errorProviderMinQuantity.SetError(textBoxMinQuantity, "This field is required.");
            }
            else
            {
                errorProviderMinQuantity.Clear();
            }
        }

        private void txtBoxWarrenty_TextChanged(object sender, EventArgs e)
        {
            string warrenty = txtBoxWarrenty.Text;
            if (warrenty == null)
            {
                txtBoxWarrenty.Focus();
                errorProviderWarrenty.SetError(txtBoxWarrenty, "This field is required.");
            }
            else
            {
                errorProviderWarrenty.Clear();
            }
        }

        private void textBoxDosage_TextChanged(object sender, EventArgs e)
        {
            string dosage = textBoxDosage.Text.ToLower();
            if (!ProductValidation.CheckDosageForm(dosage))
            {
                textBoxDosage.Focus();
                errorProviderDosage.SetError(textBoxDosage, "tablet or syrup.");
            }
            if (dosage == null)
            {
                textBoxDosage.Focus();
                errorProviderDosage.SetError(textBoxDosage, "This field is required.");
            }
            else
            {
                errorProviderDosage.Clear();
            }
        }

        private void textBoxStrength_TextChanged(object sender, EventArgs e)
        {
            string strength = textBoxStrength.Text;
            if (strength == null)
            {
                textBoxStrength.Focus();
                errorProviderStrength.SetError(textBoxStrength, "This field is required.");
            }
            else
            {
                errorProviderStrength.Clear();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            DateTime dateTime = dateTimePicker1.Value;
            if (dateTime == null)
            {
                errorProviderManufacture.SetError(dateTimePicker1, "This field is required.");
            }
            else
            {
                errorProviderManufacture.Clear();
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

            DateTime dateTime = dateTimePicker2.Value;
            if (dateTime == null)
            {
                errorProviderExpiry.SetError(dateTimePicker2, "This field is required.");
            }
            else
            {
                errorProviderExpiry.Clear();
            }
        }

        private void icAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxid.Text) == true)
            {
                txtBoxid.Focus();
                errorProviderID.SetError(this.txtBoxid, "This field is required.");
            }
            if (string.IsNullOrEmpty(textBoxName.Text) == true)
            {
                errorProviderID.SetError(textBoxName, "This field is required.");
            }
            if (string.IsNullOrEmpty(textBoxPrice.Text) == true)
            {
                errorProviderID.SetError(textBoxPrice, "This field is required.");
            }
            if (string.IsNullOrEmpty(textBoxQuantity.Text) == true)
            {
                errorProviderID.SetError(textBoxQuantity, "This field is required.");
            }
            if (string.IsNullOrEmpty(textBoxMinQuantity.Text) == true)
            {
                errorProviderID.SetError(textBoxMinQuantity, "This field is required.");
            }
            if (Type == "medicine")
            {
                if (string.IsNullOrEmpty(textBoxDosage.Text) == true)
                {
                    errorProviderID.SetError(textBoxDosage, "This field is required.");
                }
                if (string.IsNullOrEmpty(textBoxStrength.Text) == true)
                {
                    errorProviderID.SetError(textBoxStrength, "This field is required.");
                }
                if (string.IsNullOrEmpty(dateTimePicker1.Text) == true)
                {
                    errorProviderID.SetError(dateTimePicker1, "This field is required.");
                }
                if (string.IsNullOrEmpty(dateTimePicker2.Text) == true)
                {
                    errorProviderID.SetError(dateTimePicker2, "This field is required.");
                }
                else
                {
                    Medicine medicine = new Medicine(textBoxName.Text, txtBoxid.Text, textBoxStrength.Text, textBoxDosage.Text, int.Parse(textBoxPrice.Text), int.Parse(textBoxQuantity.Text)
                        , int.Parse(textBoxMinQuantity.Text), DateTime.Parse(dateTimePicker1.Text), DateTime.Parse(dateTimePicker2.Text));
                    ProductDL.AddProduct(medicine);
                    MedicineDL.StoreInFileMedicine();
                    txtBoxid.Text = string.Empty;
                    txtBoxWarrenty = null;
                    textBoxDosage = null;
                    textBoxMinQuantity = null;
                    textBoxName = null;
                    textBoxPrice = null;
                    textBoxQuantity = null;
                    textBoxStrength = null;
                    dateTimePicker1 = null;
                    dateTimePicker2 = null;
                    MessageBox.Show("Product added successfully.");
                }
            }
            else if (Type == "Equipment")
            {
                if (string.IsNullOrEmpty(txtBoxWarrenty.Text) == true)
                {
                    errorProviderWarrenty.SetError(txtBoxWarrenty, "This field is required");
                }
                else
                {
                    Equipments equipment = new Equipments(txtBoxid.Text, textBoxName.Text, int.Parse(textBoxPrice.Text), int.Parse(textBoxQuantity.Text), int.Parse(textBoxMinQuantity.Text), int.Parse(txtBoxWarrenty.Text));
                    ProductDL.AddProduct(equipment);
                    EquipmentDL.StoreInFileEquipments();
                    txtBoxid = null;
                    txtBoxWarrenty = null;
                    textBoxDosage = null;
                    textBoxMinQuantity = null;
                    textBoxName = null;
                    textBoxPrice = null;
                    textBoxQuantity = null;
                    textBoxStrength = null;
                    dateTimePicker1 = null;
                    dateTimePicker2 = null;
                    MessageBox.Show("Product added successfully.");
                }
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
