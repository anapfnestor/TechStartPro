using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductManager;
using System.Data;

namespace ProductManagerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSaveCSVData()
        {
            Category productCategory = new Category();

            //productCategory.saveCategoriesDatabase(@"C:\projects\ProductManager\TechStartPro\Test Files\testCategory.csv");
            Assert.AreEqual(true, productCategory.saveCategoriesDatabase(@"C:\projects\ProductManager\TechStartPro\Test Files\testCategory.csv"));

            Assert.IsNotNull(productCategory.readCategories());
        }

        [TestMethod]
        public void TestReadCategories()
        {
            Category productCategory = new Category();

            Assert.IsNotNull(productCategory.readCategories());
        }

        [TestMethod]
        public void TestNewProduct()
        {
            Product newitem = new Product();
            newitem.name = "Cadeira";
            newitem.description = "Cadeira de escritório";
            newitem.value = 10.00;

            DataTable table = new DataTable();
            DataColumn column;
            DataRow row;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "id";
            table.Columns.Add(column);

            row = table.NewRow();
            row["id"] = 1;
            table.Rows.Add(row);

            row = table.NewRow();
            row["id"] = 2;
            table.Rows.Add(row);

            newitem.Categories = table;

            Assert.AreEqual(true, newitem.insertProduct());

            Assert.IsNotNull(newitem.readProducts());
        }

    }
}
