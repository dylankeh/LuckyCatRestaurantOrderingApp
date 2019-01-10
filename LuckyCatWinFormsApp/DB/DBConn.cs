using System.Data.SqlClient;

namespace LuckyCatWinFormsApp.DB
{
    /// <summary>
    /// This class that warp a database connection string
    /// </summary>
    class DBConn
    {
        //Created: Emerald      Last modified: Emerald
        public static SqlConnection SaylnConn()
        {
            //Kevin's connection
            //return new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LuckyCatDB;User Id=sa;Password=Password1!;");

            //Phoenix's connection
            return new SqlConnection("Data Source=7CCC;Initial Catalog=LuckyCatDB;Integrated Security=SSPI;Persist Security Info=False");

            //Emerald's connection
            //return new SqlConnection("Data Source=DESKTOP-ADDLFPG;Initial Catalog=LuckyCatDB;Integrated Security=SSPI;Persist Security Info=False");
        }
    }
}
