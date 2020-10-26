namespace ProductManager
{
    partial class formAddEditProduct
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.grpViewProduct = new System.Windows.Forms.GroupBox();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.clbCategory = new System.Windows.Forms.CheckedListBox();
            this.grpViewProduct.SuspendLayout();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(270, 214);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 9;
            this.lblCategory.Text = "Category";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(325, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.TabIndex = 8;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(285, 155);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(34, 13);
            this.lblValue.TabIndex = 7;
            this.lblValue.Text = "Value";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(325, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(325, 181);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(259, 184);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(284, 127);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(35, 13);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Name";
            // 
            // grpViewProduct
            // 
            this.grpViewProduct.Controls.Add(this.clbCategory);
            this.grpViewProduct.Controls.Add(this.lblCategory);
            this.grpViewProduct.Controls.Add(this.textBox3);
            this.grpViewProduct.Controls.Add(this.lblValue);
            this.grpViewProduct.Controls.Add(this.textBox2);
            this.grpViewProduct.Controls.Add(this.textBox1);
            this.grpViewProduct.Controls.Add(this.lblDescription);
            this.grpViewProduct.Controls.Add(this.lblProductName);
            this.grpViewProduct.Location = new System.Drawing.Point(8, 29);
            this.grpViewProduct.Name = "grpViewProduct";
            this.grpViewProduct.Size = new System.Drawing.Size(785, 417);
            this.grpViewProduct.TabIndex = 7;
            this.grpViewProduct.TabStop = false;
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbClose});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(800, 25);
            this.tsMenu.TabIndex = 8;
            this.tsMenu.Text = "Menu";
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = global::ProductManager.Properties.Resources.icons8_salvar_30;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "Save";
            this.tsbSave.ToolTipText = "Save";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClose.Image = global::ProductManager.Properties.Resources.noun_Close_109090;
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(23, 22);
            this.tsbClose.Text = "Close current window";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // clbCategory
            // 
            this.clbCategory.FormattingEnabled = true;
            this.clbCategory.Location = new System.Drawing.Point(325, 214);
            this.clbCategory.Name = "clbCategory";
            this.clbCategory.Size = new System.Drawing.Size(200, 79);
            this.clbCategory.TabIndex = 10;
            // 
            // formAddEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.grpViewProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAddEditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formAddEditProduct";
            this.grpViewProduct.ResumeLayout(false);
            this.grpViewProduct.PerformLayout();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox grpViewProduct;
        private System.Windows.Forms.CheckedListBox clbCategory;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbClose;
    }
}