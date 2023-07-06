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
    public partial class AddProductsForm : Form
    {
        DbAccess.Classes.Data db = new DbAccess.Classes.Data();
        public AddProductsForm()
        {
            InitializeComponent();

            RefreshProductsGridView();
        }


        private void RefreshProductsGridView()
        {
            DataTable dataTable = new DataTable();

            dataTable = db.SelectAllProducts();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            db.InsertProductsOrder((tbProductNo.Text), (tbProductDescription.Text), Convert.ToInt32(tbProductGroupNo.Text), Convert.ToInt32(tbQuantity.Text), Convert.ToDecimal(tbPrice.Text));

            Close();
        }
    }
}
