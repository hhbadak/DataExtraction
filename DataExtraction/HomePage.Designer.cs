﻿namespace DataExtraction
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMI_file = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_transactions = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_categoryOperations = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_products = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSSL_userNameINFO = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSMI_customers = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_employees = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_orders = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_shippers = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_suppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_file,
            this.TSMI_transactions});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_file
            // 
            this.TSMI_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_exit});
            this.TSMI_file.Name = "TSMI_file";
            this.TSMI_file.Size = new System.Drawing.Size(51, 20);
            this.TSMI_file.Text = "Dosya";
            // 
            // TSMI_exit
            // 
            this.TSMI_exit.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_exit.Image")));
            this.TSMI_exit.Name = "TSMI_exit";
            this.TSMI_exit.Size = new System.Drawing.Size(104, 22);
            this.TSMI_exit.Text = "Kapat";
            this.TSMI_exit.Click += new System.EventHandler(this.TSMI_exit_Click);
            // 
            // TSMI_transactions
            // 
            this.TSMI_transactions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_categoryOperations,
            this.toolStripSeparator1,
            this.TSMI_products,
            this.toolStripSeparator2,
            this.TSMI_customers,
            this.toolStripSeparator3,
            this.TSMI_employees,
            this.toolStripSeparator4,
            this.TSMI_orders,
            this.toolStripSeparator5,
            this.TSMI_shippers,
            this.toolStripSeparator6,
            this.TSMI_suppliers});
            this.TSMI_transactions.Name = "TSMI_transactions";
            this.TSMI_transactions.Size = new System.Drawing.Size(60, 20);
            this.TSMI_transactions.Text = "İşlemler";
            // 
            // TSMI_categoryOperations
            // 
            this.TSMI_categoryOperations.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_categoryOperations.Image")));
            this.TSMI_categoryOperations.Name = "TSMI_categoryOperations";
            this.TSMI_categoryOperations.Size = new System.Drawing.Size(180, 22);
            this.TSMI_categoryOperations.Text = "Kategoriler";
            this.TSMI_categoryOperations.Click += new System.EventHandler(this.TSMI_categoryOperations_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // TSMI_products
            // 
            this.TSMI_products.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_products.Image")));
            this.TSMI_products.Name = "TSMI_products";
            this.TSMI_products.Size = new System.Drawing.Size(180, 22);
            this.TSMI_products.Text = "Ürünler";
            this.TSMI_products.Click += new System.EventHandler(this.TSMI_products_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSL_userNameINFO});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            // 
            // TSSL_userNameINFO
            // 
            this.TSSL_userNameINFO.Name = "TSSL_userNameINFO";
            this.TSSL_userNameINFO.Size = new System.Drawing.Size(0, 17);
            // 
            // TSMI_customers
            // 
            this.TSMI_customers.Name = "TSMI_customers";
            this.TSMI_customers.Size = new System.Drawing.Size(180, 22);
            this.TSMI_customers.Text = "Müşteriler";
            // 
            // TSMI_employees
            // 
            this.TSMI_employees.Name = "TSMI_employees";
            this.TSMI_employees.Size = new System.Drawing.Size(180, 22);
            this.TSMI_employees.Text = "Çalışanlar";
            // 
            // TSMI_orders
            // 
            this.TSMI_orders.Name = "TSMI_orders";
            this.TSMI_orders.Size = new System.Drawing.Size(180, 22);
            this.TSMI_orders.Text = "Siparişler";
            // 
            // TSMI_shippers
            // 
            this.TSMI_shippers.Name = "TSMI_shippers";
            this.TSMI_shippers.Size = new System.Drawing.Size(180, 22);
            this.TSMI_shippers.Text = "Nakliyeciler";
            // 
            // TSMI_suppliers
            // 
            this.TSMI_suppliers.Name = "TSMI_suppliers";
            this.TSMI_suppliers.Size = new System.Drawing.Size(180, 22);
            this.TSMI_suppliers.Text = "Tedarikçiler";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(177, 6);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_file;
        private System.Windows.Forms.ToolStripMenuItem TSMI_exit;
        private System.Windows.Forms.ToolStripMenuItem TSMI_transactions;
        private System.Windows.Forms.ToolStripMenuItem TSMI_categoryOperations;
        private System.Windows.Forms.ToolStripMenuItem TSMI_products;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TSSL_userNameINFO;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem TSMI_customers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem TSMI_employees;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem TSMI_orders;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem TSMI_shippers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem TSMI_suppliers;
    }
}