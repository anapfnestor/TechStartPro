using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataTable = System.Data.DataTable;

namespace SQLDatabase
{

    public class connectionString
    {
        public static SqlConnection sqlConn = new SqlConnection("server=" + Environment.MachineName + @"\SQLEXPRESS; Database=Product;Integrated Security=SSPI;");
    }

    public class DatabaseConnect
    {
        
        public static void OpenSqlConnection()
        {
                        
            connectionString.sqlConn.Open();

        }

        public static void CloseSqlConnection()
        {
            connectionString.sqlConn.Close();
        }

    }

}
