using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using TrainingManagement.Controller;

namespace TrainingManagement
{
    public partial class StudentModuleRegister : Form
    {
        int stuId = 0;
        LessonController lessonController = new LessonController();
        StudyingController studyingController = new StudyingController();
        ClassModuleController classModuleController = new ClassModuleController();

        public StudentModuleRegister(int id)
        {
            InitializeComponent();
            stuId = id;

            loadAllClassModules();

            loadAllClassModulesRegistered();
        }

        public void addBidingClassModule()
        {
            txbLessonId.DataBindings.Clear();
            txbLessonId.DataBindings.Add("Text", dgvClassModules.DataSource, "Id", true, DataSourceUpdateMode.Never);
        }

        public void addBidingClassModuleRegistered()
        {
            txbStudyingId.DataBindings.Clear();
            txbStudyingId.DataBindings.Add("Text", dgvClassModulesRegistered.DataSource, "Id", true, DataSourceUpdateMode.Never);
        }

        public void loadAllClassModules()
        {
            dgvClassModules.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.DataPropertyName = "Id";
            col1.HeaderText = "Id";

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.DataPropertyName = "ClassCode";
            col2.HeaderText = "Class code";

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.DataPropertyName = "ClassName";
            col3.HeaderText = "Class name";

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.DataPropertyName = "Credits";
            col4.HeaderText = "Credits";

            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.DataPropertyName = "Day";
            col5.HeaderText = "Day";

            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
            col6.DataPropertyName = "StartTime";
            col6.HeaderText = "Start time";

            DataGridViewTextBoxColumn col7 = new DataGridViewTextBoxColumn();
            col7.DataPropertyName = "EndTime";
            col7.HeaderText = "End time";

            DataGridViewTextBoxColumn col8 = new DataGridViewTextBoxColumn();
            col8.DataPropertyName = "Room";
            col8.HeaderText = "Room";

            DataGridViewTextBoxColumn col9 = new DataGridViewTextBoxColumn();
            col9.DataPropertyName = "Size";
            col9.HeaderText = "Size";

            DataGridViewTextBoxColumn col10 = new DataGridViewTextBoxColumn();
            col10.DataPropertyName = "Lecturer";
            col10.HeaderText = "Lecturer";

            DataGridViewTextBoxColumn col11 = new DataGridViewTextBoxColumn();
            col11.DataPropertyName = "StartDate";
            col11.HeaderText = "Start date";

            DataGridViewTextBoxColumn col12 = new DataGridViewTextBoxColumn();
            col12.DataPropertyName = "EndDate";
            col12.HeaderText = "End date";

            DataGridViewTextBoxColumn col13 = new DataGridViewTextBoxColumn();
            col13.DataPropertyName = "Semester";
            col13.HeaderText = "Semester";

            DataGridViewTextBoxColumn col14 = new DataGridViewTextBoxColumn();
            col14.DataPropertyName = "SchoolYear";
            col14.HeaderText = "School year";

            DataGridViewTextBoxColumn col15 = new DataGridViewTextBoxColumn();
            col15.DataPropertyName = "TrainingType";
            col15.HeaderText = "Training type";

            DataGridViewTextBoxColumn col16 = new DataGridViewTextBoxColumn();
            col16.DataPropertyName = "TrainingSystem";
            col16.HeaderText = "Training system";

            dgvClassModules.Columns.Add(col1);
            dgvClassModules.Columns.Add(col2);
            dgvClassModules.Columns.Add(col3);
            dgvClassModules.Columns.Add(col4);
            dgvClassModules.Columns.Add(col5);
            dgvClassModules.Columns.Add(col6);
            dgvClassModules.Columns.Add(col7);
            dgvClassModules.Columns.Add(col8);
            dgvClassModules.Columns.Add(col9);
            dgvClassModules.Columns.Add(col10);
            dgvClassModules.Columns.Add(col11);
            dgvClassModules.Columns.Add(col12);
            dgvClassModules.Columns.Add(col13);
            dgvClassModules.Columns.Add(col14);
            dgvClassModules.Columns.Add(col15);
            dgvClassModules.Columns.Add(col16);

            dgvClassModules.DataSource = lessonController.getAllLessonsWithOpen();
            addBidingClassModule();
        }

