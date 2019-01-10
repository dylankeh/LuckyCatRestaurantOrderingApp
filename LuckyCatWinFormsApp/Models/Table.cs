using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyCatWinFormsApp.Models
{
    /// <summary>
    /// Table object to hold the table
    /// Created: Emerald      Last modified: Emerald
    /// </summary>
    class Table
    {
        public string TableName { get; set; }
        public string TableStatus { get; set; }

        public Table(string tableName, string tableStatus)
        {
            TableName = tableName;
            TableStatus = tableStatus;
        }
    }
}
