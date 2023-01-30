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

namespace TrainingManagement
{
    public partial class StudentManagement : Form
    {
        StudentController studentController = new StudentController();
        MajorController majorController = new MajorController();

        public StudentManagement()
        {
            InitializeComponent();
            loadData();
            loadGender();
            cmbMajor.DataSource = majorController.getAll();
            cmbMajor.DisplayMember = "Name";
            cmbMajor.ValueMember = "ID";
        }

        void loadData()
        {
            dgvData.DataSource = studentController.getAll();
            addBinding();
        }

        public void loadGender()
        {
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
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
            rdbtnKTX.DataBindings.Clear();
            txtHousehold.DataBindings.Clear();
            txtUsername.DataBindings.Clear();
            txtPassword.DataBindings.Clear();

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
            rdbtnKTX.DataBindings.Add("Text", dgvData.DataSource, "IsInDorm", true, DataSourceUpdateMode.Never);
            txtHousehold.DataBindings.Add("Text", dgvData.DataSource, "Household", true, DataSourceUpdateMode.Never);
            txtUsername.DataBindings.Add("Text", dgvData.DataSource, "Username", true, DataSourceUpdateMode.Never);
            txtPassword.DataBindings.Add("Text", dgvData.DataSource, "Password", true, DataSourceUpdateMode.Never);
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
                
            };
            studentController.updateStudent(student);
            loadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
                
            };
            studentController.insertStudent(student);
            loadData();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = studentController.findStudent(txtFindStudentId.Text);
            addBinding();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to remove this student", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                studentController.deleteStudent(Int32.Parse(txtId.Text));
                loadData();
            }
        }
    }
}
