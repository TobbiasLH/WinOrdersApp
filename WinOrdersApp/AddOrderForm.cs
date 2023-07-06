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
    public partial class AddOrderForm : Form
    {
        DbAccess.Classes.Data db = new DbAccess.Classes.Data();
        public AddOrderForm()
        {
            InitializeComponent();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.InsertOrder(tbOrderDate.Text, Convert.ToInt32(tbCustomerNo.Text), tbSendby.Text, Convert.ToDecimal(tbTotalAmount.Text));

            Close();
        }
    }
}
