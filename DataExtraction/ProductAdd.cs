
using DataAccessLayer;
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
    public partial class ProductAdd : Form
    {
        DataModel dm = new DataModel();
        public ProductAdd()
        {
            InitializeComponent();
        }

        private void btn_productSave_Click(object sender, EventArgs e)
        {
            dm.productAdd(new Products
            {
                productName = tb_productName.Text,

            });
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
        }
    }
}
