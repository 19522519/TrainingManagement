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
    public partial class LecturerManagement : Form
    {
        LecturerController lecturerController = new LecturerController();
        MajorController majorController = new MajorController();
        public LecturerManagement()
        {
            InitializeComponent();
            LoadData();
            loadLevel();
            loadContract();
            cmbMajor.DataSource = majorController.getAll();
            cmbMajor.DisplayMember = "Name";
            cmbMajor.ValueMember = "ID";
        }

        void LoadData()
        {
            dgvData.DataSource = lecturerController.getAll();
            addBinding();
        }

        public void loadLevel()
        {
            cmbLevel.Items.Add("bachelor");
            cmbLevel.Items.Add("master");
            cmbLevel.Items.Add("doctor");
            cmbLevel.Items.Add("professor");
            cmbLevel.SelectedIndex = 0;
        }

        public void loadContract()
        {
            cmbContract.Items.Add("Hợp đồng chính thức ");
            cmbContract.Items.Add("Giảng viên mời giảng");
            cmbContract.Items.Add("Giảng viên thỉnh giảng");
            cmbContract.SelectedIndex = 0;
        }

      

        void addBinding()
        {
            txtID.DataBindings.Clear();
            txtName.DataBindings.Clear();
            cmbMajor.DataBindings.Clear();
            cmbLevel.DataBindings.Clear();
            cmbContract.DataBindings.Clear();
            
            txtID.DataBindings.Add("Text", dgvData.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txtName.DataBindings.Add("Text", dgvData.DataSource, "Name", true, DataSourceUpdateMode.Never);
            cmbMajor.DataBindings.Add("Text", dgvData.DataSource, "Major", true, DataSourceUpdateMode.Never);
            cmbLevel.DataBindings.Add("Text", dgvData.DataSource, "Level", true, DataSourceUpdateMode.Never);
            cmbContract.DataBindings.Add("Text", dgvData.DataSource, "Contract", true, DataSourceUpdateMode.Never);
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnUpdate_Click_1(object sender, EventArgs e)
        {

            lecturer lecturer = new lecturer()
            {
                id = Convert.ToInt32(txtID.Text),
                name = txtName.Text,
                major_id = (int)cmbMajor.SelectedValue,
                level = cmbLevel.Text,
                contract = cmbContract.Text,
            };
            lecturerController.updateLecturer(lecturer);
            LoadData();
        }

        private void btnReload_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

            lecturer lecturer = new lecturer()
            {
                name = txtName.Text,
                major_id = (int)cmbMajor.SelectedValue,
                level = cmbLevel.Text,
                contract = cmbContract.Text,
            };
            lecturerController.insertLecturer(lecturer);
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to remove this lecturer", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lecturerController.deleteLecturer(Int32.Parse(txtID.Text));
                LoadData();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = lecturerController.findLecturer(txtFind.Text);
            addBinding();
        }
    }
}
