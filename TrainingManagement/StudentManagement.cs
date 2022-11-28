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
        public StudentManagement()
        {
            InitializeComponent();
        }

        void loadData()
        {
            dgvData.DataSource = studentController.getAll();
            addBinding();
        }

        void addBinding()
        {
            txtStudentId.DataBindings.Clear();
            txtCitizenID.DataBindings.Clear();
            txtFirstName.DataBindings.Clear();
            txtLastName.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtPhone.DataBindings.Clear();
            cmbGender.DataBindings.Clear();
            txtBirthPlace.DataBindings.Clear();
            cmbDepartment.DataBindings.Clear();
            rdbtnKTX.DataBindings.Clear();
            txtHousehold.DataBindings.Clear();
            txtUsername.DataBindings.Clear();
            txtPassword.DataBindings.Clear();

            txtStudentId.DataBindings.Add("Text", dgvData.DataSource, "Student Id", true, DataSourceUpdateMode.Never);
            txtCitizenID.DataBindings.Add("Text", dgvData.DataSource, "CCCD", true, DataSourceUpdateMode.Never);
            txtLastName.DataBindings.Add("Text", dgvData.DataSource, "Last Name", true, DataSourceUpdateMode.Never);
            txtFirstName.DataBindings.Add("Text", dgvData.DataSource, "First Name", true, DataSourceUpdateMode.Never);
            txtEmail.DataBindings.Add("Text", dgvData.DataSource, "Email", true, DataSourceUpdateMode.Never);
            txtPhone.DataBindings.Add("Text", dgvData.DataSource, "Phone", true, DataSourceUpdateMode.Never);
            cmbGender.DataBindings.Add("Text", dgvData.DataSource, "Gender", true, DataSourceUpdateMode.Never);
            txtBirthPlace.DataBindings.Add("Text", dgvData.DataSource, "Birth Place", true, DataSourceUpdateMode.Never);
            cmbDepartment.DataBindings.Add("Text", dgvData.DataSource, "Department", true, DataSourceUpdateMode.Never);
            rdbtnKTX.DataBindings.Add("Text", dgvData.DataSource, "Is In Dorm", true, DataSourceUpdateMode.Never);
            txtHousehold.DataBindings.Add("Text", dgvData.DataSource, "Household", true, DataSourceUpdateMode.Never);
            txtUsername.DataBindings.Add("Text", dgvData.DataSource, "Username", true, DataSourceUpdateMode.Never);
            txtPassword.DataBindings.Add("Text", dgvData.DataSource, "Password", true, DataSourceUpdateMode.Never);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtCitizenID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
