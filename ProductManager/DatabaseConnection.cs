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

    public class DatabaseConnect
    {
        public static SqlConnection sqlConn = new SqlConnection("server=" + Environment.MachineName + @"\SQLEXPRESS; Database=Product;Integrated Security=SSPI;");

        public static void OpenSqlConnection()
        {
                        
            sqlConn.Open();

        }

        public static void CloseSqlConnection()
        {
            sqlConn.Close();
        }

    }

}
