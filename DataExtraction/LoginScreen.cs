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
    public partial class LoginScreen : Form
    {
        bool thereEntry = false;
        DataModel dm = new DataModel();
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btn_closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_userLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_username.Text) && !string.IsNullOrEmpty(tb_password.Text))
            {
                Employee model = dm.employeeLogin(tb_username.Text, tb_password.Text);
                if (model.userName != null)
                {
                    Helpers.loggedInUser = model;
                    thereEntry = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!","Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Şifre veya Kullanıcı Adı boş bırakılamaz!");
            }
        }

        private void LoginScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!thereEntry)
            {
                Application.Exit();
            }
        }
    }
}
