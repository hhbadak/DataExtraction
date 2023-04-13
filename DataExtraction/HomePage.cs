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
            Employee model = Helpers.loggedInUser;
            TSSL_userNameINFO.Text = model.fullName + "(" + model.userName + ")";
        }

        private void TSMI_categoryOperations_Click(object sender, EventArgs e)
        {
            bool isItOpen = false;
            Form[] openForms = this.MdiChildren;
            foreach (Form item in openForms)
            {
                if (item.GetType() == typeof(CategoryOperations))
                {
                    isItOpen = true;
                    item.Activate();
                }
            }
            if (isItOpen == false)
            {
                CategoryOperations frm = new CategoryOperations();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void TSMI_products_Click(object sender, EventArgs e)
        {
            bool isItOpen = false;
            Form[] openForms = this.MdiChildren;
            foreach (Form item in openForms)
            {
                if (item.GetType() == typeof(ProductsShow))
                {
                    isItOpen = true;
                    item.Activate();
                }
            }
            if (isItOpen == false)
            {
                ProductsShow frm = new ProductsShow();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void TSMI_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
