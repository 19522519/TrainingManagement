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
    public partial class TrainingManagerHomePage : Form
    {
        public TrainingManagerHomePage()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void registerModulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            OpenRegisterModules openRegisterModules = new OpenRegisterModules();
            openRegisterModules.TopLevel = false;
            openRegisterModules.AutoScroll = true;
            openRegisterModules.Dock = DockStyle.Fill;
            openRegisterModules.FormBorderStyle = FormBorderStyle.None;
            pnlContent.Controls.Add(openRegisterModules);
            openRegisterModules.Show();
        }

        private void lecturerManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            LecturerManagement lecturerManagement = new LecturerManagement();
            lecturerManagement.TopLevel = false;
            lecturerManagement.AutoScroll = true;
            lecturerManagement.Dock = DockStyle.Fill;
            lecturerManagement.FormBorderStyle = FormBorderStyle.None;
            pnlContent.Controls.Add(lecturerManagement);
            lecturerManagement.Show();
        }

        private void studentManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            StudentManagement studentManagement = new StudentManagement();
            studentManagement.TopLevel = false;
            studentManagement.AutoScroll = true;
            studentManagement.Dock = DockStyle.Fill;
            studentManagement.FormBorderStyle = FormBorderStyle.None;
            pnlContent.Controls.Add(studentManagement);
            studentManagement.Show();
        }
    }
}
