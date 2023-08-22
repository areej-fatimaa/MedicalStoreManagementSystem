
namespace MedicalStoreMnagementSystem.View
{
    partial class FrmCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customerMenuPanal = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.icBtnBill = new FontAwesome.Sharp.IconButton();
            this.icBtnRemoveFrmCart = new FontAwesome.Sharp.IconButton();
            this.icBtnMedicine = new FontAwesome.Sharp.IconButton();
            this.icBtnEquipment = new FontAwesome.Sharp.IconButton();
            this.icBtnAddToCart = new FontAwesome.Sharp.IconButton();
            this.ResetBtn = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblHome = new System.Windows.Forms.Label();
            this.iconHome = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.icDelete = new FontAwesome.Sharp.IconButton();
            this.customerMenuPanal.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResetBtn)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).BeginInit();
            this.SuspendLayout();
            // 
            // customerMenuPanal
            // 
            this.customerMenuPanal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.customerMenuPanal.Controls.Add(this.panel2);
            this.customerMenuPanal.Dock = System.Windows.Forms.DockStyle.Left;
            this.customerMenuPanal.Location = new System.Drawing.Point(0, 0);
            this.customerMenuPanal.Name = "customerMenuPanal";
            this.customerMenuPanal.Size = new System.Drawing.Size(250, 474);
            this.customerMenuPanal.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.icDelete);
            this.panel2.Controls.Add(this.icBtnBill);
            this.panel2.Controls.Add(this.icBtnRemoveFrmCart);
            this.panel2.Controls.Add(this.icBtnMedicine);
            this.panel2.Controls.Add(this.icBtnEquipment);
            this.panel2.Controls.Add(this.icBtnAddToCart);
            this.panel2.Controls.Add(this.ResetBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 474);
            this.panel2.TabIndex = 2;
            // 
            // icBtnBill
            // 
            this.icBtnBill.BackColor = System.Drawing.Color.SkyBlue;
            this.icBtnBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.icBtnBill.FlatAppearance.BorderSize = 0;
            this.icBtnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icBtnBill.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icBtnBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icBtnBill.IconChar = FontAwesome.Sharp.IconChar.Shop;
            this.icBtnBill.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icBtnBill.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icBtnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icBtnBill.Location = new System.Drawing.Point(0, 348);
            this.icBtnBill.Name = "icBtnBill";
            this.icBtnBill.Size = new System.Drawing.Size(250, 66);
            this.icBtnBill.TabIndex = 4;
            this.icBtnBill.Text = "Bill";
            this.icBtnBill.UseVisualStyleBackColor = false;
            this.icBtnBill.Click += new System.EventHandler(this.icBtnBill_Click);
            // 
            // icBtnRemoveFrmCart
            // 
            this.icBtnRemoveFrmCart.BackColor = System.Drawing.Color.SkyBlue;
            this.icBtnRemoveFrmCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.icBtnRemoveFrmCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.icBtnRemoveFrmCart.FlatAppearance.BorderSize = 0;
            this.icBtnRemoveFrmCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icBtnRemoveFrmCart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icBtnRemoveFrmCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icBtnRemoveFrmCart.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.icBtnRemoveFrmCart.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icBtnRemoveFrmCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icBtnRemoveFrmCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icBtnRemoveFrmCart.Location = new System.Drawing.Point(0, 284);
            this.icBtnRemoveFrmCart.Name = "icBtnRemoveFrmCart";
            this.icBtnRemoveFrmCart.Size = new System.Drawing.Size(250, 64);
            this.icBtnRemoveFrmCart.TabIndex = 3;
            this.icBtnRemoveFrmCart.Text = "Remove From Cart";
            this.icBtnRemoveFrmCart.UseVisualStyleBackColor = false;
            this.icBtnRemoveFrmCart.Click += new System.EventHandler(this.icBtnRemoveFrmCart_Click);
            // 
            // icBtnMedicine
            // 
            this.icBtnMedicine.BackColor = System.Drawing.Color.SkyBlue;
            this.icBtnMedicine.Dock = System.Windows.Forms.DockStyle.Top;
            this.icBtnMedicine.FlatAppearance.BorderSize = 0;
            this.icBtnMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icBtnMedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icBtnMedicine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icBtnMedicine.IconChar = FontAwesome.Sharp.IconChar.Capsules;
            this.icBtnMedicine.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icBtnMedicine.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icBtnMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icBtnMedicine.Location = new System.Drawing.Point(0, 226);
            this.icBtnMedicine.Name = "icBtnMedicine";
            this.icBtnMedicine.Size = new System.Drawing.Size(250, 58);
            this.icBtnMedicine.TabIndex = 0;
            this.icBtnMedicine.Text = "Medicines";
            this.icBtnMedicine.UseVisualStyleBackColor = false;
            this.icBtnMedicine.Click += new System.EventHandler(this.icBtnMedicine_Click);
            // 
            // icBtnEquipment
            // 
            this.icBtnEquipment.BackColor = System.Drawing.Color.SkyBlue;
            this.icBtnEquipment.Dock = System.Windows.Forms.DockStyle.Top;
            this.icBtnEquipment.FlatAppearance.BorderSize = 0;
            this.icBtnEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icBtnEquipment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icBtnEquipment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icBtnEquipment.IconChar = FontAwesome.Sharp.IconChar.EyeDropper;
            this.icBtnEquipment.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icBtnEquipment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icBtnEquipment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icBtnEquipment.Location = new System.Drawing.Point(0, 168);
            this.icBtnEquipment.Name = "icBtnEquipment";
            this.icBtnEquipment.Size = new System.Drawing.Size(250, 58);
            this.icBtnEquipment.TabIndex = 1;
            this.icBtnEquipment.Text = "Equipment";
            this.icBtnEquipment.UseVisualStyleBackColor = false;
            this.icBtnEquipment.Click += new System.EventHandler(this.icBtnEquipment_Click);
            // 
            // icBtnAddToCart
            // 
            this.icBtnAddToCart.BackColor = System.Drawing.Color.SkyBlue;
            this.icBtnAddToCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.icBtnAddToCart.FlatAppearance.BorderSize = 0;
            this.icBtnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icBtnAddToCart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icBtnAddToCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icBtnAddToCart.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.icBtnAddToCart.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icBtnAddToCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icBtnAddToCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icBtnAddToCart.Location = new System.Drawing.Point(0, 100);
            this.icBtnAddToCart.Name = "icBtnAddToCart";
            this.icBtnAddToCart.Size = new System.Drawing.Size(250, 68);
            this.icBtnAddToCart.TabIndex = 2;
            this.icBtnAddToCart.Text = "Add to Cart";
            this.icBtnAddToCart.UseVisualStyleBackColor = false;
            this.icBtnAddToCart.Click += new System.EventHandler(this.icBtnAddToCart_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ResetBtn.BackgroundImage = global::MedicalStoreMnagementSystem.Properties.Resources.medical_logo_removebg_preview__2_;
            this.ResetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ResetBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ResetBtn.Location = new System.Drawing.Point(0, 0);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(250, 100);
            this.ResetBtn.TabIndex = 0;
            this.ResetBtn.TabStop = false;
            this.ResetBtn.Click += new System.EventHandler(this.home_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelTitleBar.Controls.Add(this.lblHome);
            this.panelTitleBar.Controls.Add(this.iconHome);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(250, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(550, 100);
            this.panelTitleBar.TabIndex = 1;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.Lavender;
            this.lblHome.Location = new System.Drawing.Point(61, 63);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(47, 17);
            this.lblHome.TabIndex = 2;
            this.lblHome.Text = "Home";
            // 
            // iconHome
            // 
            this.iconHome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.iconHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconHome.ForeColor = System.Drawing.Color.Lavender;
            this.iconHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.iconHome.IconColor = System.Drawing.Color.Lavender;
            this.iconHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconHome.IconSize = 43;
            this.iconHome.Location = new System.Drawing.Point(6, 54);
            this.iconHome.Name = "iconHome";
            this.iconHome.Size = new System.Drawing.Size(49, 43);
            this.iconHome.TabIndex = 1;
            this.iconHome.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(250, 100);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(550, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelDesktop.Location = new System.Drawing.Point(250, 109);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(550, 365);
            this.panelDesktop.TabIndex = 3;
            // 
            // icDelete
            // 
            this.icDelete.BackColor = System.Drawing.Color.SkyBlue;
            this.icDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.icDelete.FlatAppearance.BorderSize = 0;
            this.icDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.icDelete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icDelete.Location = new System.Drawing.Point(0, 414);
            this.icDelete.Name = "icDelete";
            this.icDelete.Size = new System.Drawing.Size(250, 48);
            this.icDelete.TabIndex = 5;
            this.icDelete.Text = "Delete Account";
            this.icDelete.UseVisualStyleBackColor = false;
            this.icDelete.Click += new System.EventHandler(this.icDelete_Click);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.customerMenuPanal);
            this.Name = "FrmCustomer";
            this.Text = "FrmCustomer";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.customerMenuPanal.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResetBtn)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel customerMenuPanal;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton icBtnBill;
        private FontAwesome.Sharp.IconButton icBtnRemoveFrmCart;
        private FontAwesome.Sharp.IconButton icBtnAddToCart;
        private FontAwesome.Sharp.IconButton icBtnEquipment;
        private System.Windows.Forms.PictureBox ResetBtn;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconHome;
        private System.Windows.Forms.Label lblHome;
        private FontAwesome.Sharp.IconButton icBtnMedicine;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton icDelete;
    }
}