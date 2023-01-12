using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingManagement.Controller;

namespace TrainingManagement
{
    public partial class Register : Form
    {
        UserController userController = new UserController();
        Bitmap bitmap = new Bitmap(Properties.Resources.avatar);
        Bitmap avatar;
        int avatarIndex = 0;
        int HEIGHT, WIDTH;

        public Register()
        {
            InitializeComponent();
            HEIGHT = bitmap.Height / 3;
            WIDTH = bitmap.Width / 3;
            avatar = new Bitmap(WIDTH, HEIGHT);
            changeAvatar(0);
            LoadAccess();
        }

        void LoadAccess()
        {
            cmbRight.Items.Add("Training Staff");
            cmbRight.Items.Add("Ministry");
            cmbRight.Items.Add("Lecturer");
            cmbRight.Items.Add("Student");
            cmbRight.SelectedIndex = 0;
        }

        void changeAvatar(int index)
        {
            int row = index / 3;
            int column = index % 3;

            for (int i = row * HEIGHT; i < (row + 1) * HEIGHT; i++)
            {
                for (int j = column * WIDTH; j < (column + 1) * WIDTH; j++)
                {
                    avatar.SetPixel(j - column * WIDTH, i - row * HEIGHT, bitmap.GetPixel(j, i));
                }
            }

            picAvatar.Image = avatar;
        }

        private void picAvatar_Click(object sender, EventArgs e)
        {
            avatarIndex++;
            if (avatarIndex > 5)
                avatarIndex = 0;
            changeAvatar(avatarIndex);
        }

        bool checkEmpty()
        {
            foreach (Control item in panel.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == "")
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        void resetTextBox()
        {
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtRePassword.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!checkEmpty())
            {
                MessageBox.Show("Please fill out all information!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPassword.Text != txtRePassword.Text)
            {
                MessageBox.Show("Password is not correct!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            users user = new users()
            {
                avatar = avatarIndex,
                username = txtUsername.Text,
                pass = GetMD5(txtPassword.Text),
                access_right = cmbRight.Text,
                email = txtEmail.Text
            };

            userController.addUser(user);
            MessageBox.Show("Add new user successfully!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resetTextBox();
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
    }
}
