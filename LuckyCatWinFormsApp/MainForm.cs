using LuckyCatWinFormsApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LuckyCatWinFormsApp
{
    /// <summary>
    /// This is the Main page for the employee use
    /// </summary>
    /// Created: Emerald      Last modified: Emerald
    public partial class MainForm : Form
    {
        SqlConnection conn = DB.DBConn.SaylnConn();
        SqlCommand command;
        string queryString;
        Employee employee;

        List<Table> lTable = new List<Table>();

        /// <summary>
        /// Show all the function employee can use
        /// </summary>
        /// <param name="employee">logined employee</param>
        public MainForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;

            if (!employee.Permission.Equals("A"))
            {
                this.btnNewUser.Hide();
            }
        }        

        /// <summary>
        /// update the liastview every action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateTableList(object sender, EventArgs e)
        {
            queryString = "SELECT * FROM dbo.Tables;";
            try
            {
                conn.Open();
                command = new SqlCommand(queryString, conn);
                SqlDataReader reader = command.ExecuteReader();

                int index = 0;
                lvTable.Items.Clear();
                while (reader.Read())
                {
                    Table table = new Table(reader["TableName"].ToString(), reader["TableStatus"].ToString());
                    lTable.Add(table);
                    lvTable.Items.Add(reader["TableName"].ToString());
                    if (reader["TableStatus"].ToString() == "empty")
                    {
                        lvTable.Items[index].ImageIndex = 0;
                    }
                    else
                    {
                        lvTable.Items[index].ImageIndex = 1;
                    }
                    index++;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in connection ! {ex.ToString()}");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.lblEmployee.Text += employee.EmployeeName + "!";
            UpdateTableList(sender, e);
        }

        /// <summary>
        /// this is click button to create a new user only admin can use it 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewUser_Click(object sender, EventArgs e)
        {
            if (!employee.Permission.Equals("A"))
            {
                MessageBox.Show("You do not have permission to create new user.");
            }
            else
            {
                CreateUserForm userform = new CreateUserForm();
                userform.ShowDialog();
            }
        }
        /// <summary>
        /// click begin button to start service 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBeginServer_Click(object sender, EventArgs e)
        {
            if (lvTable.SelectedItems.Count != 0)
            {
                string tableName = this.lvTable.SelectedItems[0].SubItems[0].Text;
                queryString = "SELECT TableStatus FROM dbo.Tables WHERE TableName = @TableName;";

                try
                {
                    conn.Open();
                    command = new SqlCommand(queryString, conn);
                    command.Parameters.AddWithValue("@TableName", tableName);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string tableStatus = reader["TableStatus"].ToString();
                        if (tableStatus.Equals("occupied"))
                        {
                            conn.Close();
                            MessageBox.Show("This table occupied, please choose another");
                        }
                        else
                        {
                            conn.Close();
                            queryString = "UPDATE dbo.Tables SET TableStatus = 'occupied' WHERE TableName = @TableName";
                            try
                            {
                                conn.Open();
                                command = new SqlCommand(queryString, conn);
                                command.Parameters.AddWithValue("@TableName", tableName);
                                command.ExecuteNonQuery();
                                conn.Close();

                                this.lvTable.SelectedItems[0].ImageIndex = 1;
                                this.lvTable.SelectedIndices.Clear();
                                //this.btnBeginServer.Enabled = false;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error in connection ! {ex.ToString()}");
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error in connection ! {ex.ToString()}");
                }
            }
            else
            {
                MessageBox.Show("Please choose a table!");
            }
        }
        /// <summary>
        /// click End Server button to end server and change table status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEndServer_Click(object sender, EventArgs e)
        {
            string tableName = this.lvTable.SelectedItems[0].SubItems[0].Text;

            if (lvTable.SelectedItems.Count != 0)
            {
                try
                {
                    conn.Open();
                    queryString = @"
                        SELECT * FROM Orders a
                        INNER JOIN OrderDish b on a.OrderID=b.OrderID
                        WHERE a.TableName=@TableName";

                    command = new SqlCommand(queryString, conn);
                    command.Parameters.AddWithValue("@TableName", tableName);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Cannot end server! This table has already placed some orders!");
                    }
                    else
                    {
                        conn.Close();
                        queryString = "UPDATE dbo.Tables SET TableStatus = 'empty' WHERE TableName = @TableName";
                        try
                        {
                            conn.Open();
                            command = new SqlCommand(queryString, conn);
                            command.Parameters.AddWithValue("@TableName", tableName);
                            command.ExecuteNonQuery();
                            conn.Close();

                            this.lvTable.SelectedItems[0].ImageIndex = 0;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error in connection ! {ex.ToString()}");
                        }
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error in connection ! {ex.ToString()}");
                }
                finally
                {
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please choose a table!");
            }
        }

        /// <summary>
        /// When customer want to check out 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (lvTable.SelectedItems.Count != 0)
            {
                string tableName = lvTable.SelectedItems[0].SubItems[0].Text;
                SqlConnection cnn = DB.DBConn.SaylnConn();
                SqlCommand command;
                try
                {
                    cnn.Open();
                    string queryString = "select * from Tables WHERE TableName = @TableName;";

                    command = new SqlCommand(queryString, cnn);
                    command.Parameters.AddWithValue("@TableName", tableName);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader["TableStatus"].ToString() == "occupied")
                        {
                            Checkout checkoutOrder = new Checkout(tableName, employee);
                            checkoutOrder.ShowDialog();
                            UpdateTableList(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Table is empty! Please Begin first.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Table is not valid");
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
            else
            {
                MessageBox.Show("Please choose table!");
            }
        }

        /// <summary>
        /// Logout system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// click this button to order dish after start service
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrderDish_Click(object sender, EventArgs e)
        {
            if (lvTable.SelectedItems.Count != 0)
            {
                string tableName = lvTable.SelectedItems[0].SubItems[0].Text;
                SqlConnection cnn = DB.DBConn.SaylnConn();
                SqlCommand command;
                try
                {
                    cnn.Open();
                    string queryString = "select * from Tables WHERE TableName = @TableName;";

                    command = new SqlCommand(queryString, cnn);
                    command.Parameters.AddWithValue("@TableName", tableName);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader["TableStatus"].ToString() == "occupied")
                        {
                            OrderDish orderdish = new OrderDish(tableName, employee.EmployeeID);
                            orderdish.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Table is empty! Please Begin first.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Table is not valid");
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
            else
            {
                MessageBox.Show("Please choose table!");
            }
        }        
    }
}
