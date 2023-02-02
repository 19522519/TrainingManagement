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
    public partial class ViewScore : Form
    {
        StudyingController studyingController = new StudyingController();
        StudentController studentController = new StudentController();
        int stuId;

        public ViewScore(int id)
        {
            InitializeComponent();
            stuId = id;
            loadSemester();
            loadSchoolYear();
            loadData();
            dgvData.DataSource = studyingController.getAllScore(stuId);

            lbTimetableTitle.Text = "LEARNING RESULT SEMESTER " + cmbSemester.Text + " SCHOOL YEAR " + cmbSchoolYear.Text;

            loadStudentDetail();
        }

        public void loadStudentDetail()
        {
            student student = studentController.getStudentById(stuId);
            txbName.Text = student.last_name + " " + student.first_name;
            txbStudentId.Text = student.ID_Student;
            txbBirthPlace.Text = student.birth_place;
            txbMajor.Text = student.major.name;
        }

        void loadSemester()
        {
            cmbSemester.Items.Add("1");
            cmbSemester.Items.Add("2");
            cmbSemester.SelectedIndex = 0;
        }

        void loadSchoolYear()
        {
            cmbSchoolYear.DataSource = studyingController.getAllSchoolYear(stuId);
            cmbSchoolYear.SelectedIndex = 0;
        }

        void loadData()
        {
            dgvData.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.DataPropertyName = "Name";
            col1.HeaderText = "Class module name";

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.DataPropertyName = "ModuleCode";
            col2.HeaderText = "Class module code";

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.DataPropertyName = "Credits";
            col3.HeaderText = "Credits";

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.DataPropertyName = "AvgScore";
            col4.HeaderText = "Score";

            dgvData.Columns.Add(col1);
            dgvData.Columns.Add(col2);
            dgvData.Columns.Add(col3);
            dgvData.Columns.Add(col4);
        }

        private void btnViewScore_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = studyingController.getAllScore(cmbSemester.Text, cmbSchoolYear.Text, stuId);
        }
    }
}
