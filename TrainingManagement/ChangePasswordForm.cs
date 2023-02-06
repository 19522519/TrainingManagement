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
    public partial class ChangePasswordForm : Form
    {
        UserController userController = new UserController();
        users users;
        int uid;

        public ChangePasswordForm(int id)
        {
            uid = id;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            users = userController.getUserById(id);

            btnShowNewPass.BringToFront();
            btnShowConfirmNewPass.BringToFront(); 
            txbNewPass.PasswordChar = '*';
            txbConfirmNewPass.PasswordChar = '*';
        }

        public string GetMD5(string chuoi)
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

        private void btnSaveSecurity_Click(object sender, EventArgs e)
        {
            if (txbNewPass.Text != txbConfirmNewPass.Text)
            {
                MessageBox.Show("Wrong confirm new password. Please check again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbConfirmNewPass.Focus();
            }
            else
            {
                users users = new users()
                {
                    id = uid,
                    pass = GetMD5(txbNewPass.Text)
                };
                userController.UpdatePassword(users);
                MessageBox.Show("Change password successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.ShowDialog();
            this.Close();
        }

        private void btnShowNewPass_Click(object sender, EventArgs e)
        {
            if (txbNewPass.PasswordChar == '*')
            {
                btnHideNewPass.BringToFront();
                txbNewPass.PasswordChar = '\0';
            }
        }

        private void btnHideNewPass_Click(object sender, EventArgs e)
        {
            if (txbNewPass.PasswordChar == '\0')
            {
                btnShowNewPass.BringToFront();
                txbNewPass.PasswordChar = '*';
            }
        }

        private void btnShowConfirmNewPass_Click(object sender, EventArgs e)
        {
            if (txbConfirmNewPass.PasswordChar == '*')
            {
                btnHideConfirmNewPass.BringToFront();
                txbConfirmNewPass.PasswordChar = '\0';
            }
        }

        private void btnHideConfirmNewPass_Click(object sender, EventArgs e)
        {
            if (txbConfirmNewPass.PasswordChar == '\0')
            {
                btnShowConfirmNewPass.BringToFront();
                txbConfirmNewPass.PasswordChar = '*';
            }
        }
    }
}
