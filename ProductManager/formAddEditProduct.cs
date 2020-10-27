using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManager
{
    public partial class formAddEditProduct : Form
    {
        public static string actionType { get; set; }

        public int productID { get; set; }


        public formAddEditProduct( int id)
        {
            InitializeComponent();
            if (id > 0)
            {
                txtID.Text = id.ToString();
            }
            
        }

        public void initVariables( string action, int id)
        {
            actionType = action;
            productID = id;
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            Form product = new formViewManageProducts();
            product.MdiParent = MDISingleton.instanciaMDI();
            product.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            product.Dock = DockStyle.Fill;
            product.Show();

            this.Dispose();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                DataTable dt = new DataTable();
                Product newProd = new Product();
                newProd.name = txtName.Text;
                newProd.description = txtDesc.Text;
                newProd.value = Convert.ToDouble( txtValue.Text);

                DataColumn column;
                DataRow row;
                //DataView view;

                // Create new DataColumn, set DataType, ColumnName and add to DataTable.
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.Int32");
                column.ColumnName = "id";
                dt.Columns.Add(column);

                //DataGridView

                //dt = (DataTable)gridCategory.DataSource;

                foreach (DataGridViewRow gridrow in gridCategory.Rows)
                {
                    if (Convert.ToBoolean(gridrow.Cells["chk"].EditedFormattedValue) )
                        //Convert.ToBoolean(gridrow.Cells["chk"].Value) == true
                    {
                        row = dt.NewRow();
                        row["id"] = gridrow.Cells["Code"].Value;
                        dt.Rows.Add(row);
                    }
                    
                   
                }

                //foreach ( DataGridViewRow row in gridCategory.Rows)
                //{
                //    if ( Convert.ToBoolean( row["chk"]) == true)
                //    {
                //        dt.NewRow();
                //        row["id"] = row["Id"];
                //    }
                //}
              

                newProd.Categories = dt;

                if (newProd.insertProduct())
                {
                    MessageBox.Show("Produto inserido com sucesso.");

                    tsbClose_Click( sender,  e);
                }

                
            }
        }

        private bool validateFields()
        {
            if (string.IsNullOrEmpty(txtName.Text) || !(txtName.Text is string))
            {
                MessageBox.Show("Please check the name field.");
                return false;
            }
            if (string.IsNullOrEmpty(txtDesc.Text) || !(txtDesc.Text is string))
            {
                MessageBox.Show("Please check the description field.");
                return false;
            }

            if (txtValue.Text.Contains(","))
            {
                MessageBox.Show("Please use the format ####.## to fill value field.");
                return false;
            }

            if (!double.TryParse(txtValue.Text, out double doubleValue))
            {
                MessageBox.Show("Please check the value field. It must be numeric.");
                return false;
            }

            if (gridCategory.Rows.Count <= 0)
            {
                MessageBox.Show("Select at least one category.");
                return false;
            }

            return true;
        }

        private void formAddEditProduct_Load(object sender, EventArgs e)
        {
            Category categories = new Category();
            var dtCategories = categories.readCategories();


            gridCategory.DataSource = dtCategories;

            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool);
            dgvCmb.Name = "chk";
            dgvCmb.HeaderText = "Select";
            dgvCmb.TrueValue = true;
            dgvCmb.FalseValue = false;
           
            gridCategory.Columns.Add(dgvCmb);

            if (txtID.Text!= "")
            {
                Product editProd = new Product();
                var dt = editProd.readOneProduct(txtID.Text);

                txtDesc.Text = dt.Rows[0]["strDescription"].ToString();
                txtName.Text = dt.Rows[0]["strName"].ToString();
                txtValue.Text = dt.Rows[0]["decValue"].ToString();
            }

            var categoriesCode = categories.readCategoriesOneProduct(txtID.Text);

            foreach (DataGridViewRow row in gridCategory.Rows)
            {
                foreach (DataRow id in categoriesCode.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chk"];
                    if (Convert.ToInt32(row.Cells["Code"].Value) == Convert.ToInt32(id["CategoryCode"]))
                        chk.Value = chk.TrueValue;
                    else
                        chk.Value = chk.FalseValue;


                }
                
            }
            gridCategory.CommitEdit(DataGridViewDataErrorContexts.Commit);

        }
    }
}
