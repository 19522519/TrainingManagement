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
            pnlContent.Controls.Clear();
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
            pnlContent.Controls.Clear();
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
            Login login = new Login();
            Hide();
            login.ShowDialog();
            Close();
        }

        private void classModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            ClassModulesManagement classModulesManagement = new ClassModulesManagement(major);
            classModulesManagement.TopLevel = false;
            classModulesManagement.AutoScroll = true;
            classModulesManagement.Dock = DockStyle.Fill;
            classModulesManagement.FormBorderStyle = FormBorderStyle.None;
            pnlContent.Controls.Add(classModulesManagement);
            classModulesManagement.Show();
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
    }
}
