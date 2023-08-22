
namespace MedicalStoreMnagementSystem.View
{
    partial class AddToCartFrm
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
            this.PanalAddToCart = new System.Windows.Forms.TableLayoutPanel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.MedicineGridView = new System.Windows.Forms.DataGridView();
            this.EquipmentGridView = new System.Windows.Forms.DataGridView();
            this.CartGridView = new System.Windows.Forms.DataGridView();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.icCart = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.icAddToCart = new FontAwesome.Sharp.IconButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.PanalAddToCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PanalAddToCart
            // 
            this.PanalAddToCart.ColumnCount = 5;
            this.PanalAddToCart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.5F));
            this.PanalAddToCart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.625F));
            this.PanalAddToCart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.25F));
            this.PanalAddToCart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.125F));
            this.PanalAddToCart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.5F));
            this.PanalAddToCart.Controls.Add(this.textBox4, 1, 4);
            this.PanalAddToCart.Controls.Add(this.MedicineGridView, 1, 2);
            this.PanalAddToCart.Controls.Add(this.EquipmentGridView, 2, 2);
            this.PanalAddToCart.Controls.Add(this.CartGridView, 3, 2);
            this.PanalAddToCart.Controls.Add(this.iconButton1, 1, 1);
            this.PanalAddToCart.Controls.Add(this.iconButton2, 2, 1);
            this.PanalAddToCart.Controls.Add(this.icCart, 3, 1);
            this.PanalAddToCart.Controls.Add(this.textBox1, 1, 3);
            this.PanalAddToCart.Controls.Add(this.textBox2, 2, 3);
            this.PanalAddToCart.Controls.Add(this.icAddToCart, 3, 4);
            this.PanalAddToCart.Controls.Add(this.textBox3, 3, 3);
            this.PanalAddToCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanalAddToCart.Location = new System.Drawing.Point(0, 0);
            this.PanalAddToCart.Name = "PanalAddToCart";
            this.PanalAddToCart.RowCount = 8;
            this.PanalAddToCart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18862F));
            this.PanalAddToCart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.60489F));
            this.PanalAddToCart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.4487F));
            this.PanalAddToCart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.30026F));
            this.PanalAddToCart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.066446F));
            this.PanalAddToCart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.391082F));
            this.PanalAddToCart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PanalAddToCart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PanalAddToCart.Size = new System.Drawing.Size(800, 450);
            this.PanalAddToCart.TabIndex = 2;
            this.PanalAddToCart.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(55, 380);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(231, 20);
            this.textBox4.TabIndex = 15;
            // 
            // MedicineGridView
            // 
            this.MedicineGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicineGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MedicineGridView.Location = new System.Drawing.Point(55, 149);
            this.MedicineGridView.Name = "MedicineGridView";
            this.MedicineGridView.Size = new System.Drawing.Size(231, 155);
            this.MedicineGridView.TabIndex = 5;
            this.MedicineGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MedicineGridView_CellClick);
            this.MedicineGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MedicineGridView_CellContentClick);
            // 
            // EquipmentGridView
            // 
            this.EquipmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EquipmentGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentGridView.Location = new System.Drawing.Point(292, 149);
            this.EquipmentGridView.Name = "EquipmentGridView";
            this.EquipmentGridView.Size = new System.Drawing.Size(236, 155);
            this.EquipmentGridView.TabIndex = 6;
            this.EquipmentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EquipmentGridView_CellContentClick);
            // 
            // CartGridView
            // 
            this.CartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartGridView.Location = new System.Drawing.Point(534, 149);
            this.CartGridView.Name = "CartGridView";
            this.CartGridView.Size = new System.Drawing.Size(211, 155);
            this.CartGridView.TabIndex = 7;
            this.CartGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CartGridView_CellContentClick);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(55, 77);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(231, 66);
            this.iconButton1.TabIndex = 8;
            this.iconButton1.Text = "Medicines";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(292, 77);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(236, 66);
            this.iconButton2.TabIndex = 9;
            this.iconButton2.Text = "Equipments";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // icCart
            // 
            this.icCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icCart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icCart.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icCart.IconColor = System.Drawing.Color.Black;
            this.icCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icCart.Location = new System.Drawing.Point(534, 77);
            this.icCart.Name = "icCart";
            this.icCart.Size = new System.Drawing.Size(211, 66);
            this.icCart.TabIndex = 10;
            this.icCart.Text = "Cart";
            this.icCart.UseVisualStyleBackColor = true;
            this.icCart.Click += new System.EventHandler(this.icCart_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(55, 310);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(292, 310);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(236, 20);
            this.textBox2.TabIndex = 12;
            // 
            // icAddToCart
            // 
            this.icAddToCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icAddToCart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icAddToCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icAddToCart.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icAddToCart.IconColor = System.Drawing.Color.Black;
            this.icAddToCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icAddToCart.Location = new System.Drawing.Point(534, 380);
            this.icAddToCart.Name = "icAddToCart";
            this.icAddToCart.Size = new System.Drawing.Size(211, 10);
            this.icAddToCart.TabIndex = 13;
            this.icAddToCart.Text = "Add to Cart";
            this.icAddToCart.UseVisualStyleBackColor = true;
            this.icAddToCart.Click += new System.EventHandler(this.icAddToCart_Click);
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(534, 310);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(211, 20);
            this.textBox3.TabIndex = 14;
            // 
            // AddToCartFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanalAddToCart);
            this.Name = "AddToCartFrm";
            this.Text = "AddToCartFrm";
            this.Load += new System.EventHandler(this.AddToCartFrm_Load);
            this.PanalAddToCart.ResumeLayout(false);
            this.PanalAddToCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel PanalAddToCart;
        private System.Windows.Forms.DataGridView MedicineGridView;
        private System.Windows.Forms.DataGridView EquipmentGridView;
        private System.Windows.Forms.DataGridView CartGridView;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton icCart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private FontAwesome.Sharp.IconButton icAddToCart;
    }
}