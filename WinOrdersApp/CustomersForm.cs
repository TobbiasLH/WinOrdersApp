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
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();

            InitiliazeForm();

            RefreshCustomersGridView();
        }
        public void InitiliazeForm()
        {
            StartPosition = FormStartPosition.CenterScreen;

            dgwCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void RefreshCustomersGridView()
        {
            DataTable dataTable = new DataTable();

            dataTable = DataLayer.SelectAllCustomers();

            dgwCustomer.DataSource = dataTable;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string search = tbSearch.Text;

            DataTable dataTable = new DataTable();

            dataTable = DataLayer.SelectCustomerByName(search);

            dgwCustomer.DataSource = dataTable;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();

            addCustomerForm.ShowDialog();

            RefreshCustomersGridView();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            int customerNo = Convert.ToInt32(dgwCustomer.SelectedRows[0].Cells["CustomerNo"].Value);

            DataLayer.DeleteCustomer(customerNo);

            RefreshCustomersGridView();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();

            addCustomerForm.ShowDialog();

            RefreshCustomersGridView();
        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int customerNo = Convert.ToInt32(dgwCustomer.SelectedRows[0].Cells["CustomerNo"].Value);

                try
                {
                    int selectedCustomerNo = Convert.ToInt32(dgwCustomer.SelectedRows[0].Cells["CustomerNo"].Value);

                    DialogResult result = MessageBox.Show("Delete customer " + selectedCustomerNo + "?", "Confirm", MessageBoxButtons.OKCancel);

                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        DataLayer.DeleteCustomer(selectedCustomerNo);

                        RefreshCustomersGridView();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Maybe you haven't selected a row in the datagrid");


                }

                DataLayer.DeleteCustomer(customerNo);

                RefreshCustomersGridView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void dgwCustomer_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwCustomer.SelectedRows.Count > 0)
            {
                int selectedCustomerNo = Convert.ToInt32(dgwCustomer.SelectedRows[0].Cells["CustomerNo"].Value);

                tbCustomerName.Text = dgwCustomer.SelectedRows[0].Cells["CustomerName"].Value.ToString();
                tbEmail.Text = dgwCustomer.SelectedRows[0].Cells["Email"].Value.ToString();
                tbPhone.Text = dgwCustomer.SelectedRows[0].Cells["Phone"].Value.ToString();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedCustomerNo = Convert.ToInt32(dgwCustomer.SelectedRows[0].Cells["CustomerNo"].Value);

                DataLayer.UpdateCustomer(selectedCustomerNo, tbCustomerName.Text, tbEmail.Text, tbPhone.Text);

                RefreshCustomersGridView();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Maybe you have'nt selected a row in the datagrid. \r\n" + ex.Message);
            }
        }
    }
}
