﻿using System;
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
    public partial class LecturerTimeable : Form
    {
        LessonController lessonController = new LessonController();
        TeachingController teachingController = new TeachingController();
        int lecId;

        public LecturerTimeable(int id)
        {
            InitializeComponent();
            lecId = id;
            loadSemester();
            loadSchoolYear();
            loadData();
        }

        void loadSemester()
        {
            cmbSemester.Items.Add('1');
            cmbSemester.Items.Add('2');
            cmbSemester.SelectedIndex = 0;
        }

        void loadSchoolYear()
        {
            cmbSchoolYear.DataSource = teachingController.getAllSchoolYear(lecId);
        }

        void loadData()
        {
            dgvData.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn col0 = new DataGridViewTextBoxColumn();
            col0.DataPropertyName = "ID";
            col0.HeaderText = "STT";


            dgvData.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.DataPropertyName = "ClassModuleID";
            col1.HeaderText = "Mã môn học";

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.DataPropertyName = "Name";
            col2.HeaderText = "Tên môn học";

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.DataPropertyName = "DayInWeek";
            col3.HeaderText = "Thứ";

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.DataPropertyName = "StartTime";
            col4.HeaderText = "Tiết bắt đầu";


            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.DataPropertyName = "EndTime";
            col5.HeaderText = "Tiết kết thúc";


            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
            col6.DataPropertyName = "MaxSize";
            col6.HeaderText = "Số lượng";


            DataGridViewTextBoxColumn col7 = new DataGridViewTextBoxColumn();
            col7.DataPropertyName = "StartDay";
            col7.HeaderText = "Ngày Bắt đầu";


            DataGridViewTextBoxColumn col8 = new DataGridViewTextBoxColumn();
            col8.DataPropertyName = "EndDay";
            col8.HeaderText = "Ngày Kết thúc";

            dgvData.Columns.Add(col0);
            dgvData.Columns.Add(col1);
            dgvData.Columns.Add(col2);
            dgvData.Columns.Add(col3);
            dgvData.Columns.Add(col4);
            dgvData.Columns.Add(col5);
            dgvData.Columns.Add(col6);
            dgvData.Columns.Add(col7);
            dgvData.Columns.Add(col8);

            dgvData.Columns[0].Visible = false;
        }

        private void btnTimeable_Click(object sender, EventArgs e)
        {
            int semester = Convert.ToInt32(cmbSemester.Text);
            int schoolYear = Convert.ToInt32(cmbSchoolYear.SelectedValue.ToString());
            dgvData.DataSource = lessonController.getAllTimeable(semester, schoolYear, lecId);
        }
    }
}