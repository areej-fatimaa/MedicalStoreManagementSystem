
namespace MedicalStoreMnagementSystem.View
{
    partial class RemoveFromCartFrm
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
            this.CartGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBoxRemoveItem = new System.Windows.Forms.TextBox();
            this.icRemove = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.68862F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.31138F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Controls.Add(this.CartGridView1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.icRemove, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxRemoveItem, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.22365F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.77635F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CartGridView1
            // 
            this.CartGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartGridView1.Location = new System.Drawing.Point(206, 62);
            this.CartGridView1.Name = "CartGridView1";
            this.CartGridView1.Size = new System.Drawing.Size(454, 282);
            this.CartGridView1.TabIndex = 0;
            this.CartGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CartGridView1_CellContentClick);
            // 
            // txtBoxRemoveItem
            // 
            this.txtBoxRemoveItem.BackColor = System.Drawing.Color.Lavender;
            this.txtBoxRemoveItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBoxRemoveItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRemoveItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtBoxRemoveItem.Location = new System.Drawing.Point(206, 365);
            this.txtBoxRemoveItem.Multiline = true;
            this.txtBoxRemoveItem.Name = "txtBoxRemoveItem";
            this.txtBoxRemoveItem.Size = new System.Drawing.Size(454, 41);
            this.txtBoxRemoveItem.TabIndex = 2;
            this.txtBoxRemoveItem.TextChanged += new System.EventHandler(this.txtBoxRemoveItem_TextChanged);
            // 
            // icRemove
            // 
            this.icRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icRemove.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icRemove.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icRemove.IconColor = System.Drawing.Color.Black;
            this.icRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icRemove.Location = new System.Drawing.Point(666, 350);
            this.icRemove.Name = "icRemove";
            this.icRemove.Size = new System.Drawing.Size(85, 56);
            this.icRemove.TabIndex = 1;
            this.icRemove.Text = "Remove";
            this.icRemove.UseVisualStyleBackColor = true;
            this.icRemove.Click += new System.EventHandler(this.icRemove_Click);
            // 
            // RemoveFromCartFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RemoveFromCartFrm";
            this.Text = "RemoveFromCartFrm";
            this.Load += new System.EventHandler(this.RemoveFromCartFrm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView CartGridView1;
        private FontAwesome.Sharp.IconButton icRemove;
        private System.Windows.Forms.TextBox txtBoxRemoveItem;
    }
}