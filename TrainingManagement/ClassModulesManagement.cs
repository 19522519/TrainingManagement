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
        CurriculumController curriculumController = new CurriculumController();
        ModuleController moduleController = new ModuleController();
        ClassModuleController classModuleController = new ClassModuleController();
        LecturerController lecturerController = new LecturerController();
        string right;

        public ClassModulesManagement(string role)
        {
            InitializeComponent();

            right = role;
            changeRoleName();

            loadSchoolYear();
            
            loadLecturer();
        }

        // Đổi từ SEDean sang Software Engirneering / CSDean sang Computer Science / ISDean sang Information System
        public void changeRoleName()
        {
            switch (right)
            {
                case "SEDean":
                    right = "Software Engirneering";
                    break;
                case "CSDean":
                    right = "Computer Science";
                    break;
                case "ISDean":
                    right = "Information System";
                    break;
            }
        }

        public void loadSchoolYear()
        {
            cmbSchoolYear.DataSource = curriculumController.getAllSchoolYearOnMajor(right);
            cmbSchoolYear.DisplayMember = "SchoolYear";
            cmbSchoolYear.SelectedIndex = 0;
        }

        void loadLecturer()
        {
            dgvLecturer.DataSource = lecturerController.getAllLecturerBasedOnMajor(right);
            addBidingLecturer();
        }

        public void addBidingLecturer()
        {
            txbLecturerId.DataBindings.Clear();
            txbLecturerName.DataBindings.Clear();
            cmbLevel.DataBindings.Clear();
            txbLecturerId.DataBindings.Add("Text", dgvLecturer.DataSource, "Id", true, DataSourceUpdateMode.Never);
            txbLecturerName.DataBindings.Add("Text", dgvLecturer.DataSource, "Name", true, DataSourceUpdateMode.Never);
            cmbLevel.DataBindings.Add("Text", dgvLecturer.DataSource, "Level", true, DataSourceUpdateMode.Never);
        }

        public void loadDataModule()
        {
            dgvModule.DataSource = moduleController.getAllModulesBasedOnShoolYear(cmbSchoolYear.Text);
            addBidingModule();
        }

        void addBidingModule()
        {
            txbModuleId.DataBindings.Clear();
            txbClassModuleCode.DataBindings.Clear();
            txbClassModuleName.DataBindings.Clear();

            txbModuleId.DataBindings.Add("Text", dgvModule.DataSource, "Id", true, DataSourceUpdateMode.Never);
            txbClassModuleCode.DataBindings.Add("Text", dgvModule.DataSource, "Code", true, DataSourceUpdateMode.Never);
            txbClassModuleName.DataBindings.Add("Text", dgvModule.DataSource, "Name", true, DataSourceUpdateMode.Never);
        }

        public void loadDataClassModule()
        {

        }

        public void addBidingClassModule()
        {

        }

        private void btnSearchModule_Click(object sender, EventArgs e)
        {
            loadDataModule();
        }

        private void btnSearchLecturer_Click(object sender, EventArgs e)
        {
            dgvLecturer.DataSource = lecturerController.findLecturerOnNameAndLevel(txbLecturerName.Text, cmbLevel.Text, right);
            addBidingLecturer();
        }

        private void cmbSchoolYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbSchoolYear.Text = cmbSchoolYear.Text;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            class_module class_Module = new class_module()
            {
                ID_Class_module = txbClassModuleCode.Text,
                start_date = dtpStartDate.Value,
                end_date = dtpEndDate.Value,
                semester = Convert.ToInt32(txbSemester.Text),
                school_year = Convert.ToInt32(txbSchoolYear.Text)
            };
            classModuleController.insertClassModule(Convert.ToInt32(txbModuleId.Text), class_Module);
        }
    }
}
