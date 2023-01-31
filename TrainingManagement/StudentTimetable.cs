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
    public partial class StudentTimetable : Form
    {
        StudentController studentController = new StudentController();
        int stuId;

        public StudentTimetable(int id)
        {
            InitializeComponent();
            stuId = id;

            loadSemester();
            loadSchoolYear();

            lbTimetableTitle.Text = "TIMETABLE SEMESTER " + cmbSemester.Text + " SCHOOL YEAR " + cmbSchoolYear.Text;
            lbStudentCode.Text = "ID: " + studentController.getStudentCodeById(stuId);
        }

        public void loadSemester()
        {
            cmbSemester.Items.Add("1");
            cmbSemester.Items.Add("2");
            cmbSemester.SelectedIndex = 0;
        }

        public void loadSchoolYear()
        {
            cmbSchoolYear.DataSource = studentController.getAllSchoolYearBasedOnStudentId(stuId);
            cmbSchoolYear.DisplayMember = "SchoolYear";
            cmbSchoolYear.SelectedIndex = 0;
        }

        public void loadTimetable()
        {
            dgvTimetable.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.DataPropertyName = "ClassCode";
            col1.HeaderText = "Class code";

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.DataPropertyName = "ClassName";
            col2.HeaderText = "Class name";

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.DataPropertyName = "Room";
            col3.HeaderText = "Room";

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.DataPropertyName = "StartTime";
            col4.HeaderText = "Start time";

            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.DataPropertyName = "EndTime";
            col5.HeaderText = "End time";

            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
            col6.DataPropertyName = "StartDate";
            col6.HeaderText = "Start date";

            DataGridViewTextBoxColumn col7 = new DataGridViewTextBoxColumn();
            col7.DataPropertyName = "StartDate";
            col7.HeaderText = "End date";

            DataGridViewTextBoxColumn col8 = new DataGridViewTextBoxColumn();
            col8.DataPropertyName = "Lecturer";
            col8.HeaderText = "Lecturer name";

            dgvTimetable.Columns.Add(col1);
            dgvTimetable.Columns.Add(col2);
            dgvTimetable.Columns.Add(col3);
            dgvTimetable.Columns.Add(col4);
            dgvTimetable.Columns.Add(col5);
            dgvTimetable.Columns.Add(col6);
            dgvTimetable.Columns.Add(col7);
            dgvTimetable.Columns.Add(col8);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            dgvTimetable.Columns.Clear();
            lbTimetableTitle.Text = "TIMETABLE SEMESTER " + cmbSemester.Text + " SCHOOL YEAR " + cmbSchoolYear.Text;
            lbStudentCode.Text = "ID: " + studentController.getStudentCodeById(stuId);

            loadTimetable();
            dgvTimetable.DataSource = studentController.getTimetableBasedOnStudentId(stuId, Convert.ToInt32(cmbSchoolYear.Text), Convert.ToInt32(cmbSemester.Text));
        }
    }
}
