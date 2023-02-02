using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using TrainingManagement.Controller;
using Timer = System.Windows.Forms.Timer;

namespace TrainingManagement
{
    public partial class OpenRegisterModules : Form
    {
        LessonController lessonController = new LessonController();
        ClassModuleController classModuleController = new ClassModuleController();
        Timer timer;

        public OpenRegisterModules()
        {
            InitializeComponent();

            loadSemester();
            loadSchoolYear();

            loadAllClassModules();
            dgvClassModules.DataSource = lessonController.getAllLessons(cmbSemester.Text, cmbSchoolYear.Text);
            addBidingClassModule();

            timer = new Timer();
            timer.Tick += timer1_Tick;
            timer.Interval = Convert.ToInt32(nudTimer.Value);
            timer.Enabled = true;
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

        public void addBidingClassModule()
        {
            txbLessonId.DataBindings.Clear();
            txbLessonId.DataBindings.Add("Text", dgvClassModules.DataSource, "Id", true, DataSourceUpdateMode.Never);
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
            col13.DataPropertyName = "TheoryLessons";
            col13.HeaderText = "Theory lessons";

            DataGridViewTextBoxColumn col14 = new DataGridViewTextBoxColumn();
            col14.DataPropertyName = "PracticeLessons";
            col14.HeaderText = "Practice lessons";

            DataGridViewTextBoxColumn col15 = new DataGridViewTextBoxColumn();
            col15.DataPropertyName = "SelfStudyLessons";
            col15.HeaderText = "Self-study lessons";

            DataGridViewTextBoxColumn col16 = new DataGridViewTextBoxColumn();
            col16.DataPropertyName = "VisitingLessons";
            col16.HeaderText = "Visiting lessons";

            DataGridViewTextBoxColumn col17 = new DataGridViewTextBoxColumn();
            col17.DataPropertyName = "Semester";
            col17.HeaderText = "Semester";

            DataGridViewTextBoxColumn col18 = new DataGridViewTextBoxColumn();
            col18.DataPropertyName = "SchoolYear";
            col18.HeaderText = "School year";

            DataGridViewTextBoxColumn col19 = new DataGridViewTextBoxColumn();
            col19.DataPropertyName = "Curriculum";
            col19.HeaderText = "Curriculum";

            DataGridViewTextBoxColumn col20 = new DataGridViewTextBoxColumn();
            col20.DataPropertyName = "TrainingType";
            col20.HeaderText = "Training type";

            DataGridViewTextBoxColumn col21 = new DataGridViewTextBoxColumn();
            col21.DataPropertyName = "TrainingSystem";
            col21.HeaderText = "Training system";

            DataGridViewTextBoxColumn col22 = new DataGridViewTextBoxColumn();
            col22.DataPropertyName = "Register";
            col22.HeaderText = "Allow register";

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
            dgvClassModules.Columns.Add(col17);
            dgvClassModules.Columns.Add(col18);
            dgvClassModules.Columns.Add(col19);
            dgvClassModules.Columns.Add(col20);
            dgvClassModules.Columns.Add(col21);
            dgvClassModules.Columns.Add(col22);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var classModuleList = new List<class_module>();
            foreach (var lesson in lessonController.getAllLessons(cmbSemester.Text, cmbSchoolYear.Text)) 
            {
                classModuleController.setRegister(lesson.Id, "open");
            }
            dgvClassModules.DataSource = lessonController.getAllLessons(cmbSemester.Text, cmbSchoolYear.Text);
            addBidingClassModule();
            MessageBox.Show("Open class modules with semester: " + cmbSemester.Text + " and school year: " + cmbSchoolYear.Text + " successfully!");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvClassModules.DataSource = lessonController.getAllLessons(cmbSemester.Text, cmbSchoolYear.Text);
            addBidingClassModule();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            foreach (var lesson in lessonController.getAllLessons(cmbSemester.Text, cmbSchoolYear.Text))
            {
                classModuleController.setRegister(lesson.Id, "close");
            }
            dgvClassModules.DataSource = lessonController.getAllLessons(cmbSemester.Text, cmbSchoolYear.Text);
            addBidingClassModule();
            MessageBox.Show("Close class modules with semester: " + cmbSemester.Text + " and school year: " + cmbSchoolYear.Text + " successfully!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(nudTimer.Value) != 0)
                timer.Start();
                // 5s sau đóng dkhp
                // Thread.Sleep(5000);
                foreach (var lesson in lessonController.getAllLessons(cmbSemester.Text, cmbSchoolYear.Text))
                {
                    classModuleController.setRegister(lesson.Id, "close");
                }
                dgvClassModules.DataSource = lessonController.getAllLessons(cmbSemester.Text, cmbSchoolYear.Text);
                addBidingClassModule();
                // MessageBox.Show("Close class modules with semester: " + cmbSemester.Text + " and school year: " + cmbSchoolYear.Text + " successfully!");

                timer.Stop();
            
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "*.xls|.xls";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "Sheet1";
                // storing header part in Excel  
                for (int i = 1; i < dgvClassModules.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgvClassModules.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dgvClassModules.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvClassModules.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvClassModules.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // save the application  
                workbook.SaveAs(dialog.InitialDirectory + dialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application  
                // app.Quit();
                // MessageBox.Show("Export to file excel successfully!");
            }
        }
    }
}
