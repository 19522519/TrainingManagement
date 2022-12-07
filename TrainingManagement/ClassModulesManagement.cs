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
    public partial class ClassModulesManagement : Form
    {
        ClassModuleController classModuleController = new ClassModuleController();
        LecturerController lecturerController = new LecturerController();
        String majorParam;

        public ClassModulesManagement(String major)
        {
            majorParam = major;
            InitializeComponent();
            loadData();
            loadSemester();
            // loadLecturer(major);
        }

        void loadSemester()
        {
            cmbSemester.Items.Add("Học kỳ 1");
            cmbSemester.Items.Add("Học kỳ 2");
            cmbSemester.SelectedIndex = 0;
        }

        void loadLecturer(String major)
        {
            cmbTheoryLecturer.DataSource = lecturerController.getAll(major);
            cmbPracticeLecturer.DataSource = lecturerController.getAll(major);
        }

        void loadData()
        {
            dgvData.DataSource = classModuleController.getAllByMajor(majorParam);
            addBiding();
        }

        void addBiding()
        {
            txtSchoolYear.DataBindings.Clear();
            cmbSemester.DataBindings.Clear();
            txtModuleCode.DataBindings.Clear();
            txtClassModuleName.DataBindings.Clear();
            dtpStartDate.DataBindings.Clear();
            dtpEndDate.DataBindings.Clear();
            //cmbTheoryLecturer.DataBindings.Clear();
            //cmbPracticeLecturer.DataBindings.Clear();

            txtSchoolYear.DataBindings.Add("Text", dgvData.DataSource, "School_Year", true, DataSourceUpdateMode.Never);
            cmbSemester.DataBindings.Add("Text", dgvData.DataSource, "Semester", true, DataSourceUpdateMode.Never);
            txtModuleCode.DataBindings.Add("Text", dgvData.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txtClassModuleName.DataBindings.Add("Text", dgvData.DataSource, "Name", true, DataSourceUpdateMode.Never);
            dtpStartDate.DataBindings.Add("Value", dgvData.DataSource, "Start_Date", true, DataSourceUpdateMode.Never);
            dtpEndDate.DataBindings.Add("Value", dgvData.DataSource, "End_Date", true, DataSourceUpdateMode.Never);
            //cmbTheoryLecturer.DataBindings.Add("Text", dgvData.DataSource, "Theory_Lecturer", true, DataSourceUpdateMode.Never);
            //cmbPracticeLecturer.DataBindings.Add("Text", dgvData.DataSource, "Practice_Lecturer", true, DataSourceUpdateMode.Never);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
