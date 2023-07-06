using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbAccess.Classes
{
    public class Data
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

       

        // Orders
        public  DataTable SelectOrdersBySendby(string sendBy)
        {
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = @"
             SELECT *
               FROM Orders
              WHERE Sendby like '%' + @Sendby + '%'
            ";

            sqlCommand.Parameters.AddWithValue("@Sendby", sendBy);

            DataTable dataTable = SelectData(sqlCommand);

            return dataTable;
        }

        public  int InsertOrder(string orderDate, int customerNo, string sendBy, decimal totalAmount)
        {
            int result = 0;

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = @"
            INSERT INTO Orders(OrderDate, CustomerNo, Sendby, TotalAmount) VALUES(@OrderDate, @CustomerNo, @Sendby, @TotalAmount)";

            sqlCommand.Parameters.AddWithValue("@OrderDate", orderDate);
            sqlCommand.Parameters.AddWithValue("@CustomerNo", customerNo);
            sqlCommand.Parameters.AddWithValue("@Sendby", sendBy);
            sqlCommand.Parameters.AddWithValue("@TotalAmount", totalAmount);

            result = UpdateData(sqlCommand);

            return result;
        }

        public  int UpdateOrder(int orderNo, string orderDate, int customerNo, string sendBy, decimal totalAmount)
        {
            int result = 0;

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = @"
            UPDATE Orders
            SET Orderdate = @OrderDate,
                CustomerNo = @CustomerNo,
                Sendby = @Sendby,
                TotalAmount =  @TotalAmount
            
            WHERE OrderNo = @OrderNo
            ";

            sqlCommand.Parameters.AddWithValue("@OrderDate", orderDate);
            sqlCommand.Parameters.AddWithValue("@CustomerNo", customerNo);
            sqlCommand.Parameters.AddWithValue("@Sendby", sendBy);
            sqlCommand.Parameters.AddWithValue("@TotalAmount", totalAmount);
            sqlCommand.Parameters.AddWithValue("@OrderNo", orderNo);

            result = UpdateData(sqlCommand);

            return result;
        }

        public  int DeleteOrder(int orderNo)
        {
            int result = 0;

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = @"
                DELETE FROM Orders WHERE OrderNo = @OrderNo";

            sqlCommand.Parameters.AddWithValue("@OrderNo", orderNo);

            result = UpdateData(sqlCommand);

            return result;
        }

        public  DataTable SelectAllOrders()
        {
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = @"
             SELECT *
               FROM [Orders]
            ";

            DataTable dataTable = SelectData(sqlCommand);

            return dataTable;
        }

        public  int DeleteOrderLine(int orderNo, int lineNumber)
        {
            int result = 0;

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = @"
                DELETE FROM OrderLines WHERE OrderNo = @OrderNo and LineNumber = @LineNumber";

            sqlCommand.Parameters.AddWithValue("@OrderNo", orderNo);
            sqlCommand.Parameters.AddWithValue("@LineNumber", lineNumber);

            result = UpdateData(sqlCommand);

            return result;
        }


        // Customers
        public  DataTable SelectAllCustomers()
        {
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = @"
             SELECT * FROM Customers
            ";

            DataTable dataTable = SelectData(sqlCommand);

            return dataTable;
        }

        public  int InsertCustomersOrder(string customerName, string email, string phone)
        {
            int result = 0;

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = @"
            INSERT INTO Customers(CustomerName, Email, Phone) VALUES (@CustomerName, @Email, @Phone)";

            sqlCommand.Parameters.AddWithValue("@CustomerName", customerName);
            sqlCommand.Parameters.AddWithValue("@Email", email);
            sqlCommand.Parameters.AddWithValue("@Phone", phone);

            result = UpdateData(sqlCommand);

            return result;
        }

        public  int UpdateCustomer(int customerNo, string customerName, string email, string phone)
        {
            int result = 0;

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = @"
            UPDATE Customers
            SET CustomerName = @CustomerName,
                Email = @Email,
                Phone = @Phone
            
            WHERE CustomerNo = @CustomerNo
            ";

            sqlCommand.Parameters.AddWithValue("@CustomerNo", customerNo);
            sqlCommand.Parameters.AddWithValue("@CustomerName", customerName);
            sqlCommand.Parameters.AddWithValue("@Email", email);
            sqlCommand.Parameters.AddWithValue("@Phone", phone);

            result = UpdateData(sqlCommand);

            return result;
        }

        public  int InsertCustNoSendbyToOrder(int customerNo, string sendBy)
        {
            int result = 0;

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = @"
            INSERT INTO ORDERS (CustomerNo, Sendby) VALUES (@CustomerNo, @Sendby)";

            sqlCommand.Parameters.AddWithValue("@CustomerNo", customerNo);
            sqlCommand.Parameters.AddWithValue("@Sendby", sendBy);

            result = UpdateData(sqlCommand);

            return result;

        }

        public  DataTable SelectCustomerByName(string customerName)
        {
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = @"
             SELECT *
               FROM Customers
              WHERE CustomerName like '%' + @CustomerName + '%'
            ";

            sqlCommand.Parameters.AddWithValue("@CustomerName", customerName);

            DataTable dataTable = SelectData(sqlCommand);

            return dataTable;
        }

        public  int DeleteCustomer(int customerNo)
        {
            int result = 0;

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = @"
                DELETE FROM Customers WHERE CustomerNo = @CustomerNo";

            sqlCommand.Parameters.AddWithValue("@CustomerNo", customerNo);

            result = UpdateData(sqlCommand);

            return result;
        }


        // Products

        public  DataTable SelectAllProducts()
        {
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = @"
             SELECT * FROM Products
            ";

            DataTable dataTable = SelectData(sqlCommand);

            return dataTable;
        }


        public  int InsertProductsOrder(string productNo, string productDescription, int productGroupNo, int quantity, decimal price)
        {
            int result = 0;

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = @"
            INSERT INTO Products(ProductNo, ProductDescription, ProductGroupNo, Quantity, Price) VALUES (@ProductNo, @ProductDescription, @ProductGroupNo, @Quantity, @Price)";

            sqlCommand.Parameters.AddWithValue("@ProductNo", productNo);
            sqlCommand.Parameters.AddWithValue("@ProductDescription", productDescription);
            sqlCommand.Parameters.AddWithValue("@ProductGroupNo", productGroupNo);
            sqlCommand.Parameters.AddWithValue("@Quantity", quantity);
            sqlCommand.Parameters.AddWithValue("@Price", price);

            result = UpdateData(sqlCommand);

            return result;
        }

        public  int UpdateProducts(string productNo, string productDescription, int productGroupNo, int quantity, decimal price)
        {
            int result = 0;

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = @"
            UPDATE Products
            SET ProductDescription = @ProductDescription,
                ProductGroupNo = @ProductGroupNo,
                Quantity = @Quantity,
                Price = @Price
            
            WHERE ProductNo = @ProductNo
            ";
            sqlCommand.Parameters.AddWithValue("@ProductNo", productNo);
            sqlCommand.Parameters.AddWithValue("@ProductDescription", productDescription);
            sqlCommand.Parameters.AddWithValue("@ProductGroupNo", productGroupNo);
            sqlCommand.Parameters.AddWithValue("@Quantity", quantity);
            sqlCommand.Parameters.AddWithValue("@Price", price);


            result = UpdateData(sqlCommand);

            return result;
        }

        public  DataTable SelectProductByName(string productDescription)
        {
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = @"
             SELECT *
               FROM Products
              WHERE ProductDescription like '%' + @ProductDescription + '%'
            ";

            sqlCommand.Parameters.AddWithValue("@ProductDescription", productDescription);

            DataTable dataTable = SelectData(sqlCommand);

            return dataTable;
        }

        public  int DeleteProducts(string productNo)
        {
            int result = 0;

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = @"
                DELETE FROM Products WHERE ProductNo = @ProductNo";

            sqlCommand.Parameters.AddWithValue("@ProductNo", productNo);

            result = UpdateData(sqlCommand);

            return result;
        }











        // DB
        private static int UpdateData(SqlCommand sqlCommand)
        {
            int affectedRows = 0;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (sqlCommand)
                {
                    sqlCommand.Connection = sqlConnection;

                    affectedRows = sqlCommand.ExecuteNonQuery();
                }
            }

            return affectedRows;
        }

        public static DataTable SelectData(SqlCommand sqlCommand)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (sqlCommand)
                {
                    sqlCommand.Connection = sqlConnection;

                    dataTable.Load(sqlCommand.ExecuteReader());
                }
            }

            return dataTable;
        }
    }
}
