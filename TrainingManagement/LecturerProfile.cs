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
    public partial class LecturerProfile : Form
    {
        LecturerController lecturerController = new LecturerController();
        lecturer lecturer;
        int lecId;

        public LecturerProfile(int id)
        {
            lecId = id;
            InitializeComponent();
            lecturer = lecturerController.getLecturerById(id);
            txtName.Text = lecturer.name;
            txtLevel.Text = lecturer.level;
            txtContract.Text = lecturer.contract;
            txtMajor.Text = lecturer.major.name;
            txtEmail.Text = lecturer.users.email;
            txtUsername.Text = lecturer.users.username;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LecturerProfile_Load(object sender, EventArgs e)
        {
            txtName.Focus();
            txtLevel.Focus();
            txtContract.Focus();
            txtMajor.Focus();
            txtEmail.Focus();
            txtUsername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
          
        }
    }
}
