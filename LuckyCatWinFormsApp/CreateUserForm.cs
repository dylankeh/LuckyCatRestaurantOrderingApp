using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LuckyCatWinFormsApp
{
    /// <summary>
    /// This form creates a new user and it will generate a unique ID for the new user to login
    /// 
    /// Created by: Qing Ge
    /// </summary>
    public partial class CreateUserForm : Form
    {
        SqlConnection cnn;
        SqlCommand command;

        /// <summary>
        /// This initializes component.
        /// </summary>
        public CreateUserForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This creates database connection.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateUserForm_Load(object sender, EventArgs e)
        {
            cnn = DB.DBConn.SaylnConn();
        }

        /// <summary>
        /// This button validates user input. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtName.Text == "" || this.txtPassword.Text == "" || this.txtPdConfirm.Text == "")
                {
                    this.lblMessage.Text = "Please fill in all the blanks";
                }
                else if (this.txtPassword.Text != this.txtPdConfirm.Text)
                {
                    this.lblMessage.Text = "Two passwords don't match";
                }
                else
                {
                    cnn.Open();
                    string queryString = "Insert into Employees(EmployeeName, Password) values(@EmployeeName, @Password)";
                    command = new SqlCommand(queryString, cnn);
                    command.Parameters.AddWithValue("@EmployeeName", this.txtName.Text);
                    command.Parameters.AddWithValue("@Password", this.txtPassword.Text);
                    int r = command.ExecuteNonQuery();
                    this.txtName.Text = "";
                    this.txtPassword.Text = "";
                    this.txtPdConfirm.Text = "";
                    this.lblMessage.Text = "";
                    cnn.Close();

                    cnn.Open();
                    queryString = "select MAX(EmployeeID) from Employees";
                    command = new SqlCommand(queryString, cnn);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        String autoID = reader[0].ToString();
                        MessageBox.Show("Your ID is: " + autoID);
                    }
                    else
                    {
                        this.lblMessage.Text = "ID failed to be generated";
                    }                    
                }
            }
            catch (Exception ex)
            {
                this.lblMessage.Text = ex.Message;
            }
            finally
            {
                cnn.Close();
            }
        }

        /// <summary>
        /// This button will close this window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}