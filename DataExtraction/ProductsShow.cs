using DataAccessLayer;
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

namespace DataExtraction
{
    public partial class ProductsShow : Form
    {
        DataModel dm = new DataModel();
        int index;
        public ProductsShow()
        {
            InitializeComponent();
            index = -2;
        }

        private void Products_Load(object sender, EventArgs e)
        {
            btn_update.Visible = false;
            dgv_productList.DataSource = dm.productList();
            GridDoldur();

            cb_category.ValueMember = "CategoryID";
            cb_category.DisplayMember = "CategoryName";
            cb_category.DataSource = dm.GetCategories();

            cb_supplier.ValueMember = "ID";
            cb_supplier.DisplayMember = "companyName";
            cb_supplier.DataSource = dm.SupplierList();
        }
        private void GridDoldur()
        {
            List<Products> prod = dm.productList();
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Ürün Adı");
            dt.Columns.Add("Kategori");
            dt.Columns.Add("Tedarikçi");
            dt.Columns.Add("Stok");
            dt.Columns.Add("Fiyat");
            dt.Columns.Add("Satış Durum");

            for (int i = 0; i < prod.Count; i++)
            {
                DataRow r = dt.NewRow();
                r["ID"] = prod[i].ID;
                r["Ürün Adı"] = prod[i].productName;
                r["Kategori"] = prod[i].categoryName;
                r["Tedarikçi"] = prod[i].supplierName;
                r["Stok"] = prod[i].unitInStock;
                r["Fiyat"] = prod[i].unitPrice;
                r["Satış Durum"] = prod[i].discontinued ? "Satışta Değil " : "Satışta" ;
                dt.Rows.Add(r);
            }
            dgv_productList.DataSource = dt;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Products model = new Products();
            model.productName = tb_productName.Text;
            model.categoryID = Convert.ToInt32(cb_category.SelectedValue);
            model.supplierID = Convert.ToInt32(cb_supplier.SelectedValue);
            model.unitPrice = Convert.ToDecimal(tb_unitPrice.Text);
            model.barcode = tb_barcode.Text;
            model.discontinued = !cb_discontinued.Checked;

            if (!string.IsNullOrEmpty(pb_image.ImageLocation))
            {
                FileInfo fi = new FileInfo(pb_image.ImageLocation);
                string name = Guid.NewGuid() + fi.Extension;
                fi.CopyTo("../../ProductImages/" + name);
                model.imagePath = name;
            }
            else
            {
                model.imagePath = "product.png";
            }
            model.isFastProduct = cb_isFastProduct.Checked;
            model.quantityPerUnit = tb_quantityPerUnit.Text;
            model.reorderLevel = Convert.ToInt16(tb_reorderLevel.Text);
            model.unitInStock = Convert.ToInt16(tb_stock.Text);
            model.unitsOnOrder = Convert.ToInt16(0);

            if (dm.productAdd(model))
            {
                MessageBox.Show("Kayıt Başarılı","Başarılı");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız","Başarısız");
            }
            GridDoldur();
        }

        private void pb_image_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pb_image.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void dgv_productList_MouseDown(object sender, MouseEventArgs e)
        {
            index = dgv_productList.HitTest(e.X,e.Y).RowIndex;
            if (index != -1)
            {
                if (e.Button == MouseButtons.Right)
                {
                    contextMenuStrip1.Show(dgv_productList, e.X, e.Y);
                    dgv_productList.ClearSelection();
                    dgv_productList.Rows[index].Selected = true;
                }
            }
        }

        private void TSMI_update_Click(object sender, EventArgs e)
        {
            if (index != -2)
            {
                int id = Convert.ToInt32(dgv_productList.Rows[index].Cells["ID"].Value);
                Products model = dm.GetProduct(id);
                tb_barcode.Text = model.barcode;
                tb_quantityPerUnit.Text = model.quantityPerUnit;
                tb_unitPrice.Text = model.unitPrice.ToString();
                tb_reorderLevel.Text = model.reorderLevel.ToString();
                tb_ID.Text = model.ID.ToString();
                tb_productName.Text = model.productName;
                tb_stock.Text = model.unitInStock.ToString();
                cb_category.SelectedValue = model.categoryID;
                cb_supplier.SelectedValue = model.supplierID;
                cb_isFastProduct.Checked = model.isFastProduct;
                cb_discontinued.Checked = model.discontinued;
                pb_image.ImageLocation = "../../ProductImages/" + model.imagePath;
                btn_update.Visible = true;
            }
        }

        private void TSMI_delete_Click(object sender, EventArgs e)
        {
           
        }
    }
}
