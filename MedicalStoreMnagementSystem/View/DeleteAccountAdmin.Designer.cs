
namespace MedicalStoreMnagementSystem.View
{
    partial class DeleteAccountAdmin
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
            this.txtBoxConfirm = new System.Windows.Forms.TextBox();
            this.icCOnfirmPassword = new FontAwesome.Sharp.IconButton();
            this.lblDelete = new System.Windows.Forms.Label();
            this.txtBoxConform2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.75F));
            this.tableLayoutPanel1.Controls.Add(this.txtBoxConfirm, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDelete, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.icCOnfirmPassword, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxConform2, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtBoxConfirm
            // 
            this.txtBoxConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxConfirm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxConfirm.Location = new System.Drawing.Point(185, 117);
            this.txtBoxConfirm.Name = "txtBoxConfirm";
            this.txtBoxConfirm.Size = new System.Drawing.Size(368, 27);
            this.txtBoxConfirm.TabIndex = 0;
            // 
            // icCOnfirmPassword
            // 
            this.icCOnfirmPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icCOnfirmPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icCOnfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icCOnfirmPassword.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icCOnfirmPassword.IconColor = System.Drawing.Color.Black;
            this.icCOnfirmPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icCOnfirmPassword.Location = new System.Drawing.Point(559, 198);
            this.icCOnfirmPassword.Name = "icCOnfirmPassword";
            this.icCOnfirmPassword.Size = new System.Drawing.Size(152, 30);
            this.icCOnfirmPassword.TabIndex = 1;
            this.icCOnfirmPassword.Text = "Delete Account";
            this.icCOnfirmPassword.UseVisualStyleBackColor = true;
            this.icCOnfirmPassword.Click += new System.EventHandler(this.icCOnfirmPassword_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.ForeColor = System.Drawing.Color.Lavender;
            this.lblDelete.Location = new System.Drawing.Point(185, 50);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(368, 64);
            this.lblDelete.TabIndex = 2;
            this.lblDelete.Text = "Enter Name and Password to Delete Account";
            // 
            // txtBoxConform2
            // 
            this.txtBoxConform2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxConform2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxConform2.Location = new System.Drawing.Point(185, 157);
            this.txtBoxConform2.Name = "txtBoxConform2";
            this.txtBoxConform2.Size = new System.Drawing.Size(368, 27);
            this.txtBoxConform2.TabIndex = 3;
            // 
            // DeleteAccountAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DeleteAccountAdmin";
            this.Text = "DeleteAccountAdmin";
            this.Load += new System.EventHandler(this.DeleteAccountAdmin_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtBoxConfirm;
        private FontAwesome.Sharp.IconButton icCOnfirmPassword;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.TextBox txtBoxConform2;
    }
}