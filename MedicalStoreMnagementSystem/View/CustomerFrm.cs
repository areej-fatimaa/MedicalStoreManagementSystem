using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using FontAwesome;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace MedicalStoreMnagementSystem.View
{
    public partial class FrmCustomer : Form
    {
        private IconButton currentBtn;
        private Panel leftBoarderBtn;
        private Form currentChildForm;
        public FrmCustomer()
        {
            InitializeComponent();
            leftBoarderBtn=new Panel();
            leftBoarderBtn.Size = new Size(3, 56);
            customerMenuPanal.Controls.Add(leftBoarderBtn);
        }
        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm!=null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblHome.Text = childForm.Text;
        }
        private void ActivateBtn(object senderBtn,Color color)
        {
            DisableButton();
            if(senderBtn!=null)
            {
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.Navy;
                currentBtn.ForeColor = Color.Lavender;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Lavender;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter;
                //leftBoarderBtn = new Panel();
                //leftBoarderBtn.Size = new Size(3, 45);
                leftBoarderBtn.BackColor = color;
                leftBoarderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftBoarderBtn.Visible = true;
                leftBoarderBtn.BringToFront();
                //iconHome.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if(currentBtn!=null)
            {
                currentBtn.BackColor = Color.SkyBlue;
                currentBtn.ForeColor = Color.FromArgb(0,0,64);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(0, 0, 64);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText; currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            }
        }
        
        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void icBtnMedicine_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, Color.White);
            OpenChildForm(new MedicineView());
        }

        private void icBtnEquipment_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, Color.White);
            OpenChildForm(new ViewEquipmentFrm());
        }

        private void icBtnAddToCart_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, Color.White);
            OpenChildForm(new AddToCartFrm());
        }

        private void icBtnRemoveFrmCart_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, Color.White);
            OpenChildForm(new RemoveFromCartFrm());
        }

        private void icBtnBill_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, Color.White);
            OpenChildForm(new CustomerBillFrm());
        }

        private void home_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
             this.Hide();
            loginForm.Show();
            //DisableButton();
            //leftBoarderBtn.Visible = false;
            //iconHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            //iconHome.IconColor = Color.Lavender;
            //lblHome.Text = "Home";
        }

        private void icDelete_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, Color.White);
            OpenChildForm(new DeleteAccountAdmin());
        }
    }
}
