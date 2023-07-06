using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinOrdersApp.Classes;

namespace WinOrdersApp
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();

            InitiliazeForm();

            RefreshProductsGridView();
        }

        public void InitiliazeForm()
        {
            StartPosition = FormStartPosition.CenterScreen;

            dgwProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void RefreshProductsGridView()
        {
            DataTable dataTable = new DataTable();

            dataTable = DataLayer.SelectAllProducts();

            dgwProduct.DataSource = dataTable;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string search = tbSearch.Text;

            DataTable dataTable = new DataTable();

            dataTable = DataLayer.SelectProductByName(search);

            dgwProduct.DataSource = dataTable;
        }

        private void addProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProductsForm addProductsForm = new AddProductsForm();

            addProductsForm.ShowDialog();

            RefreshProductsGridView();
        }

        private void deleteProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string productNo = dgwProduct.SelectedRows[0].Cells["ProductNo"].Value.ToString();

            DialogResult result = MessageBox.Show("Delete products " + productNo + "?", "Confirm", MessageBoxButtons.OKCancel);

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                DataLayer.DeleteProducts(productNo);

                RefreshProductsGridView();
            }
        }

        private void dgwProduct_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwProduct.SelectedRows.Count > 0)
            {
                string selectedProductNo = dgwProduct.SelectedRows[0].Cells["ProductNo"].Value.ToString();

                tbProductNo.Text = dgwProduct.SelectedRows[0].Cells["ProductNo"].Value.ToString();
                tbProductDescription.Text = dgwProduct.SelectedRows[0].Cells["ProductDescription"].Value.ToString();
                tbProductGroupNo.Text = dgwProduct.SelectedRows[0].Cells["ProductGroupNo"].Value.ToString();
                tbQuantity.Text = dgwProduct.SelectedRows[0].Cells["Quantity"].Value.ToString();
                tbPrice.Text = dgwProduct.SelectedRows[0].Cells["Price"].Value.ToString();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedProductNo = dgwProduct.SelectedRows[0].Cells["ProductNo"].Value.ToString();

                DataLayer.UpdateProducts(selectedProductNo, tbProductDescription.Text, Convert.ToInt32(tbProductGroupNo.Text), Convert.ToInt32(tbQuantity.Text), Convert.ToDecimal(tbPrice.Text));

                RefreshProductsGridView();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Maybe you have'nt selected a row in the datagrid. \r\n" + ex.Message);
            }
        }
    }
}
