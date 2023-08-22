
namespace MedicalStoreMnagementSystem.View
{
    partial class ViewProductAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.EquipmentGridView = new System.Windows.Forms.DataGridView();
            this.icequip = new FontAwesome.Sharp.IconButton();
            this.icMed = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentGridView)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 58);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 392);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(785, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 392);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(10, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(388, 392);
            this.panel4.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(388, 392);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.EquipmentGridView);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(398, 58);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(390, 392);
            this.panel5.TabIndex = 4;
            // 
            // EquipmentGridView
            // 
            this.EquipmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EquipmentGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentGridView.Location = new System.Drawing.Point(0, 0);
            this.EquipmentGridView.Name = "EquipmentGridView";
            this.EquipmentGridView.Size = new System.Drawing.Size(390, 392);
            this.EquipmentGridView.TabIndex = 0;
            // 
            // icequip
            // 
            this.icequip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icequip.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icequip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icequip.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icequip.IconColor = System.Drawing.Color.Black;
            this.icequip.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icequip.Location = new System.Drawing.Point(0, 0);
            this.icequip.Name = "icequip";
            this.icequip.Size = new System.Drawing.Size(200, 58);
            this.icequip.TabIndex = 1;
            this.icequip.Text = "Equipment";
            this.icequip.UseVisualStyleBackColor = true;
            this.icequip.Click += new System.EventHandler(this.icequip_Click);
            // 
            // icMed
            // 
            this.icMed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icMed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icMed.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icMed.IconColor = System.Drawing.Color.Black;
            this.icMed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icMed.Location = new System.Drawing.Point(0, 0);
            this.icMed.Name = "icMed";
            this.icMed.Size = new System.Drawing.Size(200, 58);
            this.icMed.TabIndex = 0;
            this.icMed.Text = "Medicine";
            this.icMed.UseVisualStyleBackColor = true;
            this.icMed.Click += new System.EventHandler(this.icMed_Click);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(95, 58);
            this.panel6.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.icMed);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(95, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 58);
            this.panel7.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(295, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(174, 58);
            this.panel8.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.icequip);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(469, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 58);
            this.panel9.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(669, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(131, 58);
            this.panel10.TabIndex = 4;
            // 
            // ViewProductAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewProductAdmin";
            this.Text = "ViewProductAdmin";
            this.Load += new System.EventHandler(this.ViewProductAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentGridView)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView EquipmentGridView;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private FontAwesome.Sharp.IconButton icequip;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconButton icMed;
        private System.Windows.Forms.Panel panel6;
    }
}