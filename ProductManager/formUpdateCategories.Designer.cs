﻿namespace ProductManager
{
    partial class formUpdateCategories
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
            this.grpSelectOption = new System.Windows.Forms.GroupBox();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCSVFile = new System.Windows.Forms.Label();
            this.grpSelectOption.SuspendLayout();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSelectOption
            // 
            this.grpSelectOption.Controls.Add(this.lblCSVFile);
            this.grpSelectOption.Controls.Add(this.button1);
            this.grpSelectOption.Controls.Add(this.textBox1);
            this.grpSelectOption.Location = new System.Drawing.Point(7, 24);
            this.grpSelectOption.Name = "grpSelectOption";
            this.grpSelectOption.Size = new System.Drawing.Size(785, 419);
            this.grpSelectOption.TabIndex = 0;
            this.grpSelectOption.TabStop = false;
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbClose});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(800, 25);
            this.tsMenu.TabIndex = 3;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(271, 200);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblCSVFile
            // 
            this.lblCSVFile.AutoSize = true;
            this.lblCSVFile.Location = new System.Drawing.Point(206, 203);
            this.lblCSVFile.Name = "lblCSVFile";
            this.lblCSVFile.Size = new System.Drawing.Size(59, 13);
            this.lblCSVFile.TabIndex = 2;
            this.lblCSVFile.Text = "Choose file";
            // 
            // formUpdateCategories
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.grpSelectOption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formUpdateCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.grpSelectOption.ResumeLayout(false);
            this.grpSelectOption.PerformLayout();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSelectOption;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.Label lblCSVFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

