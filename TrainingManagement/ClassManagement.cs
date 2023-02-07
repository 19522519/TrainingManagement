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
    public partial class ClassManagement : Form
    {
        int lecturerId;
        TeachingController teachingController = new TeachingController();

        public ClassManagement(int id)
        {
            InitializeComponent();
            lecturerId = id;

            loadSemester();
            loadSchoolYear();
        }

        public void loadSemester()
        {
            cmbSemester.Items.Add("1");
            cmbSemester.Items.Add("2");
            cmbSemester.SelectedIndex = 0;
        }

        public void loadSchoolYear()
        {
            cmbSchoolYear.DataSource = teachingController.getAllSchoolYear(lecturerId);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "*.xls|.xls";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "Sheet1";
                // storing header part in Excel  
                for (int i = 1; i < dgvClass.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgvClass.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                for (int i = 0; i < dgvClass.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvClass.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvClass.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // save the application  
                workbook.SaveAs(dialog.InitialDirectory + dialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application  
                // app.Quit();
                // MessageBox.Show("Export to file excel successfully!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvClass.DataSource = teachingController.getAllClassModuleBySemesterAndSchoolYearAndLecturer(cmbSemester.Text, cmbSchoolYear.Text, lecturerId);
        }
    }
}
