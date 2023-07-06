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
using DbAccess.Classes;

namespace WinOrdersApp
{
    public partial class AddCustomerForm : Form
    {
        DbAccess.Classes.Data db = new DbAccess.Classes.Data();
        public AddCustomerForm()
        {
            InitializeComponent();

            RefreshCustomersGridView();
        }



        private void RefreshCustomersGridView()
        {
            DataTable dataTable = new DataTable();

            dataTable = db.SelectAllCustomers();

            dgwCustomer.DataSource = dataTable;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            db.InsertCustomersOrder((tbCustomerName.Text), (tbCustomerEmail.Text), (tbCustomerPhone.Text));

            Close();
        }
    }
}
