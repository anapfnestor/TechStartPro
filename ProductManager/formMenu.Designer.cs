namespace ProductManager
{
    partial class formMenu
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
            this.tsbProductsManager = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdateCategories = new System.Windows.Forms.ToolStripButton();
            this.grpSelectOption = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tsMenu.SuspendLayout();
            this.grpSelectOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbProductsManager,
            this.tsbUpdateCategories});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(800, 25);
            this.tsMenu.TabIndex = 4;
            this.tsMenu.Text = "tsMenu";
            // 
            // tsbProductsManager
            // 
            this.tsbProductsManager.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbProductsManager.Image = global::ProductManager.Properties.Resources.icons8_visualizar_arquivo_26;
            this.tsbProductsManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProductsManager.Name = "tsbProductsManager";
            this.tsbProductsManager.Size = new System.Drawing.Size(23, 22);
            this.tsbProductsManager.Text = "View and manage products";
            this.tsbProductsManager.ToolTipText = "View and manage products";
            this.tsbProductsManager.Click += new System.EventHandler(this.tsbProductsManager_Click);
            // 
            // tsbUpdateCategories
            // 
            this.tsbUpdateCategories.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUpdateCategories.Image = global::ProductManager.Properties.Resources.icons8_fazer_upload_26;
            this.tsbUpdateCategories.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdateCategories.Name = "tsbUpdateCategories";
            this.tsbUpdateCategories.Size = new System.Drawing.Size(23, 22);
            this.tsbUpdateCategories.Text = "Update Product Categories";
            this.tsbUpdateCategories.Click += new System.EventHandler(this.tsbUpdateCategories_Click);
            // 
            // grpSelectOption
            // 
            this.grpSelectOption.Controls.Add(this.label1);
            this.grpSelectOption.Controls.Add(this.lblWelcome);
            this.grpSelectOption.Location = new System.Drawing.Point(8, 23);
            this.grpSelectOption.Name = "grpSelectOption";
            this.grpSelectOption.Size = new System.Drawing.Size(785, 419);
            this.grpSelectOption.TabIndex = 5;
            this.grpSelectOption.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please choose an option from the menu above";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Amiri", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(302, 136);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(181, 146);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.grpSelectOption);
            this.Controls.Add(this.tsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.grpSelectOption.ResumeLayout(false);
            this.grpSelectOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbProductsManager;
        private System.Windows.Forms.ToolStripButton tsbUpdateCategories;
        private System.Windows.Forms.GroupBox grpSelectOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWelcome;
    }
}