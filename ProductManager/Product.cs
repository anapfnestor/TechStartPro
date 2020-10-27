using SQLDatabase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager
{
    public class Product
    {
        public string name { get; set; }
        public string description { get; set; }
        public double value { get; set; }
        public DataTable Categories { get; set; }


        public bool insertProduct()
        {
            
            DatabaseConnect.OpenSqlConnection();

            SqlCommand sqlQuery = new SqlCommand("spInsertNewProduct", DatabaseConnect.sqlConn);

            sqlQuery.CommandType = CommandType.StoredProcedure;
            sqlQuery.Parameters.AddWithValue("@pCategoryId", Categories);
            sqlQuery.Parameters.AddWithValue("@pStrName", name);
            sqlQuery.Parameters.AddWithValue("@pStrDescription", description);
            sqlQuery.Parameters.AddWithValue("@pDecValue", value);

            var result = sqlQuery.ExecuteNonQuery();

            DatabaseConnect.CloseSqlConnection();

            if (result > 0)
                return true;
            else
                return false;

            //return false;
        }

        public DataTable readProducts()
        {
            var dtProducts = new DataTable();

            DatabaseConnect.OpenSqlConnection();

            var dataAdapter = new SqlDataAdapter("exec spReadProducts", DatabaseConnect.sqlConn);

            new SqlCommandBuilder(dataAdapter);

            dataAdapter.Fill(dtProducts);

            DatabaseConnect.CloseSqlConnection();

            return dtProducts;

        }

        public DataTable readOneProduct(string ProductCode)
        {
            var dtProduct = new DataTable();

            DatabaseConnect.OpenSqlConnection();

            var dataAdapter = new SqlDataAdapter("select * from tbProduct where intProdId =" + ProductCode , DatabaseConnect.sqlConn);

            new SqlCommandBuilder(dataAdapter);

            dataAdapter.Fill(dtProduct);

            DatabaseConnect.CloseSqlConnection();

            return dtProduct;
        }

    }
}
