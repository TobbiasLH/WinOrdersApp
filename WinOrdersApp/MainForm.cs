using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinOrdersApp.Classes;

namespace WinOrdersApp
{
    public partial class MainForm : Form
    {
        DbAccess.Classes.Data db = new DbAccess.Classes.Data();
        public MainForm()
        {
            InitializeComponent();

            InitializeApplication();

            RefreshOrdersGridView();
        }

        private void btnSearchSendby_Click(object sender, EventArgs e)
        {
            DataTable dataTable = DataLayer.SelectOrdersBySendby(tbSearchText.Text);

            dgwOrders.DataSource = dataTable;

            Log("User Searched: " + tbSearchText.Text);
        }

        private void RefreshOrdersGridView()
        {
            DataTable dataTable = new DataTable();

            dataTable = DataLayer.SelectAllOrders();

            dgwOrders.DataSource = dataTable;
        }

        public void InitializeApplication()
        {

            StartPosition = FormStartPosition.CenterScreen;

            dgwOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            Refreshdatagrid();


            // dgwProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void Refreshdatagrid()
        {
            DataTable dataTable = db.SelectAllOrders();

            dgwOrders.DataSource = dataTable;

            lbRows.Text = Utils.DisplayRows(dataTable).ToString() + " Rows";
        }





        private void ErrorLog(string message)
        {
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter("ErrorLog.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ": " + message);
                sw.Flush();
                sw.Close();
            }
            catch
            {
            }
        }
        private void Log(string message)
        {
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter("Log.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ": " + message);
                sw.Flush();
                sw.Close();
            }
            catch
            {
            }
        }

        private void tbSearchText_TextChanged(object sender, EventArgs e)
        {
            dgwOrders.DataSource = DataLayer.SelectOrdersBySendby(tbSearchText.Text);
            
        }

        

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();

            addCustomerForm.ShowDialog();

            Refreshdatagrid();
        }

        

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            AddProductsForm addProductsForm = new AddProductsForm();

            addProductsForm.ShowDialog();

            Refreshdatagrid();
        }

       

        private void addOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrderForm addOrderForm = new AddOrderForm();

            addOrderForm.ShowDialog();

            Refreshdatagrid();

        }

        private void deleteOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedOrderNo = Convert.ToInt32(dgwOrders.SelectedRows[0].Cells["OrderNo"].Value);

                DialogResult result = MessageBox.Show("Delete order " + selectedOrderNo + "?", "Confirm", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    DataLayer.DeleteOrder(selectedOrderNo);

                    Refreshdatagrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Maybe you have'nt selected a row in the datagrid. \r\n" + ex.Message);
            }

        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomersForm customersForm = new CustomersForm();

            customersForm.ShowDialog();

            Refreshdatagrid();

        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();

            productsForm.ShowDialog();

            Refreshdatagrid();
        }

        private void dgwOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwOrders.SelectedRows.Count > 0)
            {
                int selectedOrderNo = Convert.ToInt32(dgwOrders.SelectedRows[0].Cells["OrderNo"].Value);

                tbOrderDate.Text = dgwOrders.SelectedRows[0].Cells["OrderDate"].Value.ToString();
                tbCustomerNo.Text = dgwOrders.SelectedRows[0].Cells["CustomerNo"].Value.ToString();
                tbSendBy.Text = dgwOrders.SelectedRows[0].Cells["SendBy"].Value.ToString();
                tbTotalAmount.Text = dgwOrders.SelectedRows[0].Cells["TotalAmount"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedOrderNo = Convert.ToInt32(dgwOrders.SelectedRows[0].Cells["OrderNo"].Value);

                DataLayer.UpdateOrder(selectedOrderNo, tbOrderDate.Text, Convert.ToInt32(tbCustomerNo.Text), tbSendBy.Text, Convert.ToDecimal(tbTotalAmount.Text));

                Refreshdatagrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Maybe you have'nt selected a row in the datagrid. \r\n" + ex.Message);
            }
        }

      
    }
}