        public void loadAllClassModulesRegistered()
        {
            dgvClassModulesRegistered.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.DataPropertyName = "Id";
            col1.HeaderText = "Id";

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.DataPropertyName = "ClassCode";
            col2.HeaderText = "Class code";

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.DataPropertyName = "ClassName";
            col3.HeaderText = "Class name";

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.DataPropertyName = "Credits";
            col4.HeaderText = "Credits";

            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.DataPropertyName = "Day";
            col5.HeaderText = "Day";

            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
            col6.DataPropertyName = "StartTime";
            col6.HeaderText = "Start time";

            DataGridViewTextBoxColumn col7 = new DataGridViewTextBoxColumn();
            col7.DataPropertyName = "EndTime";
            col7.HeaderText = "End time";

            DataGridViewTextBoxColumn col8 = new DataGridViewTextBoxColumn();
            col8.DataPropertyName = "Room";
            col8.HeaderText = "Room";

            DataGridViewTextBoxColumn col9 = new DataGridViewTextBoxColumn();
            col9.DataPropertyName = "Size";
            col9.HeaderText = "Size";

            DataGridViewTextBoxColumn col10 = new DataGridViewTextBoxColumn();
            col10.DataPropertyName = "Lecturer";
            col10.HeaderText = "Lecturer";

            DataGridViewTextBoxColumn col11 = new DataGridViewTextBoxColumn();
            col11.DataPropertyName = "StartDate";
            col11.HeaderText = "Start date";

            DataGridViewTextBoxColumn col12 = new DataGridViewTextBoxColumn();
            col12.DataPropertyName = "EndDate";
            col12.HeaderText = "End date";

            DataGridViewTextBoxColumn col13 = new DataGridViewTextBoxColumn();
            col13.DataPropertyName = "Semester";
            col13.HeaderText = "Semester";

            DataGridViewTextBoxColumn col14 = new DataGridViewTextBoxColumn();
            col14.DataPropertyName = "SchoolYear";
            col14.HeaderText = "School year";

            DataGridViewTextBoxColumn col15 = new DataGridViewTextBoxColumn();
            col15.DataPropertyName = "TrainingType";
            col15.HeaderText = "Training type";

            DataGridViewTextBoxColumn col16 = new DataGridViewTextBoxColumn();
            col16.DataPropertyName = "TrainingSystem";
            col16.HeaderText = "Training system";

            dgvClassModulesRegistered.Columns.Add(col1);
            dgvClassModulesRegistered.Columns.Add(col2);
            dgvClassModulesRegistered.Columns.Add(col3);
            dgvClassModulesRegistered.Columns.Add(col4);
            dgvClassModulesRegistered.Columns.Add(col5);
            dgvClassModulesRegistered.Columns.Add(col6);
            dgvClassModulesRegistered.Columns.Add(col7);
            dgvClassModulesRegistered.Columns.Add(col8);
            dgvClassModulesRegistered.Columns.Add(col9);
            dgvClassModulesRegistered.Columns.Add(col10);
            dgvClassModulesRegistered.Columns.Add(col11);
            dgvClassModulesRegistered.Columns.Add(col12);
            dgvClassModulesRegistered.Columns.Add(col13);
            dgvClassModulesRegistered.Columns.Add(col14);
            dgvClassModulesRegistered.Columns.Add(col15);
            dgvClassModulesRegistered.Columns.Add(col16);

            dgvClassModulesRegistered.DataSource = studyingController.getAllStudyingWithoutScore();
            addBidingClassModuleRegistered();

            // Calculate total of credits of class module registered by student
            int totalCredits = 0;
            foreach (var data in studyingController.getAllStudyingWithoutScore())
            {
                totalCredits += data.Credits;
            }
            txbTotalCredtis.Text = totalCredits.ToString();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool isExist = false;
            studying studying = new studying();
            int lessonId = Convert.ToInt32(txbLessonId.Text);

            // Check class module is registered before
            foreach (var data in studyingController.getAllStudying(stuId))
            {
                if(data.LessonId == lessonId)
                {
                    isExist = true;
                }
            }
            if(isExist == false)
            {
                int studyingId = studyingController.insertStudying(stuId, lessonId, studying);
                loadAllClassModulesRegistered();

                int classModuleId = lessonController.findClassModuleBasedOnLesson(lessonId);             
                string className = classModuleController.getClassModuleById(classModuleId);

                // Update the quantity of class members               
                classModuleController.setActualSizePlusByLessonId(lessonId);

                MessageBox.Show("Regiter class module " + className + " successfully!");
            } else
            {
                int classModuleId = lessonController.findClassModuleBasedOnLesson(lessonId);
                string className = classModuleController.getClassModuleById(classModuleId);
                MessageBox.Show("You have registered " + className + " before!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            studyingController.deleteStudying(Convert.ToInt32(txbStudyingId.Text));

            // Update the quantity of class members               
            classModuleController.setActualSizePlusByLessonId(Convert.ToInt32(txbStudyingId.Text));
            loadAllClassModulesRegistered();
        }
    }
}
