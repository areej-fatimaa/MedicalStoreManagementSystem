
namespace MedicalStoreMnagementSystem.View
{
    partial class CustomerBillFrm
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
            this.BillPanal = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.icCash = new FontAwesome.Sharp.IconButton();
            this.icCard = new FontAwesome.Sharp.IconButton();
            this.BillPanal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BillPanal
            // 
            this.BillPanal.ColumnCount = 5;
            this.BillPanal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.07307F));
            this.BillPanal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.92693F));
            this.BillPanal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.BillPanal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.BillPanal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.BillPanal.Controls.Add(this.dataGridView1, 1, 1);
            this.BillPanal.Controls.Add(this.icCash, 2, 2);
            this.BillPanal.Controls.Add(this.icCard, 3, 2);
            this.BillPanal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BillPanal.Location = new System.Drawing.Point(0, 0);
            this.BillPanal.Name = "BillPanal";
            this.BillPanal.RowCount = 4;
            this.BillPanal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.42543F));
            this.BillPanal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.57457F));
            this.BillPanal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.BillPanal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.BillPanal.Size = new System.Drawing.Size(800, 450);
            this.BillPanal.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(89, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(524, 259);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // icCash
            // 
            this.icCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icCash.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icCash.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icCash.IconColor = System.Drawing.Color.Black;
            this.icCash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icCash.Location = new System.Drawing.Point(619, 312);
            this.icCash.Name = "icCash";
            this.icCash.Size = new System.Drawing.Size(66, 40);
            this.icCash.TabIndex = 1;
            this.icCash.Text = "Cash";
            this.icCash.UseVisualStyleBackColor = true;
            this.icCash.Click += new System.EventHandler(this.icCash_Click);
            // 
            // icCard
            // 
            this.icCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icCard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icCard.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icCard.IconColor = System.Drawing.Color.Black;
            this.icCard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icCard.Location = new System.Drawing.Point(691, 312);
            this.icCard.Name = "icCard";
            this.icCard.Size = new System.Drawing.Size(61, 40);
            this.icCard.TabIndex = 2;
            this.icCard.Text = "Card";
            this.icCard.UseVisualStyleBackColor = true;
            this.icCard.Click += new System.EventHandler(this.icCard_Click);
            // 
            // CustomerBillFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BillPanal);
            this.Name = "CustomerBillFrm";
            this.Text = "CustomerBillFrm";
            this.Load += new System.EventHandler(this.CustomerBillFrm_Load);
            this.BillPanal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BillPanal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton icCash;
        private FontAwesome.Sharp.IconButton icCard;
    }
}