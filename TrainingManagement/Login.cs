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
        StudentController studentController = new StudentController();
        LecturerController lecturerController = new LecturerController();

        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
                str_md5 += b.ToString("X2");    // Convert to upper case
            }

            return str_md5;
        }

 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            int id = userController.login(txtUsername.Text, getMD5(txtPassword.Text));
            // MessageBox.Show(id.ToString());
            if (id != -1)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);

                String role = userController.getUserById(id).access_right;
                switch(role)
                {
                    case "Sinh viên":
                        // Lấy id student từ user id                     
                        var student = studentController.getStudentByUserId(id);
                        int stuId = student.Id;
                        StudentHomePage studentHomePage = new StudentHomePage(stuId);

                        studentHomePage.ShowDialog();
                        break;
                    case "Giảng viên":
                        // Lấy id lecturer từ user id
                        var lecturer = lecturerController.getLecturerByUserId(id);
                        int lecId = lecturer.ID;
                        LecturerHomePage lecturerHomePage = new LecturerHomePage(lecId);
                        lecturerHomePage.ShowDialog();

                        break;
                    case "Quản lý khoa":
                        // Lấy id department manager từ user id
                        DepartmentManagerHomePage departmentManagerHomePage = new DepartmentManagerHomePage();
                        departmentManagerHomePage.Show();
                        break;
                }

                txtUsername.Text = "";
                txtPassword.Text = "";
            }
            else
                MessageBox.Show("Login failed. Please try again!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
