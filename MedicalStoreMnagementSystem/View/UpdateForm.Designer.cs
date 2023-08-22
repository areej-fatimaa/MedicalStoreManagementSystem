
namespace MedicalStoreMnagementSystem.View
{
    partial class UpdateForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EquipmentGridViewGridView1 = new System.Windows.Forms.DataGridView();
            this.MedicineGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.icMed = new FontAwesome.Sharp.IconButton();
            this.icEquipment = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentGridViewGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.12661F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.4332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.12957F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.098332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.14448F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.067803F));
            this.tableLayoutPanel1.Controls.Add(this.EquipmentGridViewGridView1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.MedicineGridView1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.icMed, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.icEquipment, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.iconButton1, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.792013F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.62751F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.62751F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.98432F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.984323F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.984323F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // EquipmentGridViewGridView1
            // 
            this.EquipmentGridViewGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EquipmentGridViewGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentGridViewGridView1.Location = new System.Drawing.Point(472, 51);
            this.EquipmentGridViewGridView1.Name = "EquipmentGridViewGridView1";
            this.EquipmentGridViewGridView1.Size = new System.Drawing.Size(298, 227);
            this.EquipmentGridViewGridView1.TabIndex = 0;
            this.EquipmentGridViewGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EquipmentGridViewGridView1_CellContentClick);
            // 
            // MedicineGridView1
            // 
            this.MedicineGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicineGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MedicineGridView1.Location = new System.Drawing.Point(34, 51);
            this.MedicineGridView1.Name = "MedicineGridView1";
            this.MedicineGridView1.Size = new System.Drawing.Size(322, 227);
            this.MedicineGridView1.TabIndex = 1;
            this.MedicineGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EquipmentGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(34, 284);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 27);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(472, 284);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(298, 27);
            this.textBox2.TabIndex = 3;
            // 
            // icMed
            // 
            this.icMed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icMed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icMed.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icMed.IconColor = System.Drawing.Color.Black;
            this.icMed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icMed.Location = new System.Drawing.Point(34, 3);
            this.icMed.Name = "icMed";
            this.icMed.Size = new System.Drawing.Size(322, 42);
            this.icMed.TabIndex = 5;
            this.icMed.Text = "Medicine";
            this.icMed.UseVisualStyleBackColor = true;
            this.icMed.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // icEquipment
            // 
            this.icEquipment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icEquipment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icEquipment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icEquipment.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icEquipment.IconColor = System.Drawing.Color.Black;
            this.icEquipment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icEquipment.Location = new System.Drawing.Point(472, 3);
            this.icEquipment.Name = "icEquipment";
            this.icEquipment.Size = new System.Drawing.Size(298, 42);
            this.icEquipment.TabIndex = 6;
            this.icEquipment.Text = "Equipment";
            this.icEquipment.UseVisualStyleBackColor = true;
            this.icEquipment.Click += new System.EventHandler(this.icEquipment_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(362, 352);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(104, 34);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "Update";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(34, 314);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(322, 27);
            this.textBox3.TabIndex = 7;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentGridViewGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView EquipmentGridViewGridView1;
        private System.Windows.Forms.DataGridView MedicineGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton icMed;
        private FontAwesome.Sharp.IconButton icEquipment;
        private System.Windows.Forms.TextBox textBox3;
    }
}