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
    public partial class formViewManageProducts : Form
    {
        public formViewManageProducts()
        {
            InitializeComponent();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            Form Menu = new formMenu();
            Menu.MdiParent = MDISingleton.instanciaMDI();
            Menu.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Menu.Dock = DockStyle.Fill;
            Menu.Show();

            this.Dispose();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            Form NewItem = new formAddEditProduct(0);
            NewItem.MdiParent = MDISingleton.instanciaMDI();
            NewItem.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            NewItem.Dock = DockStyle.Fill;
            NewItem.Show();

            this.Dispose();
        }

        private void formViewManageProducts_Load(object sender, EventArgs e)
        {
            Product prod = new Product();
            gridProducts.DataSource = prod.readProducts();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            
            Form EditItem = new formAddEditProduct(Convert.ToInt32(gridProducts.Rows[gridProducts.CurrentCell.RowIndex].Cells["Code"].Value));
            EditItem.MdiParent = MDISingleton.instanciaMDI();
            EditItem.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            EditItem.Dock = DockStyle.Fill;

            EditItem.Show();
            

            this.Dispose();
        }
    }
}
