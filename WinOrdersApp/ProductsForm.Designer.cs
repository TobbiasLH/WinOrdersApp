namespace WinOrdersApp
{
    partial class ProductsForm
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
            this.lbSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(126, 20);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(44, 13);
            this.lbSearch.TabIndex = 0;
            this.lbSearch.Text = "Search:";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(176, 17);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(313, 20);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwProduct.Location = new System.Drawing.Point(0, 284);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(800, 166);
            this.dgwProduct.TabIndex = 4;
            this.dgwProduct.SelectionChanged += new System.EventHandler(this.dgwProduct_SelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductsToolStripMenuItem,
            this.deleteProductsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addProductsToolStripMenuItem
            // 
            this.addProductsToolStripMenuItem.Name = "addProductsToolStripMenuItem";
            this.addProductsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addProductsToolStripMenuItem.Text = "Add Products";
            this.addProductsToolStripMenuItem.Click += new System.EventHandler(this.addProductsToolStripMenuItem_Click);
            // 
            // deleteProductsToolStripMenuItem
            // 
            this.deleteProductsToolStripMenuItem.Name = "deleteProductsToolStripMenuItem";
            this.deleteProductsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.deleteProductsToolStripMenuItem.Text = "Delete Products";
            this.deleteProductsToolStripMenuItem.Click += new System.EventHandler(this.deleteProductsToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.lbSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 63);
            this.panel1.TabIndex = 6;
            // 
            // lbProductNo
            // 
            this.lbProductNo.AutoSize = true;
            this.lbProductNo.Location = new System.Drawing.Point(109, 20);
            this.lbProductNo.Name = "lbProductNo";
            this.lbProductNo.Size = new System.Drawing.Size(61, 13);
            this.lbProductNo.TabIndex = 7;
            this.lbProductNo.Text = "ProductNo:";
            // 
            // lbProductDescription
            // 
            this.lbProductDescription.AutoSize = true;
            this.lbProductDescription.Location = new System.Drawing.Point(70, 53);
            this.lbProductDescription.Name = "lbProductDescription";
            this.lbProductDescription.Size = new System.Drawing.Size(100, 13);
            this.lbProductDescription.TabIndex = 8;
            this.lbProductDescription.Text = "ProductDescription:";
            // 
            // lbProductGroupNo
            // 
            this.lbProductGroupNo.AutoSize = true;
            this.lbProductGroupNo.Location = new System.Drawing.Point(80, 84);
            this.lbProductGroupNo.Name = "lbProductGroupNo";
            this.lbProductGroupNo.Size = new System.Drawing.Size(90, 13);
            this.lbProductGroupNo.TabIndex = 9;
            this.lbProductGroupNo.Text = "ProductGroupNo:";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(121, 114);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(49, 13);
            this.lbQuantity.TabIndex = 10;
            this.lbQuantity.Text = "Quantity:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(136, 148);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(34, 13);
            this.lbPrice.TabIndex = 11;
            this.lbPrice.Text = "Price:";
            // 
            // tbProductNo
            // 
            this.tbProductNo.Location = new System.Drawing.Point(176, 20);
            this.tbProductNo.Name = "tbProductNo";
            this.tbProductNo.Size = new System.Drawing.Size(198, 20);
            this.tbProductNo.TabIndex = 12;
            // 
            // tbProductDescription
            // 
            this.tbProductDescription.Location = new System.Drawing.Point(177, 53);
            this.tbProductDescription.Name = "tbProductDescription";
            this.tbProductDescription.Size = new System.Drawing.Size(198, 20);
            this.tbProductDescription.TabIndex = 13;
            // 
            // tbProductGroupNo
            // 
            this.tbProductGroupNo.Location = new System.Drawing.Point(177, 84);
            this.tbProductGroupNo.Name = "tbProductGroupNo";
            this.tbProductGroupNo.Size = new System.Drawing.Size(198, 20);
            this.tbProductGroupNo.TabIndex = 14;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(177, 114);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(198, 20);
            this.tbQuantity.TabIndex = 15;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(176, 145);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(199, 20);
            this.tbPrice.TabIndex = 16;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(381, 143);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tbProductNo);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.lbProductNo);
            this.panel2.Controls.Add(this.tbPrice);
            this.panel2.Controls.Add(this.lbProductDescription);
            this.panel2.Controls.Add(this.tbQuantity);
            this.panel2.Controls.Add(this.lbProductGroupNo);
            this.panel2.Controls.Add(this.tbProductGroupNo);
            this.panel2.Controls.Add(this.lbQuantity);
            this.panel2.Controls.Add(this.tbProductDescription);
            this.panel2.Controls.Add(this.lbPrice);
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 199);
            this.panel2.TabIndex = 18;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgwProduct);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProductsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel2;
    }
}