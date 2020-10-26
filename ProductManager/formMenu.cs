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
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tsbUpdateCategories_Click(object sender, EventArgs e)
        {
            Form Categories = new formUpdateCategories();
            Categories.MdiParent = MDISingleton.instanciaMDI();
            Categories.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Categories.Dock = DockStyle.Fill;
            Categories.Show();

            this.Dispose();
        }

        private void tsbProductsManager_Click(object sender, EventArgs e)
        {
            Form product = new formViewManageProducts();
            product.MdiParent = MDISingleton.instanciaMDI();
            product.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            product.Dock = DockStyle.Fill;
            product.Show();

            this.Dispose();
        }

       
    }
}
