using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using LuckyCatWinFormsApp.Models;

namespace LuckyCatWinFormsApp
{
    /// <summary>
    /// This form implements login function. It validates user's input as well.
    /// 
    /// Created by Qing Ge
    /// </summary>
    public partial class LoginForm : Form
    {
        SqlConnection conn;
        SqlCommand command;
        Employee employee;

        /// <summary>
        /// This initializes component.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This creates database connection.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_Load(object sender, EventArgs e)
        {
            conn = DB.DBConn.SaylnConn();
        }

        /// <summary>
        /// Login button will validate user input first before getting information from database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtID.Text == "" || this.txtPassword.Text == "")
                {
                    this.lblMessage.Text = "Please fill in both ID and Password";
                }
                else
                {
                    conn.Open();
                    string queryString = "select * from Employees where EmployeeID = @EmployeeID and Password = @Password";
                    command = new SqlCommand(queryString, conn);
                    command.Parameters.AddWithValue("@EmployeeID", int.Parse(this.txtID.Text));
                    command.Parameters.AddWithValue("@Password", this.txtPassword.Text);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string id = reader["EmployeeID"].ToString();
                        string name = reader["EmployeeName"].ToString();
                        string permission = reader["Permission"].ToString();

                        //if user logins successfully, it will store employee's information in an object
                        employee = new Employee(id, name, permission);

                        this.txtID.Text = "";
                        this.txtPassword.Text = "";
                        this.lblMessage.Text = "";
                        this.Hide();

                        //Pass this object to main form to display employee's name on it.
                        MainForm mainform = new MainForm(employee);
                        mainform.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        this.lblMessage.Text = "Error: Either user ID or password is wrong.";
                    }
                }
            }
            catch (FormatException ex)
            {
                this.lblMessage.Text = "Error: ID should be a number";
            }
            catch (Exception ex)
            {
                this.lblMessage.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}