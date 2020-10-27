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
        public string actionType { get; set; }

        public string productID { get; set; }


        public formAddEditProduct( int id)
        {
            InitializeComponent();
            if (id > 0)
            {
                productID = id.ToString();
                actionType = "Edit";
            }
            
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
                Product Prod = new Product();
                Prod.name = txtName.Text;
                Prod.description = txtDesc.Text;
                Prod.value = Convert.ToDouble(txtValue.Text);

                DataColumn column;
                DataRow row;
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.Int32");
                column.ColumnName = "id";
                dt.Columns.Add(column);

                foreach (DataGridViewRow gridrow in gridCategory.Rows)
                {
                    if (Convert.ToBoolean(gridrow.Cells["chk"].EditedFormattedValue))
                    {
                        row = dt.NewRow();
                        row["id"] = gridrow.Cells["Code"].Value;
                        dt.Rows.Add(row);
                    }

                }

                Prod.Categories = dt;

                if (actionType != "Edit")
                {
                    

                    if (Prod.insertProduct())
                    {
                        MessageBox.Show("Produto inserido com sucesso.");

                        tsbClose_Click(sender, e);
                    }
                }
                else
                {
                    Prod.id = productID;

                    if (Prod.editProduct())
                    {
                        MessageBox.Show("Alterações salvas com sucesso.");

                        tsbClose_Click(sender, e);
                    }

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

            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();

            dgvCmb.ValueType = typeof(bool);
            dgvCmb.Name = "chk";
            dgvCmb.HeaderText = "Select";
            dgvCmb.TrueValue = true;
            dgvCmb.FalseValue = false;

            gridCategory.Columns.Add(dgvCmb);

            gridCategory.DataSource = dtCategories;
            if (actionType == "Edit")
            {
                

                Product editProd = new Product();
                var dt = editProd.readOneProduct(productID);

                txtDesc.Text = dt.Rows[0]["strDescription"].ToString();
                txtName.Text = dt.Rows[0]["strName"].ToString();
                txtValue.Text = dt.Rows[0]["decValue"].ToString();

                var categoriesCode = categories.readCategoriesOneProduct(productID);

                foreach (DataGridViewRow row in gridCategory.Rows)
                {
                    foreach (DataRow id in categoriesCode.Rows)
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["chk"];
                        if (Convert.ToInt32(row.Cells["Code"].Value) == Convert.ToInt32(id["CategoryCode"]))
                        {
                            chk.Value = chk.TrueValue;
                            gridCategory.CommitEdit(DataGridViewDataErrorContexts.Commit);
                        }                            
                        else
                            chk.Value = chk.FalseValue;

                    }

                }
            }

            
        }
    }
}
