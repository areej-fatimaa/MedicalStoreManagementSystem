
namespace MedicalStoreMnagementSystem.View
{
    partial class AdminForm
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
            this.AdminPanal = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panalHome = new System.Windows.Forms.Panel();
            this.lblHome = new System.Windows.Forms.Label();
            this.Admin = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.iconHome = new FontAwesome.Sharp.IconPictureBox();
            this.icLogOut = new FontAwesome.Sharp.IconButton();
            this.icDelAccount = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.icAddUsers = new FontAwesome.Sharp.IconButton();
            this.icUpdateProduct = new FontAwesome.Sharp.IconButton();
            this.icDeleteProduct = new FontAwesome.Sharp.IconButton();
            this.icViewProduct = new FontAwesome.Sharp.IconButton();
            this.AddProducts = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AdminPanal.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panalHome.SuspendLayout();
            this.Admin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminPanal
            // 
            this.AdminPanal.Controls.Add(this.icLogOut);
            this.AdminPanal.Controls.Add(this.icDelAccount);
            this.AdminPanal.Controls.Add(this.iconButton2);
            this.AdminPanal.Controls.Add(this.icAddUsers);
            this.AdminPanal.Controls.Add(this.icUpdateProduct);
            this.AdminPanal.Controls.Add(this.icDeleteProduct);
            this.AdminPanal.Controls.Add(this.icViewProduct);
            this.AdminPanal.Controls.Add(this.AddProducts);
            this.AdminPanal.Controls.Add(this.panel2);
            this.AdminPanal.Dock = System.Windows.Forms.DockStyle.Left;
            this.AdminPanal.Location = new System.Drawing.Point(0, 0);
            this.AdminPanal.Name = "AdminPanal";
            this.AdminPanal.Size = new System.Drawing.Size(251, 516);
            this.AdminPanal.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 100);
            this.panel2.TabIndex = 0;
            // 
            // panalHome
            // 
            this.panalHome.Controls.Add(this.lblHome);
            this.panalHome.Controls.Add(this.iconHome);
            this.panalHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panalHome.Location = new System.Drawing.Point(251, 0);
            this.panalHome.Name = "panalHome";
            this.panalHome.Size = new System.Drawing.Size(549, 100);
            this.panalHome.TabIndex = 1;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.Lavender;
            this.lblHome.Location = new System.Drawing.Point(56, 70);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(56, 21);
            this.lblHome.TabIndex = 1;
            this.lblHome.Text = "Home";
            // 
            // Admin
            // 
            this.Admin.Controls.Add(this.panelDesktop);
            this.Admin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Admin.Location = new System.Drawing.Point(251, 100);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(549, 416);
            this.Admin.TabIndex = 2;
            this.Admin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(549, 416);
            this.panelDesktop.TabIndex = 0;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // iconHome
            // 
            this.iconHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconHome.ForeColor = System.Drawing.Color.Lavender;
            this.iconHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.iconHome.IconColor = System.Drawing.Color.Lavender;
            this.iconHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconHome.Location = new System.Drawing.Point(17, 52);
            this.iconHome.Name = "iconHome";
            this.iconHome.Size = new System.Drawing.Size(32, 32);
            this.iconHome.TabIndex = 0;
            this.iconHome.TabStop = false;
            this.iconHome.Click += new System.EventHandler(this.iconHome_Click);
            // 
            // icLogOut
            // 
            this.icLogOut.BackColor = System.Drawing.Color.SkyBlue;
            this.icLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.icLogOut.FlatAppearance.BorderSize = 0;
            this.icLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icLogOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icLogOut.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icLogOut.IconColor = System.Drawing.Color.Black;
            this.icLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icLogOut.Location = new System.Drawing.Point(0, 416);
            this.icLogOut.Name = "icLogOut";
            this.icLogOut.Size = new System.Drawing.Size(251, 45);
            this.icLogOut.TabIndex = 8;
            this.icLogOut.Text = "Log Out";
            this.icLogOut.UseVisualStyleBackColor = false;
            this.icLogOut.Click += new System.EventHandler(this.icLogOut_Click);
            // 
            // icDelAccount
            // 
            this.icDelAccount.BackColor = System.Drawing.Color.SkyBlue;
            this.icDelAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.icDelAccount.FlatAppearance.BorderSize = 0;
            this.icDelAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icDelAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icDelAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icDelAccount.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icDelAccount.IconColor = System.Drawing.Color.Black;
            this.icDelAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icDelAccount.Location = new System.Drawing.Point(0, 371);
            this.icDelAccount.Name = "icDelAccount";
            this.icDelAccount.Size = new System.Drawing.Size(251, 45);
            this.icDelAccount.TabIndex = 7;
            this.icDelAccount.Text = "Delete Account";
            this.icDelAccount.UseVisualStyleBackColor = false;
            this.icDelAccount.Click += new System.EventHandler(this.icDelAccount_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.SkyBlue;
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(0, 326);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(251, 45);
            this.iconButton2.TabIndex = 6;
            this.iconButton2.Text = "RemoveAdmin";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // icAddUsers
            // 
            this.icAddUsers.BackColor = System.Drawing.Color.SkyBlue;
            this.icAddUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.icAddUsers.FlatAppearance.BorderSize = 0;
            this.icAddUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icAddUsers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icAddUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icAddUsers.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icAddUsers.IconColor = System.Drawing.Color.Black;
            this.icAddUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icAddUsers.Location = new System.Drawing.Point(0, 281);
            this.icAddUsers.Name = "icAddUsers";
            this.icAddUsers.Size = new System.Drawing.Size(251, 45);
            this.icAddUsers.TabIndex = 5;
            this.icAddUsers.Text = "Add Admin";
            this.icAddUsers.UseVisualStyleBackColor = false;
            this.icAddUsers.Click += new System.EventHandler(this.icAddUsers_Click);
            // 
            // icUpdateProduct
            // 
            this.icUpdateProduct.BackColor = System.Drawing.Color.SkyBlue;
            this.icUpdateProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.icUpdateProduct.FlatAppearance.BorderSize = 0;
            this.icUpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icUpdateProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icUpdateProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icUpdateProduct.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icUpdateProduct.IconColor = System.Drawing.Color.Black;
            this.icUpdateProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icUpdateProduct.Location = new System.Drawing.Point(0, 237);
            this.icUpdateProduct.Name = "icUpdateProduct";
            this.icUpdateProduct.Size = new System.Drawing.Size(251, 44);
            this.icUpdateProduct.TabIndex = 4;
            this.icUpdateProduct.Text = "Update Product";
            this.icUpdateProduct.UseVisualStyleBackColor = false;
            this.icUpdateProduct.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // icDeleteProduct
            // 
            this.icDeleteProduct.BackColor = System.Drawing.Color.SkyBlue;
            this.icDeleteProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.icDeleteProduct.FlatAppearance.BorderSize = 0;
            this.icDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icDeleteProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icDeleteProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icDeleteProduct.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icDeleteProduct.IconColor = System.Drawing.Color.Black;
            this.icDeleteProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icDeleteProduct.Location = new System.Drawing.Point(0, 190);
            this.icDeleteProduct.Name = "icDeleteProduct";
            this.icDeleteProduct.Size = new System.Drawing.Size(251, 47);
            this.icDeleteProduct.TabIndex = 3;
            this.icDeleteProduct.Text = "Delete Product";
            this.icDeleteProduct.UseVisualStyleBackColor = false;
            this.icDeleteProduct.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // icViewProduct
            // 
            this.icViewProduct.BackColor = System.Drawing.Color.SkyBlue;
            this.icViewProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.icViewProduct.FlatAppearance.BorderSize = 0;
            this.icViewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icViewProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icViewProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icViewProduct.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icViewProduct.IconColor = System.Drawing.Color.Black;
            this.icViewProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icViewProduct.Location = new System.Drawing.Point(0, 145);
            this.icViewProduct.Name = "icViewProduct";
            this.icViewProduct.Size = new System.Drawing.Size(251, 45);
            this.icViewProduct.TabIndex = 2;
            this.icViewProduct.Text = "View Product";
            this.icViewProduct.UseVisualStyleBackColor = false;
            this.icViewProduct.Click += new System.EventHandler(this.icViewProduct_Click);
            // 
            // AddProducts
            // 
            this.AddProducts.BackColor = System.Drawing.Color.SkyBlue;
            this.AddProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddProducts.FlatAppearance.BorderSize = 0;
            this.AddProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProducts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AddProducts.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AddProducts.IconColor = System.Drawing.Color.Black;
            this.AddProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddProducts.Location = new System.Drawing.Point(0, 100);
            this.AddProducts.Name = "AddProducts";
            this.AddProducts.Size = new System.Drawing.Size(251, 45);
            this.AddProducts.TabIndex = 1;
            this.AddProducts.Text = "Add Product";
            this.AddProducts.UseVisualStyleBackColor = false;
            this.AddProducts.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MedicalStoreMnagementSystem.Properties.Resources.medical_logo_removebg_preview__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.panalHome);
            this.Controls.Add(this.AdminPanal);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.AdminPanal.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panalHome.ResumeLayout(false);
            this.panalHome.PerformLayout();
            this.Admin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AdminPanal;
        private FontAwesome.Sharp.IconButton icLogOut;
        private FontAwesome.Sharp.IconButton icDelAccount;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton icAddUsers;
        private FontAwesome.Sharp.IconButton icUpdateProduct;
        private FontAwesome.Sharp.IconButton icDeleteProduct;
        private FontAwesome.Sharp.IconButton icViewProduct;
        private FontAwesome.Sharp.IconButton AddProducts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panalHome;
        private System.Windows.Forms.Panel Admin;
        private FontAwesome.Sharp.IconPictureBox iconHome;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Panel panelDesktop;
    }
}