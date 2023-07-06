namespace WinOrdersApp
{
    partial class AddCustomerForm
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
            this.lbCustomerNo2 = new System.Windows.Forms.Label();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.lbCustomerEmail = new System.Windows.Forms.Label();
            this.lbCustomerPhone = new System.Windows.Forms.Label();
            this.tbCustomerNoo = new System.Windows.Forms.TextBox();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.tbCustomerEmail = new System.Windows.Forms.TextBox();
            this.tbCustomerPhone = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgwCustomer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCustomerNo2
            // 
            this.lbCustomerNo2.AutoSize = true;
            this.lbCustomerNo2.Location = new System.Drawing.Point(56, 64);
            this.lbCustomerNo2.Name = "lbCustomerNo2";
            this.lbCustomerNo2.Size = new System.Drawing.Size(68, 13);
            this.lbCustomerNo2.TabIndex = 0;
            this.lbCustomerNo2.Text = "CustomerNo:";
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Location = new System.Drawing.Point(42, 103);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(82, 13);
            this.lbCustomerName.TabIndex = 1;
            this.lbCustomerName.Text = "CustomerName:";
            // 
            // lbCustomerEmail
            // 
            this.lbCustomerEmail.AutoSize = true;
            this.lbCustomerEmail.Location = new System.Drawing.Point(89, 145);
            this.lbCustomerEmail.Name = "lbCustomerEmail";
            this.lbCustomerEmail.Size = new System.Drawing.Size(35, 13);
            this.lbCustomerEmail.TabIndex = 2;
            this.lbCustomerEmail.Text = "Email:";
            // 
            // lbCustomerPhone
            // 
            this.lbCustomerPhone.AutoSize = true;
            this.lbCustomerPhone.Location = new System.Drawing.Point(83, 183);
            this.lbCustomerPhone.Name = "lbCustomerPhone";
            this.lbCustomerPhone.Size = new System.Drawing.Size(41, 13);
            this.lbCustomerPhone.TabIndex = 3;
            this.lbCustomerPhone.Text = "Phone:";
            // 
            // tbCustomerNoo
            // 
            this.tbCustomerNoo.Location = new System.Drawing.Point(130, 61);
            this.tbCustomerNoo.Name = "tbCustomerNoo";
            this.tbCustomerNoo.Size = new System.Drawing.Size(222, 20);
            this.tbCustomerNoo.TabIndex = 4;
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(130, 100);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(222, 20);
            this.tbCustomerName.TabIndex = 5;
            // 
            // tbCustomerEmail
            // 
            this.tbCustomerEmail.Location = new System.Drawing.Point(130, 138);
            this.tbCustomerEmail.Name = "tbCustomerEmail";
            this.tbCustomerEmail.Size = new System.Drawing.Size(222, 20);
            this.tbCustomerEmail.TabIndex = 6;
            // 
            // tbCustomerPhone
            // 
            this.tbCustomerPhone.Location = new System.Drawing.Point(130, 180);
            this.tbCustomerPhone.Name = "tbCustomerPhone";
            this.tbCustomerPhone.Size = new System.Drawing.Size(222, 20);
            this.tbCustomerPhone.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(228, 221);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgwCustomer
            // 
            this.dgwCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwCustomer.Location = new System.Drawing.Point(0, 263);
            this.dgwCustomer.Name = "dgwCustomer";
            this.dgwCustomer.Size = new System.Drawing.Size(494, 225);
            this.dgwCustomer.TabIndex = 9;
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 488);
            this.Controls.Add(this.dgwCustomer);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbCustomerPhone);
            this.Controls.Add(this.tbCustomerEmail);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.tbCustomerNoo);
            this.Controls.Add(this.lbCustomerPhone);
            this.Controls.Add(this.lbCustomerEmail);
            this.Controls.Add(this.lbCustomerName);
            this.Controls.Add(this.lbCustomerNo2);
            this.Name = "AddCustomerForm";
            this.Text = "Add Customer";
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCustomerNo2;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Label lbCustomerEmail;
        private System.Windows.Forms.Label lbCustomerPhone;
        private System.Windows.Forms.TextBox tbCustomerNoo;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.TextBox tbCustomerEmail;
        private System.Windows.Forms.TextBox tbCustomerPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgwCustomer;
    }
}