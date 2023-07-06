using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinOrdersApp.Classes
{
    internal class Utils
    {
        public static int DisplayRows(DataTable dataTable)
        {
            int rows = dataTable.Rows.Count;

            return rows;
        }
    }
}
