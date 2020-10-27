using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openCSVFile = new OpenFileDialog();

            DialogResult dr = openCSVFile.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                if (Path.GetExtension(openCSVFile.FileName) != ".csv")
                {
                    MessageBox.Show("Por favor, selecione um arquivo CSV.");
                    txtChooseFile.Text = "";
                }
                else
                {
                    txtChooseFile.Text = openCSVFile.FileName;
                }
            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            Category prodCategory = new Category();
            
            if (prodCategory.saveCategoriesDatabase(txtChooseFile.Text) == true )
            {
                MessageBox.Show("Categorias salvas com sucesso.");
                tsbClose_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Não foi possivel salvar as categorias do arquivo.");
            }
            


            

        }
    }
}
