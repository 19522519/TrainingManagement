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
    public partial class StudentManagement : Form
    {
        StudentController studentController = new StudentController();
        UserController userController = new UserController();
        MajorController majorController = new MajorController();
        int avatarIndex = 0;

        public StudentManagement()
        {
            InitializeComponent();
            loadData();
            loadGender();
            loadDorm();
            cmbMajor.DataSource = majorController.getAll();
            cmbMajor.DisplayMember = "Name";
            cmbMajor.ValueMember = "ID";

            loadFindMajor();
        }

        public void loadFindMajor()
        {
            cmbFindMajor.DataSource = majorController.getAll();
            cmbFindMajor.DisplayMember = "Name";
            cmbFindMajor.ValueMember = "ID";
            cmbFindMajor.SelectedIndex = 0;
        }

        void loadData()
        {
            dgvData.DataSource = studentController.getAll();
            addBinding();
        }

        public void loadDorm()
        {
            cmbDorm.Items.Add("Yes");
            cmbDorm.Items.Add("No");
        }

        public void loadGender()
        {
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Other");
            cmbGender.SelectedIndex = 0;
        }

        void addBinding()
        {
            txtId.DataBindings.Clear();
            txtStudentId.DataBindings.Clear();
            txtCitizenID.DataBindings.Clear();
            txtFirstName.DataBindings.Clear();
            txtLastName.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtPhone.DataBindings.Clear();
            cmbGender.DataBindings.Clear();
            txtBirthPlace.DataBindings.Clear();
            cmbMajor.DataBindings.Clear();
            cmbDorm.DataBindings.Clear();
            txtHousehold.DataBindings.Clear();
            txtUsername.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            txbImgIndex.DataBindings.Clear();

            txtId.DataBindings.Add("Text", dgvData.DataSource, "Id", true, DataSourceUpdateMode.Never);
            txtStudentId.DataBindings.Add("Text", dgvData.DataSource, "StudentId", true, DataSourceUpdateMode.Never);
            txtCitizenID.DataBindings.Add("Text", dgvData.DataSource, "CitizenId", true, DataSourceUpdateMode.Never);
            txtLastName.DataBindings.Add("Text", dgvData.DataSource, "LastName", true, DataSourceUpdateMode.Never);
            txtFirstName.DataBindings.Add("Text", dgvData.DataSource, "FirstName", true, DataSourceUpdateMode.Never);
            txtEmail.DataBindings.Add("Text", dgvData.DataSource, "Email", true, DataSourceUpdateMode.Never);
            txtPhone.DataBindings.Add("Text", dgvData.DataSource, "Phone", true, DataSourceUpdateMode.Never);
            cmbGender.DataBindings.Add("Text", dgvData.DataSource, "Gender", true, DataSourceUpdateMode.Never);
            txtBirthPlace.DataBindings.Add("Text", dgvData.DataSource, "BirthPlace", true, DataSourceUpdateMode.Never);
            cmbMajor.DataBindings.Add("Text", dgvData.DataSource, "Major", true, DataSourceUpdateMode.Never);
            cmbDorm.DataBindings.Add("Text", dgvData.DataSource, "IsInDorm", true, DataSourceUpdateMode.Never);
            txtHousehold.DataBindings.Add("Text", dgvData.DataSource, "Household", true, DataSourceUpdateMode.Never);
            txtUsername.DataBindings.Add("Text", dgvData.DataSource, "Username", true, DataSourceUpdateMode.Never);
            // txtPassword.DataBindings.Add("Text", dgvData.DataSource, "Password", true, DataSourceUpdateMode.Never);

            txbImgIndex.DataBindings.Add("Text", dgvData.DataSource, "Avatar", true, DataSourceUpdateMode.Never);
            /*            if(txbImgIndex.Text != "")
                            setAvatar(Convert.ToInt32(txbImgIndex.Text));*/
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

        void setAvatar(int index)
        {
            if (index > 5)
                return;

            Bitmap bitmap = new Bitmap(Properties.Resources.avatar);
            int HEIGHT = bitmap.Height / 3;
            int WIDTH = bitmap.Width / 3;

            int row = index / 3;
            int column = index % 3;
            Bitmap avatar = new Bitmap(WIDTH, HEIGHT);

            for (int i = row * HEIGHT; i < (row + 1) * HEIGHT; i++)
            {
                for (int j = column * WIDTH; j < (column + 1) * WIDTH; j++)
                {
                    avatar.SetPixel(j - column * WIDTH, i - row * HEIGHT, bitmap.GetPixel(j, i));
                }
            }

            imgAvatar.Image = avatar;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            student student = new student()
            {
                id = Convert.ToInt32(txtId.Text),
                ID_Student = txtStudentId.Text,
                citizen_id = txtCitizenID.Text,
                last_name = txtLastName.Text,
                first_name = txtFirstName.Text,
                phone = txtPhone.Text,
                gender = cmbGender.Text,
                birth_place = txtBirthPlace.Text,
                major_id = (int)cmbMajor.SelectedValue,
                household = txtHousehold.Text,
                is_in_dormitory = cmbDorm.Text
            };

            users users = new users()
            {
                username = txtUsername.Text,
                email = txtEmail.Text,
                pass = txtPassword.Text != "" ? getMD5(txtPassword.Text) : "",
                avatar = Convert.ToInt32(txbImgIndex.Text)
            };
            studentController.updateStudent(student, users);
            loadData();
            MessageBox.Show("Update student successfully!");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            users users = new users()
            {
                email = txtEmail.Text,
                pass = getMD5(txtPassword.Text),
                username = txtUsername.Text,
                access_right = "Student",
                avatar = Convert.ToInt32(txbImgIndex.Text),
            };
            int userId = userController.insertUser(users);

            student student = new student()
            {
                ID_Student = txtStudentId.Text,
                citizen_id = txtCitizenID.Text,
                last_name = txtLastName.Text,
                first_name = txtFirstName.Text,
                phone = txtPhone.Text,
                gender = cmbGender.Text,
                birth_place = txtBirthPlace.Text,
                major_id = (int)cmbMajor.SelectedValue,
                household = txtHousehold.Text,
                is_in_dormitory = cmbDorm.Text
            };
            studentController.insertStudent(student, userId);
            loadData();
            MessageBox.Show("Insert student successfully!");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = studentController.findStudent(txtFindStudentId.Text, txbFindFirstName.Text, cmbFindMajor.Text);
            addBinding();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to remove this student", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Delete user and student
                studentController.deleteStudent(Int32.Parse(txtId.Text));
                loadData();
            }
        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {
            txtUsername.Text = txtStudentId.Text;
        }

        private void imgAvatar_Click(object sender, EventArgs e)
        {
            avatarIndex++;
            if (avatarIndex > 5)
                avatarIndex = 0;
            setAvatar(avatarIndex);
            txbImgIndex.Text = avatarIndex.ToString();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtId.Text != "")
            {
                student student = studentController.getStudentById(Convert.ToInt32(txtId.Text));
                setAvatar(Convert.ToInt32(txbImgIndex.Text));
            }
        }
    }
}
