using FontAwesome.Sharp;
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
    public partial class AdminForm : Form
    {
        private IconButton currentBtn;
        private Panel leftBoarderBtn;
        private Form currentChildForm;
        public AdminForm()
        {
            InitializeComponent();
            leftBoarderBtn = new Panel();
            leftBoarderBtn.Size = new Size(3, 56);
            AdminPanal.Controls.Add(leftBoarderBtn);
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
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
        private void ActivateBtn(object senderBtn, Color color)
        {
            DisableButton();
            if (senderBtn != null)
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
                leftBoarderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBoarderBtn.Visible = true;
                leftBoarderBtn.BringToFront();
                //iconHome.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.SkyBlue;
                currentBtn.ForeColor = Color.FromArgb(0, 0, 64);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(0, 0, 64);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText; currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            }
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, Color.White);
            OpenChildForm(new DeleteProduct());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, Color.White);
            OpenChildForm(new UpdateForm());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, Color.White);
            OpenChildForm(new AddProduct());
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconHome_Click(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void icViewProduct_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, Color.White);
            OpenChildForm(new ViewProductAdmin());
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void icAddUsers_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, Color.White);
            OpenChildForm(new AddAdmin());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, Color.White);
            OpenChildForm(new RemoveUser());

        }

        private void icDelAccount_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, Color.White);
            OpenChildForm(new DeleteAccountAdmin());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void icLogOut_Click(object sender, EventArgs e)
        {
            
        }
    }
}
