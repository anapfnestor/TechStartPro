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
    public partial class formUpdateCategories : Form
    {
        public formUpdateCategories()
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
    }
}
