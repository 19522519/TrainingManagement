using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingManagement.Controller;

namespace TrainingManagement
{
    public partial class LecturerManagement : Form
    {
        LecturerController lecturerController = new LecturerController();
        UserController userController = new UserController();
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
            loadFindMajor();
        }

        void LoadData()
        {
            dgvData.DataSource = lecturerController.getAll();
            addBinding();
        }

        public void loadFindMajor()
        {
            cmbFindMajor.DataSource = majorController.getAll();
            cmbFindMajor.DisplayMember = "Name";
            cmbFindMajor.ValueMember = "ID";
        }

        public void loadLevel()
        {
            cmbLevel.Items.Add("Bachelor");
            cmbLevel.Items.Add("Master");
            cmbLevel.Items.Add("Doctor");
            cmbLevel.Items.Add("Professor");
            cmbLevel.SelectedIndex = 0;
        }

        public void loadContract()
        {
            cmbContract.Items.Add("Hop dong chinh thuc");
            cmbContract.Items.Add("Giang vien moi giang");
            cmbContract.Items.Add("Giang vien thinh giang");
            cmbContract.SelectedIndex = 0;
        }

        void addBinding()
        {
            txtID.DataBindings.Clear();
            txtName.DataBindings.Clear();
            cmbMajor.DataBindings.Clear();
            cmbLevel.DataBindings.Clear();
            cmbContract.DataBindings.Clear();
            txbEmail.DataBindings.Clear();
            txbUsername.DataBindings.Clear();
            txbPassword.DataBindings.Clear();
            
            txtID.DataBindings.Add("Text", dgvData.DataSource, "ID", true, DataSourceUpdateMode.Never);
            txtName.DataBindings.Add("Text", dgvData.DataSource, "Name", true, DataSourceUpdateMode.Never);
            cmbMajor.DataBindings.Add("Text", dgvData.DataSource, "Major", true, DataSourceUpdateMode.Never);
            cmbLevel.DataBindings.Add("Text", dgvData.DataSource, "Level", true, DataSourceUpdateMode.Never);
            cmbContract.DataBindings.Add("Text", dgvData.DataSource, "Contract", true, DataSourceUpdateMode.Never);
            txbEmail.DataBindings.Add("Text", dgvData.DataSource, "Email", true, DataSourceUpdateMode.Never);
            txbUsername.DataBindings.Add("Text", dgvData.DataSource, "Username", true, DataSourceUpdateMode.Never);
        }

        public string getMD5(string chuoi)
        {
            string str_md5 = "";
            byte[] mang = System.Text.Encoding.UTF8.GetBytes(chuoi);

            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            mang = my_md5.ComputeHash(mang);

            foreach (byte b in mang)
            {
                str_md5 += b.ToString("X2");    // Convert to upper case
            }

            return str_md5;
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
                contract = cmbContract.Text
            };

            users users = new users()
            {
                username = txbUsername.Text,
                email = txbEmail.Text,
                pass = getMD5(txbPassword.Text)
            };

            lecturerController.updateLecturer(lecturer, users);
            LoadData();
            MessageBox.Show("Update lecturer successfully!");
        }

        private void btnReload_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            users users = new users()
            {
                email = txbEmail.Text,
                pass = getMD5(txbPassword.Text),
                username = txbUsername.Text,
                access_right = "Lecturer",
            };
            int userId = userController.insertUser(users);

            lecturer lecturer = new lecturer()
            {
                name = txtName.Text,
                major_id = (int)cmbMajor.SelectedValue,
                level = cmbLevel.Text,
                contract = cmbContract.Text,
            };
            lecturerController.insertLecturer(lecturer, userId);
            LoadData();
            MessageBox.Show("Insert lecturer successfully!");
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
            dgvData.DataSource = lecturerController.findLecturer(txtFind.Text, cmbFindMajor.Text);
            addBinding();
        }
    }
}
