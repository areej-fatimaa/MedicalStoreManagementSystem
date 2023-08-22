
namespace MedicalStoreMnagementSystem.View
{
    partial class RemoveUser
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
            this.UsersGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBoxRemoveUsers = new System.Windows.Forms.TextBox();
            this.icRemove = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridView1)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.UsersGridView1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.icRemove, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxRemoveUsers, 1, 2);
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
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // UsersGridView1
            // 
            this.UsersGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersGridView1.Location = new System.Drawing.Point(206, 62);
            this.UsersGridView1.Name = "UsersGridView1";
            this.UsersGridView1.Size = new System.Drawing.Size(454, 282);
            this.UsersGridView1.TabIndex = 0;
            this.UsersGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersGridView1_CellContentClick);
            // 
            // txtBoxRemoveUsers
            // 
            this.txtBoxRemoveUsers.BackColor = System.Drawing.Color.Lavender;
            this.txtBoxRemoveUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBoxRemoveUsers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRemoveUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtBoxRemoveUsers.Location = new System.Drawing.Point(206, 365);
            this.txtBoxRemoveUsers.Multiline = true;
            this.txtBoxRemoveUsers.Name = "txtBoxRemoveUsers";
            this.txtBoxRemoveUsers.Size = new System.Drawing.Size(454, 41);
            this.txtBoxRemoveUsers.TabIndex = 2;
            this.txtBoxRemoveUsers.TextChanged += new System.EventHandler(this.txtBoxRemoveUsers_TextChanged);
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
            // RemoveUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RemoveUser";
            this.Text = "RemoveUser";
            this.Load += new System.EventHandler(this.RemoveUser_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView UsersGridView1;
        private FontAwesome.Sharp.IconButton icRemove;
        private System.Windows.Forms.TextBox txtBoxRemoveUsers;
    }
}