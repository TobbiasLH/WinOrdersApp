namespace WinOrdersApp
{
    partial class AddOrderForm
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
            this.tbTotalAmount = new System.Windows.Forms.TextBox();
            this.lbTotalAmount = new System.Windows.Forms.Label();
            this.tbSendby = new System.Windows.Forms.TextBox();
            this.tbCustomerNo = new System.Windows.Forms.TextBox();
            this.lbSendby = new System.Windows.Forms.Label();
            this.lbCustomerNo = new System.Windows.Forms.Label();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.tbOrderDate = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTotalAmount
            // 
            this.tbTotalAmount.Location = new System.Drawing.Point(108, 159);
            this.tbTotalAmount.Name = "tbTotalAmount";
            this.tbTotalAmount.Size = new System.Drawing.Size(275, 20);
            this.tbTotalAmount.TabIndex = 23;
            // 
            // lbTotalAmount
            // 
            this.lbTotalAmount.AutoSize = true;
            this.lbTotalAmount.Location = new System.Drawing.Point(32, 162);
            this.lbTotalAmount.Name = "lbTotalAmount";
            this.lbTotalAmount.Size = new System.Drawing.Size(70, 13);
            this.lbTotalAmount.TabIndex = 22;
            this.lbTotalAmount.Text = "TotalAmount:";
            // 
            // tbSendby
            // 
            this.tbSendby.Location = new System.Drawing.Point(108, 129);
            this.tbSendby.Name = "tbSendby";
            this.tbSendby.Size = new System.Drawing.Size(275, 20);
            this.tbSendby.TabIndex = 21;
            // 
            // tbCustomerNo
            // 
            this.tbCustomerNo.Location = new System.Drawing.Point(108, 92);
            this.tbCustomerNo.Name = "tbCustomerNo";
            this.tbCustomerNo.Size = new System.Drawing.Size(275, 20);
            this.tbCustomerNo.TabIndex = 20;
            // 
            // lbSendby
            // 
            this.lbSendby.AutoSize = true;
            this.lbSendby.Location = new System.Drawing.Point(56, 129);
            this.lbSendby.Name = "lbSendby";
            this.lbSendby.Size = new System.Drawing.Size(46, 13);
            this.lbSendby.TabIndex = 19;
            this.lbSendby.Text = "Sendby:";
            // 
            // lbCustomerNo
            // 
            this.lbCustomerNo.AutoSize = true;
            this.lbCustomerNo.Location = new System.Drawing.Point(34, 95);
            this.lbCustomerNo.Name = "lbCustomerNo";
            this.lbCustomerNo.Size = new System.Drawing.Size(68, 13);
            this.lbCustomerNo.TabIndex = 18;
            this.lbCustomerNo.Text = "CustomerNo:";
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(43, 57);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(59, 13);
            this.lbOrderDate.TabIndex = 17;
            this.lbOrderDate.Text = "OrderDate:";
            // 
            // tbOrderDate
            // 
            this.tbOrderDate.Location = new System.Drawing.Point(108, 54);
            this.tbOrderDate.Name = "tbOrderDate";
            this.tbOrderDate.Size = new System.Drawing.Size(275, 20);
            this.tbOrderDate.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(308, 214);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 254);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbTotalAmount);
            this.Controls.Add(this.lbTotalAmount);
            this.Controls.Add(this.tbSendby);
            this.Controls.Add(this.tbCustomerNo);
            this.Controls.Add(this.lbSendby);
            this.Controls.Add(this.lbCustomerNo);
            this.Controls.Add(this.lbOrderDate);
            this.Controls.Add(this.tbOrderDate);
            this.Name = "AddOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTotalAmount;
        private System.Windows.Forms.Label lbTotalAmount;
        private System.Windows.Forms.TextBox tbSendby;
        private System.Windows.Forms.TextBox tbCustomerNo;
        private System.Windows.Forms.Label lbSendby;
        private System.Windows.Forms.Label lbCustomerNo;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.TextBox tbOrderDate;
        private System.Windows.Forms.Button btnSave;
    }
}