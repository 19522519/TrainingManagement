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
    public partial class StudentProfile : Form
    {
        StudentController studentController = new StudentController();
        student student;
        int stuId;
        int avatarIndex = 0;

        public StudentProfile(int id)
        {
            stuId = id;
            InitializeComponent();
            student = studentController.getStudentById(id);
            txtStudentId.Text = student.ID_Student;
            cmbGender.Text = student.gender;
            txtLastName.Text = student.last_name;
            txtFirstName.Text = student.first_name;
            txtPhone.Text = student.phone;
            txtCititzenId.Text = student.citizen_id;
            txtBirthPlace.Text = student.birth_place;
            txtHousehold.Text = student.household;

            txtEmail.Text = student.users.email;
            txtUsername.Text = student.users.username;
            txtDepartment.Text = student.major.name;
            cmbIsInDorm.Text = student.is_in_dormitory;

            setAvatar(student.users.avatar.Value);
            loadGenders();
            loadIsInDorm();
        }

        void loadGenders()
        {
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Other");
            cmbGender.SelectedIndex = 0;
        }

        void loadIsInDorm()
        {
            cmbIsInDorm.Items.Add("Yes");
            cmbIsInDorm.Items.Add("No");
            cmbIsInDorm.SelectedIndex = 0;
        }

        private void StudentProfile_Load(object sender, EventArgs e)
        {
            txtStudentId.Focus();
            cmbGender.Focus();
            txtLastName.Focus();
            txtFirstName.Focus();
            txtPhone.Focus();
            txtCititzenId.Focus();
            txtHousehold.Focus();
            txtBirthPlace.Focus();

            txtEmail.Focus();
            txtUsername.Focus();
            txtDepartment.Focus();
            cmbIsInDorm.Focus();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            student student = new student()
            {
                id = stuId,
                ID_Student = txtStudentId.Text,
                gender = cmbGender.Text,
                last_name = txtLastName.Text,
                first_name = txtFirstName.Text,
                phone = txtPhone.Text,
                citizen_id = txtCititzenId.Text,
                birth_place = txtBirthPlace.Text,
                household = txtHousehold.Text,
                is_in_dormitory = cmbIsInDorm.Text,
                
            };
            studentController.updateStudent(student);
            MessageBox.Show("Save information successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void imgAvatar_Click(object sender, EventArgs e)
        {
            avatarIndex++;
            if (avatarIndex > 5)
                avatarIndex = 0;
            setAvatar(avatarIndex);
        }
    }
}
