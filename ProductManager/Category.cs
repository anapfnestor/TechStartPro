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

        public bool saveCategoriesDatabase(string csvPath)
        {
            var Categories = readCSV(csvPath);

            DatabaseConnect.OpenSqlConnection();

            SqlCommand sqlQuery = new SqlCommand("spInsertCategory", DatabaseConnect.sqlConn);

            sqlQuery.CommandType = CommandType.StoredProcedure;
            sqlQuery.Parameters.AddWithValue("@pCategoryNames", Categories);
            var result = sqlQuery.ExecuteNonQuery();
            DatabaseConnect.CloseSqlConnection();
            if (result == -1)
                return true;
            else
                return false;
        }

        public DataTable readCategories()
        {
            var dtCategories = new DataTable();

            DatabaseConnect.OpenSqlConnection();

            var dataAdapter = new SqlDataAdapter("SELECT intCategoryId as Code, strName as Name FROM tbCategory ", DatabaseConnect.sqlConn);

            new SqlCommandBuilder(dataAdapter);

            dataAdapter.Fill(dtCategories);

            DatabaseConnect.CloseSqlConnection();

            return dtCategories;

        }

        public DataTable readCategoriesOneProduct(string productCode)
        {
            var dtCategories = new DataTable();

            DatabaseConnect.OpenSqlConnection();

            var dataAdapter = new SqlDataAdapter("SELECT intCategoryId as CategoryCode FROM tbProductCategory where intProdId = " + productCode, DatabaseConnect.sqlConn);

            new SqlCommandBuilder(dataAdapter);

            dataAdapter.Fill(dtCategories);

            DatabaseConnect.CloseSqlConnection();

            return dtCategories;
        }
    }
}
