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
    public partial class StudentHomePage : Form
    {
        StudentController studentController = new StudentController();
        int studentId;

        public StudentHomePage(int id)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            studentId = id;
            student student = studentController.getStudentById(studentId);
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            StudentProfile studentProfile = new StudentProfile(studentId);
            studentProfile.TopLevel = false;
            studentProfile.AutoScroll = true;
            studentProfile.Dock = DockStyle.Fill;
            studentProfile.FormBorderStyle = FormBorderStyle.None;
            this.pnlContent.Controls.Add(studentProfile);
            studentProfile.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void điểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            ViewScore viewScore = new ViewScore(studentId);
            viewScore.TopLevel = false;
            viewScore.AutoScroll = true;
            viewScore.Dock = DockStyle.Fill;
            viewScore.FormBorderStyle = FormBorderStyle.None;
            this.pnlContent.Controls.Add(viewScore);
            viewScore.Show();
        }
    }
}
