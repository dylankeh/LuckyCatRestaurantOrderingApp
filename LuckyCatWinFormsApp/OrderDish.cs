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
    /// This is the form used to place orders for a specific table.
    /// 
    /// Created By: Kevin
    /// </summary>
    public partial class OrderDish : Form
    {
        int OrderID;
        string tableName;
        string employeeID;

        /// <summary>
        /// This form uses all methods using this table and the employee to created it.
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="employeeID"></param>
        public OrderDish(string tableName, string employeeID)
        {
            InitializeComponent();
            this.tableName = tableName;
            this.employeeID = employeeID;
        }

        /// <summary>
        /// This creates a new order in the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderDish_Load_1(object sender, EventArgs e)
        {
            try
            {
                OrderID = Order.CreateNewOrder(tableName, employeeID);
                cmbDish.Items.Clear();
                FillComboBox(sender, e);
                UpdateListBox(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in connection ! {ex.ToString()}");
                this.Close();
            }
        }

        /// <summary>
        /// This adds a new dish to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddDish_Click(object sender, EventArgs e)
        {
            int qty;
            if (cmbDish.SelectedItem != null && int.TryParse(txtQty.Text, out qty) && qty > 0)
            {
                string DishName = cmbDish.SelectedItem.ToString();
                Order.AddDish(OrderID, DishName, qty);
            }
            else if (cmbDish.SelectedItem == null)
            {
                MessageBox.Show("Please select a dish!");
            }
            else
            {
                MessageBox.Show("Quantity must be a positive integer.");
            }
            UpdateListBox(sender, e);
        }


        /// <summary>
        /// In case of a mistake, this clears all items from the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            Order.Clear(OrderID);
            UpdateListBox(sender, e);
        }

        /// <summary>
        /// This submits the order and returns to the main form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// This changes the image based on what dish is seleceted.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbDish_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeImage(sender, e);
        }

        /// <summary>
        /// This changes the image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeImage(object sender, EventArgs e)
        {
            switch (cmbDish.SelectedItem)
            {
                case "Broccoli":
                    DishImage.Image = Properties.Resources.Broccoli;
                    break;
                case "Chicken":
                    DishImage.Image = Properties.Resources.Chicken;
                    break;
                case "Rice":
                    DishImage.Image = Properties.Resources.Rice;
                    break;
                case "Potato":
                    DishImage.Image = Properties.Resources.Potatoes;
                    break;
                case "Pork":
                    DishImage.Image = Properties.Resources.Pork;
                    break;
            }
        }

        /// <summary>
        /// This fills the combobox with all the dish items.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FillComboBox(object sender, EventArgs e)
        {
            SqlConnection cnn = DB.DBConn.SaylnConn();
            SqlCommand command;
            try
            {
                cnn.Open();
                string queryString = "select * from Dishes";

                command = new SqlCommand(queryString, cnn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbDish.Items.Add(reader["DishName"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in connection ! {ex.ToString()}");
            }
            finally
            {
                cnn.Close();
            }
        }

        /// <summary>
        /// This adds all the dish items to the list box whenever they are added.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateListBox(object sender, EventArgs e)
        {
            lstDishOrdered.Items.Clear();
            lstDishOrdered.Items.Add("---------------Current Order---------------");
            SqlConnection cnn = DB.DBConn.SaylnConn();
            SqlCommand command;
            try
            {
                cnn.Open();
                string queryString = @"  
                    SELECT b.DishID, SUM(Quantity) as Qty, MAX(DishName) as DishName
                    FROM Orders a
                    INNER JOIN OrderDish b on a.OrderID = b.OrderID
                    INNER JOIN Dishes c on b.DishID = c.DishID
                    WHERE a.OrderID = @OrderID
                    GROUP BY b.DISHID";

                command = new SqlCommand(queryString, cnn);
                command.Parameters.AddWithValue("@OrderID", OrderID);
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
                cnn.Close();
            }
        }
    }
}
