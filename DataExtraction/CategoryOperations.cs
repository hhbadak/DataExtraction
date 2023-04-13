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
using System.Xml.Linq;

namespace DataExtraction
{
    public partial class CategoryOperations : Form
    {
        DataModel dm = new DataModel();
        int id = -1;
        string imagePath = "";
        public CategoryOperations()
        {
            InitializeComponent();
        }

        private void CategoryOperations_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dm.categoryList();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_categoryName.Text))
            {
                Category model = new Category();
                model.categoryName = tb_categoryName.Text;
                model.description = tb_description.Text;
                model = dm.categoryAdd(model);
                if (model.ID != 0)
                {
                    MessageBox.Show($"{model.categoryName} Ekleme İşlemi ", "Başarılı");
                    tb_description.Text = tb_categoryName.Text = "";
                    dataGridView1.DataSource = dm.categoryList();
                }
            }
            else
            {
                MessageBox.Show("İsim boş olamaz", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var place = dataGridView1.HitTest(e.X, e.Y);
                if (place.RowIndex != -1)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[place.RowIndex].Selected = true;
                    id = Convert.ToInt32(dataGridView1.Rows[place.RowIndex].Cells[0].Value);
                    contextMenuStrip1.Show(dataGridView1, e.X, e.Y);
                }
            }
        }
        private void TSMI_update_Click(object sender, EventArgs e)
        {
            if (id != -1)
            {
                Category c = dm.getCategory(id);
                tb_categoryID.Text = c.ID.ToString();
                tb_categoryName.Text = c.categoryName;
                tb_description.Text = c.description;
                btn_update.Visible = true;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Category c = new Category();
            c.ID = id;
            c.categoryName = tb_categoryName.Text;
            c.description = tb_description.Text;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(openFileDialog1.FileName);
                if (fi.Extension == ".jpg" || fi.Extension == ".jpeg" || fi.Extension == ".png")
                {
                    string extension = fi.Extension;
                    string name = Guid.NewGuid().ToString();
                    c.picturePath = name + extension;
                    imagePath = $"~/Image/CategoryImage/{name}{extension}";
                }
            }
            dm.updateCategories(c);
            tb_description.Text = tb_categoryName.Text = tb_categoryID.Text = "";
        }

        private void TSMI_delete_Click(object sender, EventArgs e)
        {
            if (id != -1)
            {
                if (MessageBox.Show($"{id} ID'li Kategori SİLİNECEK, Emin misiniz?", "Sil", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dm.removeCategory(id);
                }
                else
                {
                    MessageBox.Show("Silme İşlemi İptal Edildi", "İPTAL");
                }
            }
            dataGridView1.DataSource = dm.categoryList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
