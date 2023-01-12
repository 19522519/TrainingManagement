using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingManagement
{
    public partial class DepartmentHomePage : Form
    {
        string major;

        public DepartmentHomePage(string right)
        {
            InitializeComponent();
            major = right;
        }

        private void moduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuleManagement moduleManagement = new ModuleManagement(major);
            moduleManagement.TopLevel = false;
            moduleManagement.AutoScroll = true;
            moduleManagement.Dock = DockStyle.Fill;
            moduleManagement.FormBorderStyle = FormBorderStyle.None;
            pnlContent.Controls.Add(moduleManagement);
            moduleManagement.Show();
        }

        private void curriculumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurriculumManagement curriculumManagement = new CurriculumManagement(major);
            curriculumManagement.TopLevel = false;
            curriculumManagement.AutoScroll = true;
            curriculumManagement.Dock = DockStyle.Fill;
            curriculumManagement.FormBorderStyle = FormBorderStyle.None;
            pnlContent.Controls.Add(curriculumManagement);
            curriculumManagement.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
