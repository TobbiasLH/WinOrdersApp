namespace WinOrdersApp
{
    partial class AddProductsForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lbProductNo = new System.Windows.Forms.Label();
            this.lbProductDescription = new System.Windows.Forms.Label();
            this.lbProductGroupNo = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.tbProductNo = new System.Windows.Forms.TextBox();
            this.tbProductDescription = new System.Windows.Forms.TextBox();
            this.tbProductGroupNo = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(249, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbProductNo
            // 
            this.lbProductNo.AutoSize = true;
            this.lbProductNo.Location = new System.Drawing.Point(71, 70);
            this.lbProductNo.Name = "lbProductNo";
            this.lbProductNo.Size = new System.Drawing.Size(61, 13);
            this.lbProductNo.TabIndex = 1;
            this.lbProductNo.Text = "ProductNo:";
            // 
            // lbProductDescription
            // 
            this.lbProductDescription.AutoSize = true;
            this.lbProductDescription.Location = new System.Drawing.Point(32, 104);
            this.lbProductDescription.Name = "lbProductDescription";
            this.lbProductDescription.Size = new System.Drawing.Size(100, 13);
            this.lbProductDescription.TabIndex = 2;
            this.lbProductDescription.Text = "ProductDescription:";
            // 
            // lbProductGroupNo
            // 
            this.lbProductGroupNo.AutoSize = true;
            this.lbProductGroupNo.Location = new System.Drawing.Point(42, 140);
            this.lbProductGroupNo.Name = "lbProductGroupNo";
            this.lbProductGroupNo.Size = new System.Drawing.Size(90, 13);
            this.lbProductGroupNo.TabIndex = 3;
            this.lbProductGroupNo.Text = "ProductGroupNo:";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(83, 176);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(49, 13);
            this.lbQuantity.TabIndex = 4;
            this.lbQuantity.Text = "Quantity:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(98, 217);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(34, 13);
            this.lbPrice.TabIndex = 5;
            this.lbPrice.Text = "Price:";
            // 
            // tbProductNo
            // 
            this.tbProductNo.Location = new System.Drawing.Point(139, 70);
            this.tbProductNo.Name = "tbProductNo";
            this.tbProductNo.Size = new System.Drawing.Size(200, 20);
            this.tbProductNo.TabIndex = 6;
            // 
            // tbProductDescription
            // 
            this.tbProductDescription.Location = new System.Drawing.Point(139, 104);
            this.tbProductDescription.Name = "tbProductDescription";
            this.tbProductDescription.Size = new System.Drawing.Size(200, 20);
            this.tbProductDescription.TabIndex = 7;
            // 
            // tbProductGroupNo
            // 
            this.tbProductGroupNo.Location = new System.Drawing.Point(139, 140);
            this.tbProductGroupNo.Name = "tbProductGroupNo";
            this.tbProductGroupNo.Size = new System.Drawing.Size(200, 20);
            this.tbProductGroupNo.TabIndex = 8;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(139, 176);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(200, 20);
            this.tbQuantity.TabIndex = 9;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(139, 214);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(200, 20);
            this.tbPrice.TabIndex = 10;
            // 
            // AddProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 313);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.tbProductGroupNo);
            this.Controls.Add(this.tbProductDescription);
            this.Controls.Add(this.tbProductNo);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbProductGroupNo);
            this.Controls.Add(this.lbProductDescription);
            this.Controls.Add(this.lbProductNo);
            this.Controls.Add(this.btnSave);
            this.Name = "AddProductsForm";
            this.Text = "Add Products";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbProductNo;
        private System.Windows.Forms.Label lbProductDescription;
        private System.Windows.Forms.Label lbProductGroupNo;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox tbProductNo;
        private System.Windows.Forms.TextBox tbProductDescription;
        private System.Windows.Forms.TextBox tbProductGroupNo;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox tbPrice;
    }
}