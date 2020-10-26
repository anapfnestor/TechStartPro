using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LumenWorks.Framework.IO.Csv;
using System.IO;
using SQLDatabase;
using System.Data.SqlClient;

namespace ProductManager
{
    public class Category
    {
        public DataTable readCSV(string csvPath)
        {
            var csvTable = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(File.OpenRead(csvPath)), true))
            {
                csvTable.Load(csvReader);
            }

            return csvTable;
        }

        public void saveCategoriesDatabase(string csvPath)
        {
            var Categories = readCSV(csvPath);

            DatabaseConnect.OpenSqlConnection();

            SqlCommand sqlQuery = new SqlCommand("spInsertCategor", DatabaseConnect.sqlConn);

            sqlQuery.CommandType = CommandType.StoredProcedure;
            sqlQuery.Parameters.AddWithValue("@pCategoryNames", Categories);
            sqlQuery.ExecuteNonQuery();
            DatabaseConnect.CloseSqlConnection();

        }
    }
}
