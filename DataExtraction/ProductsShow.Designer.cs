namespace DataExtraction
{
    partial class ProductsShow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsShow));
            this.dgv_productList = new System.Windows.Forms.DataGridView();
            this.gb_productInformation = new System.Windows.Forms.GroupBox();
            this.cb_isFastProduct = new System.Windows.Forms.CheckBox();
            this.cb_discontinued = new System.Windows.Forms.CheckBox();
            this.btn_categoryAdd = new System.Windows.Forms.Button();
            this.btn_supplierAdd = new System.Windows.Forms.Button();
            this.cb_supplier = new System.Windows.Forms.ComboBox();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_barcode = new System.Windows.Forms.TextBox();
            this.tb_quantityPerUnit = new System.Windows.Forms.TextBox();
            this.tb_productName = new System.Windows.Forms.TextBox();
            this.tb_stock = new System.Windows.Forms.TextBox();
            this.tb_reorderLevel = new System.Windows.Forms.TextBox();
            this.tb_unitPrice = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_update = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productList)).BeginInit();
            this.gb_productInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_productList
            // 
            this.dgv_productList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_productList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_productList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productList.Location = new System.Drawing.Point(3, 195);
            this.dgv_productList.Name = "dgv_productList";
            this.dgv_productList.Size = new System.Drawing.Size(795, 253);
            this.dgv_productList.TabIndex = 0;
            this.dgv_productList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_productList_MouseDown);
            // 
            // gb_productInformation
            // 
            this.gb_productInformation.Controls.Add(this.cb_isFastProduct);
            this.gb_productInformation.Controls.Add(this.cb_discontinued);
            this.gb_productInformation.Controls.Add(this.btn_categoryAdd);
            this.gb_productInformation.Controls.Add(this.btn_supplierAdd);
            this.gb_productInformation.Controls.Add(this.cb_supplier);
            this.gb_productInformation.Controls.Add(this.cb_category);
            this.gb_productInformation.Controls.Add(this.tb_ID);
            this.gb_productInformation.Controls.Add(this.tb_barcode);
            this.gb_productInformation.Controls.Add(this.tb_quantityPerUnit);
            this.gb_productInformation.Controls.Add(this.tb_productName);
            this.gb_productInformation.Controls.Add(this.tb_stock);
            this.gb_productInformation.Controls.Add(this.tb_reorderLevel);
            this.gb_productInformation.Controls.Add(this.tb_unitPrice);
            this.gb_productInformation.Controls.Add(this.btn_update);
            this.gb_productInformation.Controls.Add(this.btn_add);
            this.gb_productInformation.Controls.Add(this.pb_image);
            this.gb_productInformation.Controls.Add(this.label11);
            this.gb_productInformation.Controls.Add(this.label10);
            this.gb_productInformation.Controls.Add(this.label9);
            this.gb_productInformation.Controls.Add(this.label8);
            this.gb_productInformation.Controls.Add(this.label6);
            this.gb_productInformation.Controls.Add(this.label5);
            this.gb_productInformation.Controls.Add(this.label7);
            this.gb_productInformation.Controls.Add(this.label3);
            this.gb_productInformation.Controls.Add(this.label4);
            this.gb_productInformation.Controls.Add(this.label2);
            this.gb_productInformation.Controls.Add(this.label1);
            this.gb_productInformation.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_productInformation.Location = new System.Drawing.Point(13, 13);
            this.gb_productInformation.Name = "gb_productInformation";
            this.gb_productInformation.Size = new System.Drawing.Size(775, 176);
            this.gb_productInformation.TabIndex = 1;
            this.gb_productInformation.TabStop = false;
            this.gb_productInformation.Text = "Ürün Bilgileri";
            // 
            // cb_isFastProduct
            // 
            this.cb_isFastProduct.AutoSize = true;
            this.cb_isFastProduct.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_isFastProduct.Location = new System.Drawing.Point(471, 152);
            this.cb_isFastProduct.Name = "cb_isFastProduct";
            this.cb_isFastProduct.Size = new System.Drawing.Size(54, 19);
            this.cb_isFastProduct.TabIndex = 13;
            this.cb_isFastProduct.Text = "Ekle";
            this.cb_isFastProduct.UseVisualStyleBackColor = true;
            // 
            // cb_discontinued
            // 
            this.cb_discontinued.AutoSize = true;
            this.cb_discontinued.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_discontinued.Location = new System.Drawing.Point(471, 129);
            this.cb_discontinued.Name = "cb_discontinued";
            this.cb_discontinued.Size = new System.Drawing.Size(72, 19);
            this.cb_discontinued.TabIndex = 12;
            this.cb_discontinued.Text = "Satışta";
            this.cb_discontinued.UseVisualStyleBackColor = true;
            // 
            // btn_categoryAdd
            // 
            this.btn_categoryAdd.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_categoryAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_categoryAdd.FlatAppearance.BorderSize = 0;
            this.btn_categoryAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_categoryAdd.ForeColor = System.Drawing.Color.White;
            this.btn_categoryAdd.Location = new System.Drawing.Point(296, 96);
            this.btn_categoryAdd.Name = "btn_categoryAdd";
            this.btn_categoryAdd.Size = new System.Drawing.Size(25, 21);
            this.btn_categoryAdd.TabIndex = 5;
            this.btn_categoryAdd.Text = "+";
            this.btn_categoryAdd.UseVisualStyleBackColor = false;
            // 
            // btn_supplierAdd
            // 
            this.btn_supplierAdd.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_supplierAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_supplierAdd.FlatAppearance.BorderSize = 0;
            this.btn_supplierAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supplierAdd.ForeColor = System.Drawing.Color.White;
            this.btn_supplierAdd.Location = new System.Drawing.Point(296, 123);
            this.btn_supplierAdd.Name = "btn_supplierAdd";
            this.btn_supplierAdd.Size = new System.Drawing.Size(25, 21);
            this.btn_supplierAdd.TabIndex = 7;
            this.btn_supplierAdd.Text = "+";
            this.btn_supplierAdd.UseVisualStyleBackColor = false;
            // 
            // cb_supplier
            // 
            this.cb_supplier.FormattingEnabled = true;
            this.cb_supplier.Location = new System.Drawing.Point(129, 123);
            this.cb_supplier.Name = "cb_supplier";
            this.cb_supplier.Size = new System.Drawing.Size(161, 23);
            this.cb_supplier.TabIndex = 6;
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(129, 96);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(161, 23);
            this.cb_category.TabIndex = 4;
            // 
            // tb_ID
            // 
            this.tb_ID.Enabled = false;
            this.tb_ID.Location = new System.Drawing.Point(129, 18);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(161, 21);
            this.tb_ID.TabIndex = 1;
            // 
            // tb_barcode
            // 
            this.tb_barcode.Location = new System.Drawing.Point(129, 44);
            this.tb_barcode.Name = "tb_barcode";
            this.tb_barcode.Size = new System.Drawing.Size(161, 21);
            this.tb_barcode.TabIndex = 2;
            // 
            // tb_quantityPerUnit
            // 
            this.tb_quantityPerUnit.Location = new System.Drawing.Point(471, 15);
            this.tb_quantityPerUnit.Name = "tb_quantityPerUnit";
            this.tb_quantityPerUnit.Size = new System.Drawing.Size(161, 21);
            this.tb_quantityPerUnit.TabIndex = 8;
            // 
            // tb_productName
            // 
            this.tb_productName.Location = new System.Drawing.Point(129, 70);
            this.tb_productName.Name = "tb_productName";
            this.tb_productName.Size = new System.Drawing.Size(161, 21);
            this.tb_productName.TabIndex = 3;
            // 
            // tb_stock
            // 
            this.tb_stock.Location = new System.Drawing.Point(471, 41);
            this.tb_stock.Name = "tb_stock";
            this.tb_stock.Size = new System.Drawing.Size(161, 21);
            this.tb_stock.TabIndex = 9;
            // 
            // tb_reorderLevel
            // 
            this.tb_reorderLevel.Location = new System.Drawing.Point(471, 67);
            this.tb_reorderLevel.Name = "tb_reorderLevel";
            this.tb_reorderLevel.Size = new System.Drawing.Size(161, 21);
            this.tb_reorderLevel.TabIndex = 10;
            // 
            // tb_unitPrice
            // 
            this.tb_unitPrice.Location = new System.Drawing.Point(471, 93);
            this.tb_unitPrice.Name = "tb_unitPrice";
            this.tb_unitPrice.Size = new System.Drawing.Size(161, 21);
            this.tb_unitPrice.TabIndex = 11;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add.Location = new System.Drawing.Point(557, 146);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "EKLE";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pb_image
            // 
            this.pb_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_image.Location = new System.Drawing.Point(638, 13);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(131, 157);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_image.TabIndex = 1;
            this.pb_image.TabStop = false;
            this.pb_image.Click += new System.EventHandler(this.pb_image_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(390, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Hızlı Satış";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(366, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Satış Durumu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(382, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Satış Fiyatı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(355, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Güvenlik Stoğu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(326, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Birim Başına Miktar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(36, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tedarikçi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(426, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Stok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(40, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(41, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Barkod No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(81, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_update,
            this.TSMI_delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 48);
            // 
            // TSMI_update
            // 
            this.TSMI_update.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_update.Image")));
            this.TSMI_update.Name = "TSMI_update";
            this.TSMI_update.Size = new System.Drawing.Size(116, 22);
            this.TSMI_update.Text = "Düzenle";
            this.TSMI_update.Click += new System.EventHandler(this.TSMI_update_Click);
            // 
            // TSMI_delete
            // 
            this.TSMI_delete.Image = ((System.Drawing.Image)(resources.GetObject("TSMI_delete.Image")));
            this.TSMI_delete.Name = "TSMI_delete";
            this.TSMI_delete.Size = new System.Drawing.Size(116, 22);
            this.TSMI_delete.Text = "Sil";
            this.TSMI_delete.Click += new System.EventHandler(this.TSMI_delete_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("MS Reference Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_update.Location = new System.Drawing.Point(557, 145);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "GÜNCELLE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // ProductsShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb_productInformation);
            this.Controls.Add(this.dgv_productList);
            this.Name = "ProductsShow";
            this.Text = "Products";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productList)).EndInit();
            this.gb_productInformation.ResumeLayout(false);
            this.gb_productInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_productList;
        private System.Windows.Forms.GroupBox gb_productInformation;
        private System.Windows.Forms.CheckBox cb_isFastProduct;
        private System.Windows.Forms.CheckBox cb_discontinued;
        private System.Windows.Forms.Button btn_categoryAdd;
        private System.Windows.Forms.Button btn_supplierAdd;
        private System.Windows.Forms.ComboBox cb_supplier;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_barcode;
        private System.Windows.Forms.TextBox tb_quantityPerUnit;
        private System.Windows.Forms.TextBox tb_productName;
        private System.Windows.Forms.TextBox tb_stock;
        private System.Windows.Forms.TextBox tb_reorderLevel;
        private System.Windows.Forms.TextBox tb_unitPrice;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_update;
        private System.Windows.Forms.ToolStripMenuItem TSMI_delete;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_update;
    }
}