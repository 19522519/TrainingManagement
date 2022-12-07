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
    public partial class DepartmentManagerHomePage : Form
    {
        public DepartmentManagerHomePage()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void côngNghệPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassModulesManagement modulesManagement = new ClassModulesManagement("Kỹ thuật phần mềm");
            modulesManagement.TopLevel = false;
            modulesManagement.AutoScroll = true;
            modulesManagement.Dock = DockStyle.Fill;
            modulesManagement.FormBorderStyle = FormBorderStyle.None;
            pnlContent.Controls.Add(modulesManagement);
            modulesManagement.Show();
        }

        private void hệThốngThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassModulesManagement modulesManagement = new ClassModulesManagement("Hệ thống thông tin");
            modulesManagement.TopLevel = false;
            modulesManagement.AutoScroll = true;
            modulesManagement.Dock = DockStyle.Fill;
            modulesManagement.FormBorderStyle = FormBorderStyle.None;
            pnlContent.Controls.Add(modulesManagement);
            modulesManagement.Show();
        }
    }
}
