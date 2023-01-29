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
    public partial class InputScore : Form
    {
        TeachingController teachingController = new TeachingController();
        StudyingController studyingController = new StudyingController();
        int lecId;
        int stuId;
        public InputScore(int id)
        {
            InitializeComponent();
            lecId = id;
            loadSemester();
            loadSchoolYear();
            loadData();
            
        }
        void loadSemester()
        {
            cmbSemester.Items.Add("1");
            cmbSemester.Items.Add("2");
            cmbSemester.SelectedIndex = 0;
        }
        void loadSchoolYear()
        {
            cmbSchoolYear.DataSource = teachingController.getAllSchoolYear(lecId);
        }

        void loadData()
        {

            dgvData.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
            col0.DataPropertyName = "ID";
            col0.HeaderText = "STT";


            dgvData.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.DataPropertyName = "StudentID";
            col1.HeaderText = "Student ID";

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.DataPropertyName = "LastName";
            col2.HeaderText = "LastName";

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.DataPropertyName = "FirstName";
            col3.HeaderText = "FirstName";

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.DataPropertyName = "AvgScore";
            col4.HeaderText = "Average score";

            dgvData.Columns.Add(col0);
            dgvData.Columns.Add(col1);
            dgvData.Columns.Add(col2);
            dgvData.Columns.Add(col3);
            dgvData.Columns.Add(col4);

            dgvData.Columns[0].Visible = false;


        }

        void addBinding()
        {
            //txbID.DataBindings.Clear();
            txbScore.DataBindings.Clear();
            //txbID.DataBindings.Add("Text", dgvData.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txbScore.DataBindings.Add("Text", dgvData.DataSource, "AvgScore", true, DataSourceUpdateMode.Never);
        }

        private void cmbClassModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLoadClassModule_Click(object sender, EventArgs e)
        {
            //int semester = Convert.ToInt32(cmbSemester.Text);
            //int schoolYear = Convert.ToInt32(cmbSchoolYear.SelectedValue.ToString());
            //cmbClassModule.DataSource = teachingController.getAllClassModule(semester, schoolYear, lecId);
        }

        private void btnViewScore_Click(object sender, EventArgs e)
        {
            int semester = Convert.ToInt32(cmbSemester.Text);
            int schoolYear = Convert.ToInt32(cmbSchoolYear.SelectedValue.ToString());
            string classModule = Convert.ToString(cmbClassModule.SelectedValue.ToString());
            dgvData.DataSource = teachingController.getAllScore(semester, schoolYear, classModule);
            addBinding();
        }

        private void btnInputScore_Click(object sender, EventArgs e)
        {

            studying studying = new studying()
            {
                id = Convert.ToInt32(this.dgvData.CurrentRow.Cells[0].Value),
                score = Convert.ToDouble(txbScore.Text),
            };
            teachingController.updateScore(studying);

            int semester = Convert.ToInt32(cmbSemester.Text);
            int schoolYear = Convert.ToInt32(cmbSchoolYear.SelectedValue.ToString());
            string classModule = Convert.ToString(cmbClassModule.SelectedValue.ToString());
            dgvData.DataSource = teachingController.getAllScore(semester, schoolYear, classModule);
            addBinding();

        }

        private void cmbClassModule_Click(object sender, EventArgs e)
        {
            int semester = Convert.ToInt32(cmbSemester.Text);
            int schoolYear = Convert.ToInt32(cmbSchoolYear.SelectedValue.ToString());
            cmbClassModule.DataSource = teachingController.getAllClassModule(semester, schoolYear, lecId);
        }
    }
}
