namespace ProductManager
{
    partial class formViewManageProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.grpViewProduct = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tsMenu.SuspendLayout();
            this.grpViewProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbEdit,
            this.tsbDelete,
            this.tsbClose});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(800, 25);
            this.tsMenu.TabIndex = 5;
            this.tsMenu.Text = " ";
            // 
            // grpViewProduct
            // 
            this.grpViewProduct.Controls.Add(this.button1);
            this.grpViewProduct.Controls.Add(this.textBox4);
            this.grpViewProduct.Controls.Add(this.label4);
            this.grpViewProduct.Controls.Add(this.textBox3);
            this.grpViewProduct.Controls.Add(this.label3);
            this.grpViewProduct.Controls.Add(this.textBox2);
            this.grpViewProduct.Controls.Add(this.textBox1);
            this.grpViewProduct.Controls.Add(this.label2);
            this.grpViewProduct.Controls.Add(this.label1);
            this.grpViewProduct.Controls.Add(this.gridProducts);
            this.grpViewProduct.Location = new System.Drawing.Point(8, 23);
            this.grpViewProduct.Name = "grpViewProduct";
            this.grpViewProduct.Size = new System.Drawing.Size(785, 419);
            this.grpViewProduct.TabIndex = 6;
            this.grpViewProduct.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // gridProducts
            // 
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.Location = new System.Drawing.Point(20, 70);
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridProducts.Size = new System.Drawing.Size(745, 330);
            this.gridProducts.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(333, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(62, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(193, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(62, 41);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(193, 20);
            this.textBox3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Value";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(333, 41);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(193, 20);
            this.textBox4.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Category";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(537, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = global::ProductManager.Properties.Resources.icons8_adicionar_coluna_30;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd.Text = "Add new product";
            this.tsbAdd.ToolTipText = "Add new product";
            // 
            // tsbEdit
            // 
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEdit.Image = global::ProductManager.Properties.Resources.icons8_editar_24;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(23, 22);
            this.tsbEdit.Text = "Edit product";
            this.tsbEdit.ToolTipText = "Edit product";
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = global::ProductManager.Properties.Resources.icons8_apagar_para_sempre_24;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete.Text = "Delete product";
            this.tsbDelete.ToolTipText = "Delete product";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClose.Image = global::ProductManager.Properties.Resources.noun_Close_109090;
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(23, 22);
            this.tsbClose.Text = "Close current window";
            this.tsbClose.ToolTipText = "Close current window";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // formViewManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.grpViewProduct);
            this.Controls.Add(this.tsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formViewManageProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formViewManageProducts";
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.grpViewProduct.ResumeLayout(false);
            this.grpViewProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.GroupBox grpViewProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridProducts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}