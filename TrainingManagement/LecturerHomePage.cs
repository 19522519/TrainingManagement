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
    public partial class LecturerHomePage : Form
    {
        LecturerController lecturerController = new LecturerController();
        int lecturerId;
        public LecturerHomePage(int id)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lecturerId = id;
            lecturer lecturer = lecturerController.getLecturerById(lecturerId);
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LecturerProfile lecturerProfile = new LecturerProfile(lecturerId);
            lecturerProfile.TopLevel = false;
            lecturerProfile.AutoScroll = true;
            lecturerProfile.Dock = DockStyle.Fill;
            lecturerProfile.FormBorderStyle = FormBorderStyle.None;
            this.pnlContent.Controls.Add(lecturerProfile);
            lecturerProfile.Show();
        }
    }
}
