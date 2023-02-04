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
            pnlContent.Controls.Clear();
            LecturerProfile lecturerProfile = new LecturerProfile(lecturerId);
            lecturerProfile.TopLevel = false;
            lecturerProfile.AutoScroll = true;
            lecturerProfile.Dock = DockStyle.Fill;
            lecturerProfile.FormBorderStyle = FormBorderStyle.None;
            this.pnlContent.Controls.Add(lecturerProfile);
            lecturerProfile.Show();
        }

        private void điểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            InputScore inputScore = new InputScore(lecturerId);
            inputScore.TopLevel = false;
            inputScore.AutoScroll = true;
            inputScore.Dock = DockStyle.Fill;
            inputScore.FormBorderStyle = FormBorderStyle.None;
            this.pnlContent.Controls.Add(inputScore);
            inputScore.Show();
        }

        private void timeableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            LecturerTimeable lecturerTimeable = new LecturerTimeable(lecturerId);
            lecturerTimeable.TopLevel = false;
            lecturerTimeable.AutoScroll = true;
            lecturerTimeable.Dock = DockStyle.Fill;
            lecturerTimeable.FormBorderStyle = FormBorderStyle.None;
            this.pnlContent.Controls.Add(lecturerTimeable);
            lecturerTimeable.Show();
        }

        private void exitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Hide();
            login.ShowDialog();
            Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripMenuItem item in ((ToolStrip)sender).Items)
            {
                if (item == e.ClickedItem)
                {
                    item.BackColor = Color.White;
                    item.ForeColor = Color.Black;
                }
                else
                {
                    item.BackColor = Color.Teal;
                    item.ForeColor = Color.White;
                }
            }
        }

        private void classesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            ClassManagement classManagement = new ClassManagement(lecturerId);
            classManagement.TopLevel = false;
            classManagement.AutoScroll = true;
            classManagement.Dock = DockStyle.Fill;
            classManagement.FormBorderStyle = FormBorderStyle.None;
            this.pnlContent.Controls.Add(classManagement);
            classManagement.Show();
        }
    }
}
