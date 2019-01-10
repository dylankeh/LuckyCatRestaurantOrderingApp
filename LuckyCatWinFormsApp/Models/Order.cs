using LuckyCatWinFormsApp.DB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyCatWinFormsApp
{
    /// <summary>
    /// This contains all the methods used to change orders in the database.
    /// 
    /// Created By: Kevin
    /// </summary>
    class Order
    {
        /// <summary>
        /// Creates the order in the database.
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="employeeID"></param>
        /// <returns></returns>
        public static int CreateNewOrder(string tableName, string employeeID)
        {
            SqlConnection cnn = DBConn.SaylnConn();
            SqlCommand command;
            cnn.Open();
            string queryString = "INSERT INTO Orders values(@tableName, @employeeID);SELECT CAST(scope_identity() AS int)";
            command = new SqlCommand(queryString, cnn);
            command.Parameters.AddWithValue("@tableName", tableName);
            command.Parameters.AddWithValue("@employeeID", employeeID);
            int OrderID = (int)command.ExecuteScalar();
            cnn.Close();
            return OrderID;
        }

        /// <summary>
        /// Inserts a row into the OrderDish Table
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="dishName"></param>
        /// <param name="qty"></param>
        public static void AddDish(int orderId, string dishName, int qty)
        {
            string dishID = GetDishID(dishName);
            SqlConnection cnn = DB.DBConn.SaylnConn();
            SqlCommand command;
            cnn.Open();
            string queryString = "INSERT INTO OrderDish values(@orderId, @dishID, @qty)";
            command = new SqlCommand(queryString, cnn);
            command.Parameters.AddWithValue("@orderId", orderId);
            command.Parameters.AddWithValue("@dishID", dishID);
            command.Parameters.AddWithValue("@qty", qty);
            command.ExecuteNonQuery();
            cnn.Close();
        }

        /// <summary>
        /// Gets the list of dishes in the database
        /// </summary>
        /// <param name="DishName"></param>
        /// <returns></returns>
        public static string GetDishID(string DishName)
        {
            SqlConnection cnn = DB.DBConn.SaylnConn();
            SqlCommand command;
            cnn.Open();
            string queryString = "SELECT * FROM Dishes WHERE DishName = @DishName";
            command = new SqlCommand(queryString, cnn);
            command.Parameters.AddWithValue("@DishName", DishName);
            SqlDataReader reader = command.ExecuteReader();
            string id = "";
            if (reader.Read())
            {
                id = reader["DishID"].ToString();
            }
            cnn.Close();
            return id;
        }

        /// <summary>
        /// This clears all the items in the order
        /// </summary>
        /// <param name="orderID"></param>
        public static void Clear(int orderID)
        {
            SqlConnection cnn = DB.DBConn.SaylnConn();
            SqlCommand command;
            cnn.Open();
            string queryString = "DELETE FROM OrderDish WHERE orderID = @orderID";
            command = new SqlCommand(queryString, cnn);
            command.Parameters.AddWithValue("@orderID", orderID);
            command.ExecuteNonQuery();
            cnn.Close();
        }

        /// <summary>
        /// This clears the order and all the dishes in that order whenever the order is paid for.
        /// </summary>
        /// <param name="TableName"></param>
        public static void DeleteOrders(string TableName)
        {
            SqlConnection cnn = DB.DBConn.SaylnConn();
            SqlCommand command;
            cnn.Open();
            string queryString =
                @"DELETE b
                FROM Orders a 
                INNER JOIN OrderDish b on a.OrderId = b.orderid
                where TableName = @TableName;
                DELETE 
                FROM Orders 
                WHERE TableName= @TableName;";
            command = new SqlCommand(queryString, cnn);
            command.Parameters.AddWithValue("@TableName", TableName);
            command.ExecuteNonQuery();
            cnn.Close();
        }

    }
}
