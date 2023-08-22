
namespace MedicalStoreMnagementSystem.View
{
    partial class DeleteProduct
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
            this.MedicinedataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxDelete = new System.Windows.Forms.TextBox();
            this.EquipmentdataGridView = new System.Windows.Forms.DataGridView();
            this.icMedicine = new FontAwesome.Sharp.IconButton();
            this.icEquipment = new FontAwesome.Sharp.IconButton();
            this.icDelete = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicinedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel1.Controls.Add(this.MedicinedataGridView, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.icMedicine, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.EquipmentdataGridView, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.icEquipment, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.icDelete, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxDelete, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // MedicinedataGridView
            // 
            this.MedicinedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicinedataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MedicinedataGridView.Location = new System.Drawing.Point(64, 54);
            this.MedicinedataGridView.Name = "MedicinedataGridView";
            this.MedicinedataGridView.Size = new System.Drawing.Size(288, 236);
            this.MedicinedataGridView.TabIndex = 0;
            this.MedicinedataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeletedataGridView_CellContentClick);
            // 
            // textBoxDelete
            // 
            this.textBoxDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBoxDelete.Location = new System.Drawing.Point(358, 296);
            this.textBoxDelete.Name = "textBoxDelete";
            this.textBoxDelete.Size = new System.Drawing.Size(315, 27);
            this.textBoxDelete.TabIndex = 1;
            this.textBoxDelete.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EquipmentdataGridView
            // 
            this.EquipmentdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EquipmentdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentdataGridView.Location = new System.Drawing.Point(358, 54);
            this.EquipmentdataGridView.Name = "EquipmentdataGridView";
            this.EquipmentdataGridView.Size = new System.Drawing.Size(315, 236);
            this.EquipmentdataGridView.TabIndex = 3;
            this.EquipmentdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EquipmentdataGridView_CellContentClick);
            // 
            // icMedicine
            // 
            this.icMedicine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icMedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icMedicine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icMedicine.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icMedicine.IconColor = System.Drawing.Color.Black;
            this.icMedicine.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icMedicine.Location = new System.Drawing.Point(64, 3);
            this.icMedicine.Name = "icMedicine";
            this.icMedicine.Size = new System.Drawing.Size(288, 45);
            this.icMedicine.TabIndex = 4;
            this.icMedicine.Text = "Medicine";
            this.icMedicine.UseVisualStyleBackColor = true;
            this.icMedicine.Click += new System.EventHandler(this.icMedicine_Click);
            // 
            // icEquipment
            // 
            this.icEquipment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icEquipment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icEquipment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icEquipment.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icEquipment.IconColor = System.Drawing.Color.Black;
            this.icEquipment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icEquipment.Location = new System.Drawing.Point(358, 3);
            this.icEquipment.Name = "icEquipment";
            this.icEquipment.Size = new System.Drawing.Size(315, 45);
            this.icEquipment.TabIndex = 5;
            this.icEquipment.Text = "Equipment";
            this.icEquipment.UseVisualStyleBackColor = true;
            this.icEquipment.Click += new System.EventHandler(this.icEquipment_Click);
            // 
            // icDelete
            // 
            this.icDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icDelete.IconColor = System.Drawing.Color.Black;
            this.icDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icDelete.Location = new System.Drawing.Point(679, 296);
            this.icDelete.Name = "icDelete";
            this.icDelete.Size = new System.Drawing.Size(110, 44);
            this.icDelete.TabIndex = 2;
            this.icDelete.Text = "Delete";
            this.icDelete.UseVisualStyleBackColor = true;
            this.icDelete.Click += new System.EventHandler(this.icDelete_Click);
            // 
            // DeleteProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DeleteProduct";
            this.Text = "DeleteProduct";
            this.Load += new System.EventHandler(this.DeleteProduct_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicinedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView MedicinedataGridView;
        private System.Windows.Forms.TextBox textBoxDelete;
        private FontAwesome.Sharp.IconButton icDelete;
        private System.Windows.Forms.DataGridView EquipmentdataGridView;
        private FontAwesome.Sharp.IconButton icMedicine;
        private FontAwesome.Sharp.IconButton icEquipment;
    }
}