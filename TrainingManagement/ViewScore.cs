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
        }

        void loadData()
        {
            dgvData.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.DataPropertyName = "Name";
            col1.HeaderText = "Tên học phần";

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.DataPropertyName = "ModuleCode";
            col2.HeaderText = "Mã học phần";

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.DataPropertyName = "TheoryCredits";
            col3.HeaderText = "Tín chỉ lý thuyết";

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.DataPropertyName = "PracticeCredits";
            col4.HeaderText = "Tín chỉ thực hành";

            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.DataPropertyName = "SelfStudyCredits";
            col5.HeaderText = "Tín chỉ tự học";

            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
            col6.DataPropertyName = "VisitingCredits";
            col6.HeaderText = "Tín chỉ tham quan";

            DataGridViewTextBoxColumn col7 = new DataGridViewTextBoxColumn();
            col7.DataPropertyName = "AvgScore";
            col7.HeaderText = "DTB";

            dgvData.Columns.Add(col1);
            dgvData.Columns.Add(col2);
            dgvData.Columns.Add(col3);
            dgvData.Columns.Add(col4);
            dgvData.Columns.Add(col5);
            dgvData.Columns.Add(col6);
            dgvData.Columns.Add(col7);
        }

        private void btnViewScore_Click(object sender, EventArgs e)
        {
            int semester = Convert.ToInt32(cmbSemester.Text);
            int schoolYear = Convert.ToInt32(cmbSchoolYear.SelectedValue.ToString());
            dgvData.DataSource = studyingController.getAllScore(semester, schoolYear, stuId);
        }
    }
}
