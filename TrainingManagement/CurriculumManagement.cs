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
    public partial class CurriculumManagement : Form
    {
        MajorController majorController = new MajorController();
        CurriculumController curriculumController = new CurriculumController();
        String major;

        public CurriculumManagement(String majorParam)
        {
            InitializeComponent();
            major = majorParam;
            loadData();
;           loadTrainingSystem();
            loadTrainingType();
        }

        void loadTrainingSystem()
        {
            cmbTrainingSystem.Items.Add("University");
            cmbTrainingSystem.Items.Add("College");
            cmbTrainingSystem.SelectedIndex = 0;
        }

        void loadTrainingType()
        {
            cmbTrainingType.Items.Add("Formal System");         // Chương trình chính quy
            cmbTrainingType.Items.Add("Bridge Program");        // Chương trình liên thông
            cmbTrainingType.Items.Add("Work-Study Program");    // Chương trình vừa học vừa làm
        }

        void loadData()
        {
            dgvData.DataSource = curriculumController.getAll(major);
            addBiding();
        }

        void addBiding()
        {
            txtId.DataBindings.Clear();
            txtName.DataBindings.Clear();
            cmbTrainingSystem.DataBindings.Clear();
            cmbTrainingType.DataBindings.Clear();
            txbSchoolYear.DataBindings.Clear();

            txtId.DataBindings.Add("Text", dgvData.DataSource, "Id", true, DataSourceUpdateMode.Never);
            txtName.DataBindings.Add("Text", dgvData.DataSource, "Name", true, DataSourceUpdateMode.Never);    
            cmbTrainingSystem.DataBindings.Add("Text", dgvData.DataSource, "TrainingSystem", true, DataSourceUpdateMode.Never);           
            cmbTrainingType.DataBindings.Add("Text", dgvData.DataSource, "TrainingType", true, DataSourceUpdateMode.Never);
            txbSchoolYear.DataBindings.Add("Text", dgvData.DataSource, "SchoolYear", true, DataSourceUpdateMode.Never);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            curriculum curriculum = new curriculum()
            {
                name = txtName.Text,
                training_system = cmbTrainingSystem.Text,
                training_type = cmbTrainingType.Text,
                school_year = txbSchoolYear.Text
            };

            curriculumController.insertCurriculum(curriculum, major);
            MessageBox.Show("Create successfully!");
            loadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            curriculum curriculum = new curriculum()
            {
                id = Convert.ToInt32(txtId.Text),
                name = txtName.Text,
                training_system = cmbTrainingSystem.Text,
                training_type = cmbTrainingType.Text,
                school_year = txbSchoolYear.Text
            };
            curriculumController.updateCurriculum(curriculum);

            MessageBox.Show("Update successfully!");
            loadData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
