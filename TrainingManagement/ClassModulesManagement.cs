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
        TeachingController teachingController = new TeachingController();
        ClassroomController classroomController = new ClassroomController();
        LessonController lessonController = new LessonController();
        string right;

        public ClassModulesManagement(string role)
        {
            InitializeComponent();

            right = role;
            changeRoleName();

            cmbDay.SelectedIndex = 0;

            loadSchoolYear();

            loadLevelOfLecturer();
            
            loadLecturer();

            loadSemester();

            loadDataClassModule();
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
            dgvClassModule.DataSource = lessonController.getAllLessons(right);
            addBidingClassModule();
        }

        public void addBidingClassModule()
        {
            txbLessonId.DataBindings.Clear();
            txbSchoolYear.DataBindings.Clear();
            cmbSemester.DataBindings.Clear();
            txbClassModuleCode.DataBindings.Clear();
            txbClassModuleName.DataBindings.Clear();
            cmbDay.DataBindings.Clear();
            txbStartTime.DataBindings.Clear();
            txbEndTime.DataBindings.Clear();
            dtpStartDate.DataBindings.Clear();
            dtpEndDate.DataBindings.Clear();
            cmbRoom.DataBindings.Clear();
            txbLecturer.DataBindings.Clear();

            txbLessonId.DataBindings.Add("Text", dgvClassModule.DataSource, "Id", true, DataSourceUpdateMode.Never);
            txbSchoolYear.DataBindings.Add("Text", dgvClassModule.DataSource, "SchoolYear", true, DataSourceUpdateMode.Never);
            cmbSemester.DataBindings.Add("Text", dgvClassModule.DataSource, "Semester", true, DataSourceUpdateMode.Never);
            txbClassModuleCode.DataBindings.Add("Text", dgvClassModule.DataSource, "ClassCode", true, DataSourceUpdateMode.Never);
            txbClassModuleName.DataBindings.Add("Text", dgvClassModule.DataSource, "ClassName", true, DataSourceUpdateMode.Never);
            cmbDay.DataBindings.Add("Text", dgvClassModule.DataSource, "Day", true, DataSourceUpdateMode.Never);
            txbStartTime.DataBindings.Add("Text", dgvClassModule.DataSource, "StartTime", true, DataSourceUpdateMode.Never);
            txbEndTime.DataBindings.Add("Text", dgvClassModule.DataSource, "EndTime", true, DataSourceUpdateMode.Never);
            dtpStartDate.DataBindings.Add("Value", dgvClassModule.DataSource, "StartDate", true, DataSourceUpdateMode.Never);
            dtpEndDate.DataBindings.Add("Value", dgvClassModule.DataSource, "EndDate", true, DataSourceUpdateMode.Never);
            cmbRoom.DataBindings.Add("Text", dgvClassModule.DataSource, "Room", true, DataSourceUpdateMode.Never);
            txbLecturer.DataBindings.Add("Text", dgvClassModule.DataSource, "Lecturer", true, DataSourceUpdateMode.Never);
        }

        public void loadSemester()
        {
            cmbSemester.Items.Add("1");
            cmbSemester.Items.Add("2");
            cmbSemester.SelectedIndex = 0;
        }

        public void loadLevelOfLecturer()
        {
            cmbLevel.DataSource = lecturerController.findAllLevelOnMajor(right);
            cmbLevel.DisplayMember = "Level";
            cmbLevel.SelectedIndex = 0;
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
            // Insert class module
            class_module class_Module = new class_module()
            {
                ID_Class_module = txbClassModuleCode.Text,
                start_date = dtpStartDate.Value,
                end_date = dtpEndDate.Value,
                semester = Convert.ToInt32(cmbSemester.Text),
                school_year = Convert.ToInt32(txbSchoolYear.Text)
            };
            int classModuleId = classModuleController.insertClassModule(Convert.ToInt32(txbModuleId.Text), class_Module);

            // Insert teaching
            teaching teaching = new teaching();
            int teachingId = teachingController.insertTeaching(classModuleId, Convert.ToInt32(txbLecturerId.Text), teaching);

            // Insert lesson
            lesson lesson = new lesson()
            {
                day_in_week = cmbDay.Text,
                start_time = txbStartTime.Text,
                end_time = txbEndTime.Text
            };
            lessonController.insertLesson(Convert.ToInt32(txbClassroomId.Text), teachingId, classModuleId, lesson);
            
            loadDataClassModule();
            MessageBox.Show("Insert class module successfully!");
        }

        private void txbLecturerName_TextChanged(object sender, EventArgs e)
        {
            txbLecturer.Text = txbLecturerName.Text;
        }

        private void dgvModule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addBidingModule();
        }

        private void dgvLecturer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addBidingLecturer();
        }

        private void dgvClassModule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            addBidingClassModule();
            txbLecturerId.Text = lessonController.findLecturerBasedOnLesson(Convert.ToInt32(txbLessonId.Text)).ToString();
            txbModuleId.Text = lessonController.findModuleBasedOnLesson(Convert.ToInt32(txbLessonId.Text)).ToString();
        }

        private void rdbLecture_CheckedChanged(object sender, EventArgs e)
        {
            cmbRoom.DataSource = classroomController.getAllClassroomBasedOnFunction("Lecture Room");
            cmbRoom.DisplayMember = "Name";
            cmbRoom.SelectedIndex = 0;
        }

        private void rdbPractice_CheckedChanged(object sender, EventArgs e)
        {
            cmbRoom.DataSource = classroomController.getAllClassroomBasedOnFunction("Practice Room");
            cmbRoom.DisplayMember = "Name";
            cmbRoom.SelectedIndex = 0;
        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            dynamic result = classroomController.findClassroomBasedOnName(cmbRoom.Text);
            if (result != null)
                txbClassroomId.Text = result.Id.ToString();
        }

        private void btnSearchClassModule_Click(object sender, EventArgs e)
        {
            dgvClassModule.DataSource = lessonController.getAllLessonsBasedOnSemesterAndSchoolYear(Convert.ToInt32(cmbSemester.Text), Convert.ToInt32(txbSchoolYear.Text), right);
            addBidingClassModule();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to remove this class module", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lessonController.deleteLesson(Convert.ToInt32(txbLessonId.Text));

                teachingController.deleteTeaching(Convert.ToInt32(txbTeachingId.Text));
          
                classModuleController.deleteClassModule(Convert.ToInt32(txbClassModuleId.Text));

                loadDataClassModule();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Update class module
            class_module class_Module = new class_module()
            {
                id = Convert.ToInt32(txbClassModuleId.Text),
                ID_Class_module = txbClassModuleCode.Text,
                start_date = dtpStartDate.Value,
                end_date = dtpEndDate.Value,
                semester = Convert.ToInt32(cmbSemester.Text),
                school_year = Convert.ToInt32(txbSchoolYear.Text)
            };
            classModuleController.updateClassModule(Convert.ToInt32(txbModuleId.Text), class_Module);

            // Update teaching
            teaching teaching = new teaching()
            {
                id = Convert.ToInt32(txbTeachingId.Text)
            };
            teachingController.updateTeaching(Convert.ToInt32(txbLecturerId.Text), teaching);

            // Update lesson
            lesson lesson = new lesson()
            {
                id = Convert.ToInt32(txbLessonId.Text),
                day_in_week = cmbDay.Text,
                start_time = txbStartTime.Text,
                end_time = txbEndTime.Text
            };
            lessonController.updateLesson(Convert.ToInt32(txbClassroomId.Text), lesson);

            loadDataClassModule();
            MessageBox.Show("Update class module successfully!");
        }

        private void txbLessonId_TextChanged(object sender, EventArgs e)
        {
            txbClassModuleId.Text = lessonController.findClassModuleBasedOnLesson(Convert.ToInt32(txbLessonId.Text)).ToString();
            txbTeachingId.Text = lessonController.findTeachingBasedOnLesson(Convert.ToInt32(txbLessonId.Text)).ToString();
            txbClassroomId.Text = lessonController.findClassroomBasedOnLesson(Convert.ToInt32(txbLessonId.Text)).ToString();
        }
    }
}
