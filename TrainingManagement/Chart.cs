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
    public partial class Chart : Form
    {
        LessonController lessonController = new LessonController();
        ClassModuleController classModuleController = new ClassModuleController();

        public Chart()
        {
            InitializeComponent();
            loadSemester();
            loadSchoolYear();
            loadMajor();
        }

        public void loadSemester()
        {
            cmbSemester.Items.Add("1");
            cmbSemester.Items.Add("2");
            cmbSemester.SelectedIndex = 0;
        }

        void loadSchoolYear()
        {
            cmbSchoolYear.DataSource = classModuleController.getAllSchoolYear();
            cmbSchoolYear.DisplayMember = "SchoolYear";
            cmbSchoolYear.SelectedIndex = 0;
        }

        public void loadMajor()
        {
            cmbMajor.Items.Add("Software Engirneering");
            cmbMajor.Items.Add("Information System");
            cmbMajor.Items.Add("Computer Science");
            cmbMajor.SelectedIndex = 0;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            chart1.DataSource = lessonController.calculateStudentRegisterModule(cmbMajor.Text, cmbSchoolYear.Text, cmbSemester.Text);
            chart1.Series["Series1"].XValueMember = "ClassCode";
            chart1.Series["Series1"].YValueMembers = "ActualSize";

            chart1.Titles.Clear();
            chart1.Titles.Add("The number of student registering modules");
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //Ẩn đường lưới dọc
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
        }
    }
}
