using LuckyCatWinFormsApp.DB;
using LuckyCatWinFormsApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyCatWinFormsApp
{
    /// <summary>
    /// This form is used to ask for the bill and display the total price with tax and discount for each table.
    /// 
    /// Created by Kevin
    /// </summary>
    public partial class Checkout : Form
    {
        string tableName;
        string employeeName;
        List<double> dishPrices;

        /// <summary>
        /// This is created with the table the bill is for and the employee that wants to display the bill.
        /// 
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="emp"></param>
        public Checkout(string tableName, Employee emp)
        {
            InitializeComponent();
            this.tableName = tableName;
            employeeName = emp.EmployeeName;
        }

        /// <summary>
        /// This method is used to display all the information about the orders this table has made.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Checkout_Load(object sender, EventArgs e)
        {
            String[] discount = { "Pay Cash -10%", "Old Customer -25%", "Holiday Discount -20%", "No Discount" };
            cbxDiscount.Items.AddRange(discount);
            UpdateListBox(sender, e);
            try
            {
                double subtotal = 0;
                lstDishOrdered.Items.Clear();
                lstDishOrdered.Items.Add("---Dishes Ordered---");
                SqlConnection cnn = DBConn.SaylnConn();
                SqlCommand command;
                cnn.Open();
                string queryString = @"  
                    SELECT b.DishID, SUM(Quantity) as Qty, MAX(DishName) as DishName, DishPrice
                    FROM Orders a
                    INNER JOIN OrderDish b on a.OrderID = b.OrderID
                    INNER JOIN Dishes c on b.DishID = c.DishID
                    WHERE TableName = @TableName
                    GROUP BY b.DISHID, DishPrice";

                command = new SqlCommand(queryString, cnn);
                command.Parameters.AddWithValue("@TableName", tableName);
                SqlDataReader reader = command.ExecuteReader();
                dishPrices = new List<double>();
                while (reader.Read())
                {
                    lstDishOrdered.Items.Add("DishName: " + reader["DishName"] + " - Qty: " + reader["Qty"]);
                    //subtotal += (double.Parse(reader["Qty"].ToString()) * double.Parse(reader["DishPrice"].ToString()));
                    dishPrices.Add(double.Parse(reader["Qty"].ToString()) * double.Parse(reader["DishPrice"].ToString()));
                }
                cnn.Close();

                subtotal = dishPrices.Sum();
                txtEmpName.Text = employeeName;
                txtSubtotal.Text = subtotal.ToString();
                double tax = Math.Round(0.13 * subtotal, 2);
                txtTax.Text = tax.ToString();
                double total = subtotal + tax;
                txtTotal.Text = total.ToString();
            }
            catch (Exception ex)
            {
            }
        }


        /// <summary>
        /// This button returns the form to the main form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// This button sets the table to empty and deletes all orders associated with this table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPay_Click(object sender, EventArgs e)
        {
            Order.DeleteOrders(tableName);
            SqlConnection conn = DB.DBConn.SaylnConn();
            SqlCommand command;
            string queryString = $"UPDATE dbo.Tables SET TableStatus = 'empty' WHERE TableName = @TableName;";
            try
            {
                conn.Open();
                command = new SqlCommand(queryString, conn);
                command.Parameters.AddWithValue("@TableName", tableName);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in connection ! {ex.ToString()}");
            }
            finally
            {
                conn.Close();
            }
            this.Close();
        }

        /// <summary>
        /// This updates the list box with all the food orders.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateListBox(object sender, EventArgs e)
        {
            lstDishOrdered.Items.Clear();

            SqlConnection conn = DB.DBConn.SaylnConn();
            SqlCommand command;
            try
            {
                conn.Open();
                string queryString = @"  
                    SELECT b.DishID, SUM(Quantity) as Qty, MAX(DishName) as DishName
                    FROM Orders a
                    INNER JOIN OrderDish b on a.OrderID = b.OrderID
                    INNER JOIN Dishes c on b.DishID = c.DishID
                    WHERE TableName = @TableName
                    GROUP BY b.DISHID";

                command = new SqlCommand(queryString, conn);
                command.Parameters.AddWithValue("@TableName", tableName);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lstDishOrdered.Items.Add("DishName: " + reader["DishName"] + " - Qty: " + reader["Qty"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in connection ! {ex.ToString()}");
            }
            finally
            {
                conn.Close();
            }
        }


        /// <summary>
        /// This changes the amount of discount based on the value of the combobox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            double subtotal = double.Parse(txtSubtotal.Text);

            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
            double discount = service.GetDiscount(cbxDiscount.SelectedItem.ToString());
            subtotal = subtotal * discount;

            double tax = Math.Round(0.13 * subtotal, 2);
            txtTax.Text = tax.ToString();
            double total = Math.Round(subtotal + tax, 2);
            txtTotal.Text = total.ToString();

        }
    }
}