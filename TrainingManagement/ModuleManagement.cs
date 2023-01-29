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
    public partial class ModuleManagement : Form
    {
        string right; 
        CurriculumController curriculumController = new CurriculumController();
        ModuleListController moduleListController = new ModuleListController();
        ModuleController moduleController = new ModuleController();
        ClassModuleController classModuleController = new ClassModuleController();

        public ModuleManagement(string role)
        {
            InitializeComponent();

            right = role;
            changeRoleName();

            loadSchoolYear();

            dgvModuleList.DataSource = moduleListController.getAllModule(right, txbModuleCode.Text, txbModuleName.Text);
            addBiding();
        }

        // Đổi từ SEDean sang Software Engirneering / CSDean sang Computer Science / ISDean sang Information System
        void changeRoleName()
        {
            switch(right)
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

        void loadSchoolYear()
        {
            cmbSchoolYear.DataSource = curriculumController.getAllSchoolYearOnMajor(right);
            cmbSchoolYear.DisplayMember = "SchoolYear";
            // cmbSchoolYear.SelectedIndex = 0;
        }

        void loadCurriculumBasedOnSchoolYear()
        {
            cmbCurriculum.DataSource = curriculumController.getAllCurriculumNameOnYearAndMajor(cmbSchoolYear.Text, right);
            cmbCurriculum.DisplayMember = "Name";
            cmbCurriculum.SelectedIndex = 0;
        }

        private void cmbSchoolYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCurriculumBasedOnSchoolYear();
        }

        private void cmbCurriculum_SelectedIndexChanged(object sender, EventArgs e)
        {
            dynamic value = curriculumController.getAllCurriculumBasedOnMajorAndNameAndSchoolYear(right, cmbCurriculum.Text, cmbSchoolYear.Text);
            if (value != null)
            {
                txbCurriculumId.Text = value.Id.ToString();
                txbTrainingType.Text = value.TrainingType;
                txbTrainingSystem.Text = value.TrainingSystem;
                loadDataModule();
            }
        }

        public void addBiding()
        {
            txbModuleCode.DataBindings.Clear();
            txbModuleName.DataBindings.Clear();

            txbCode.DataBindings.Clear();
            txbName.DataBindings.Clear();
            txbCredits.DataBindings.Clear();

            txbModuleCode.DataBindings.Add("Text", dgvModuleList.DataSource, "Code", true, DataSourceUpdateMode.Never);
            txbModuleName.DataBindings.Add("Text", dgvModuleList.DataSource, "Name", true, DataSourceUpdateMode.Never);

            txbCode.DataBindings.Add("Text", dgvModuleList.DataSource, "Code", true, DataSourceUpdateMode.Never);
            txbName.DataBindings.Add("Text", dgvModuleList.DataSource, "Name", true, DataSourceUpdateMode.Never);
            txbCredits.DataBindings.Add("Text", dgvModuleList.DataSource, "Credits", true, DataSourceUpdateMode.Never);
        }

        public void addBidingModule()
        {
            txbModuleId.DataBindings.Clear();
            txbCode.DataBindings.Clear();
            txbName.DataBindings.Clear();
            txbTheoryLessons.DataBindings.Clear();
            txbPracticeLessons.DataBindings.Clear();
            txbSelfStudyLessons.DataBindings.Clear();
            txbVisitingLessons.DataBindings.Clear();

            txbModuleId.DataBindings.Add("Text", dgvModule.DataSource, "Id", true, DataSourceUpdateMode.Never);
            txbCode.DataBindings.Add("Text", dgvModule.DataSource, "Code", true, DataSourceUpdateMode.Never);
            txbName.DataBindings.Add("Text", dgvModule.DataSource, "Name", true, DataSourceUpdateMode.Never);
            txbTheoryLessons.DataBindings.Add("Text", dgvModule.DataSource, "TheoryLessons", true, DataSourceUpdateMode.Never);
            txbPracticeLessons.DataBindings.Add("Text", dgvModule.DataSource, "PracticeLessons", true, DataSourceUpdateMode.Never);
            txbSelfStudyLessons.DataBindings.Add("Text", dgvModule.DataSource, "SelfStudyLessons", true, DataSourceUpdateMode.Never);
            txbVisitingLessons.DataBindings.Add("Text", dgvModule.DataSource, "VisitingLessons", true, DataSourceUpdateMode.Never);       
        }

        public void loadDataModule()
        {
            dgvModule.DataSource = moduleController.getAllModuleBaseOnCurriculum(Convert.ToInt32(txbCurriculumId.Text));
            addBidingModule();
        }

        private void btnSearchModule_Click(object sender, EventArgs e)
        {
            dgvModuleList.DataSource = moduleListController.getAllModule(right, txbModuleCode.Text, txbModuleName.Text);
            addBiding();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbModuleName.Text = "";
            txbModuleCode.Text = "";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Create module
            module module = new module
            {
                ID_Module = txbCode.Text,
                name = txbName.Text,
                credits = Convert.ToInt32(txbCredits.Text),
                theory_lessons = Convert.ToInt32(txbTheoryLessons.Text),
                practice_lessons = Convert.ToInt32(txbPracticeLessons.Text),
                self_study_lessons = Convert.ToInt32(txbSelfStudyLessons.Text),
                visiting_lessons = Convert.ToInt32(txbVisitingLessons.Text)
            };
            int moduleId = moduleController.insertModule(Convert.ToInt32(txbCurriculumId.Text), module);

            loadDataModule();
            MessageBox.Show("Create successfully!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            module module = new module()
            {
                id = Convert.ToInt32(txbModuleId.Text),
                ID_Module = txbCode.Text,
                name = txbName.Text,
                credits = Convert.ToInt32(txbCredits.Text),
                theory_lessons = Convert.ToInt32(txbTheoryLessons.Text),
                practice_lessons = Convert.ToInt32(txbPracticeLessons.Text),
                self_study_lessons = Convert.ToInt32(txbSelfStudyLessons.Text),
                visiting_lessons = Convert.ToInt32(txbVisitingLessons.Text)
            };
            moduleController.updateModule(module);
            loadDataModule();
            MessageBox.Show("Update successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to remove this module", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                moduleController.deleteModule(Convert.ToInt32(txbModuleId.Text));
                loadDataModule();
            }
        }

        private void dgvModuleList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addBiding();
        }

        private void dgvModule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addBidingModule();
            dynamic value = moduleListController.getCreditsByCode(txbName.Text, right, txbCode.Text);
            if (value != null)
            {
                txbCredits.Text = value.Credits.ToString();
            }
        }
    }
}
