using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingManagement.Controller;
using System.Security.Cryptography;

namespace TrainingManagement
{
    public partial class Login : Form
    {
        UserController userController = new UserController();

        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ckbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShow.Checked == false)
                txtPassword.UseSystemPasswordChar = true;
            else
                txtPassword.UseSystemPasswordChar = false;
        }

        private void checkEmpty()
        {
            if (txtUsername.Text.Length == 0 && txtPassword.Text.Length == 0)
                MessageBox.Show("Vui lòng điền đầy đủ tên đăng nhập và mật khẩu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                if (txtPassword.Text.Length == 0)
                MessageBox.Show("Vui lòng điền tên đăng nhập!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                if (txtUsername.Text.Length == 0)
                MessageBox.Show("Vui lòng điền mật khẩu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);;
        }

        public string getMD5(string chuoi)
        {
            string str_md5 = "";
            byte[] mang = System.Text.Encoding.UTF8.GetBytes(chuoi);

            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            mang = my_md5.ComputeHash(mang);

            foreach (byte b in mang)
            {
                str_md5 += b.ToString("X2");
            }

            return str_md5;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int id = userController.login(txtUsername.Text, txtPassword.Text);
            // MessageBox.Show(id.ToString());
            if (id != -1)
            {

                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                txtPassword.Text = "";
            }

            else
                MessageBox.Show("Đăng nhập thất bại. Vui lòng thử lại sau!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
