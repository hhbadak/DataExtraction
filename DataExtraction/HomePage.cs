using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataExtraction
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            LoginScreen frm = new LoginScreen();
            frm.ShowDialog();
        }

        private void TSMI_categoryOperations_Click(object sender, EventArgs e)
        {
            CategoryOperations frm = new CategoryOperations();
            frm.MdiParent = this;
            frm.Show();
        }

        private void TSMI_products_Click(object sender, EventArgs e)
        {
            ProductsShow frm = new ProductsShow();
            frm.MdiParent = this;
            frm.Show();
        }

        private void TSMI_productAdd_Click(object sender, EventArgs e)
        {
            ProductAdd frm = new ProductAdd();
            frm.MdiParent = this;
            frm.Show();
        }

        private void TSMI_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
