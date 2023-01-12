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
    public partial class ModuleManagement : Form
    {
        string right; 
        CurriculumController curriculumController = new CurriculumController();

        public ModuleManagement(string role)
        {
            InitializeComponent();

            right = role;
            changeRoleName();

            loadSchoolYear();
        }

        // Đổi từ SEDean sang Software Engirneering / CSDean sang Computer Science / ISDean sang Information System
        void changeRoleName()
        {
            switch(right)
            {
                case "SEDean":
                    right = "Software Engirneering";
                    break;
                case "CSDean":
                    right = "Computer Science";
                    break;
                case "ISDean":
                    right = "Information System";
                    break;
            }
        }

        void loadSchoolYear()
        {
            cmbSchoolYear.DataSource = curriculumController.getAllSchoolYearOnMajor(right);
            cmbSchoolYear.DisplayMember = "SchoolYear";
            cmbSchoolYear.SelectedIndex = 0;
        }

        void loadCurriculumBasedOnSchoolYear()
        {
            int val = 0;
            bool result = int.TryParse(cmbSchoolYear.Text, out val);
            if (!result)
            {
                try
                {
                    cmbCurriculum.DataSource = curriculumController.getAllCurriculumNameOnYearAndMajor(Convert.ToInt32(cmbSchoolYear.Text), right);
                    cmbCurriculum.DisplayMember = "Name";
                } catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            } else
            {
                // MessageBox.Show(cmbSchoolYear.Text);
                cmbCurriculum.DataSource = curriculumController.getAllCurriculumNameOnYearAndMajor(Convert.ToInt32(cmbSchoolYear.Text), right);
                cmbCurriculum.DisplayMember = "Name";
            }

        }

        private void cmbSchoolYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCurriculumBasedOnSchoolYear();
        }
    }
}
