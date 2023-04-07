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
    public partial class CategoryOperations : Form
    {
        DataModel dm = new DataModel();   
        public CategoryOperations()
        {
            InitializeComponent();
        }

        private void CategoryOperations_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dm.categoryList();
        }
    }
}
