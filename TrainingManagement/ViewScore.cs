using iTextSharp.text;
using iTextSharp.text.pdf;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingManagement.Controller;

namespace TrainingManagement
{
    public partial class ViewScore : Form
    {
        StudyingController studyingController = new StudyingController();
        StudentController studentController = new StudentController();
        int stuId;
        ScreenCapture screenCapture = new ScreenCapture();

        public ViewScore(int id)
        {
            InitializeComponent();
            stuId = id;
            loadSemester();
            loadSchoolYear();
            loadData();
            dgvData.DataSource = studyingController.getAllScore(stuId);

            lbTimetableTitle.Text = "LEARNING RESULT SEMESTER " + cmbSemester.Text + " SCHOOL YEAR " + cmbSchoolYear.Text;

            loadStudentDetail();
        }

        public void loadStudentDetail()
        {
            student student = studentController.getStudentById(stuId);
            txbName.Text = student.last_name + " " + student.first_name;
            txbStudentId.Text = student.ID_Student;
            txbBirthPlace.Text = student.birth_place;
            txbMajor.Text = student.major.name;
        }

        void loadSemester()
        {
            cmbSemester.Items.Add("1");
            cmbSemester.Items.Add("2");
            cmbSemester.SelectedIndex = 0;
        }

        void loadSchoolYear()
        {
            cmbSchoolYear.DataSource = studyingController.getAllSchoolYear(stuId);
            cmbSchoolYear.SelectedIndex = 0;
        }

        void loadData()
        {
            dgvData.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.DataPropertyName = "SchoolYear";
            col1.HeaderText = "School year";

            dgvData.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.DataPropertyName = "Semester";
            col2.HeaderText = "Semester";

            dgvData.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.DataPropertyName = "Name";
            col3.HeaderText = "Class name";

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.DataPropertyName = "ModuleCode";
            col4.HeaderText = "Class code";

            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.DataPropertyName = "Credits";
            col5.HeaderText = "Credits";

            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
            col6.DataPropertyName = "AvgScore";
            col6.HeaderText = "Score";

            dgvData.Columns.Add(col1);
            dgvData.Columns.Add(col2);
            dgvData.Columns.Add(col3);
            dgvData.Columns.Add(col4);
            dgvData.Columns.Add(col5);
            dgvData.Columns.Add(col6);
        }

        private void btnViewScore_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = studyingController.getAllScore(cmbSemester.Text, cmbSchoolYear.Text, stuId);
        }

        private void captureScreen()
        {
            try
            {
                // Call the CaptureAndSave method from the ScreenCapture class 
                // And create a temporary file in C:\Temp
                screenCapture.CaptureAndSave
                (@"C:\Temp\test.png", CaptureMode.Window, ImageFormat.Png);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            /*// Call your captureScreen() function
            captureScreen();

            // Create new pdf document and page
            PdfDocument doc = new PdfDocument();
            PdfPage oPage = new PdfPage();

            // Add the page to the pdf document and add the captured image to it
            doc.Pages.Add(oPage);
            XGraphics xgr = XGraphics.FromPdfPage(oPage);
            XImage img = XImage.FromFile(@"C:\Temp\test.png");
            xgr.DrawImage(img, 0, 0);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = ("PDF File|*.pdf");
            DialogResult btnSave = saveFileDialog.ShowDialog();
            if (btnSave.Equals(DialogResult.OK))
            {
                doc.Save(saveFileDialog.FileName);
                doc.Close();
            }

            // I used the Dispose() function to be able to 
            // save the same form again, in case some values have changed.
            // When I didn't use the function, a GDI+ error occurred.
            img.Dispose();*/


            // ReportDocument cryRpt = new ReportDocument();

            /*            MySqlDataAdapter adap2;
                        cmd = con.CreateCommand();
                        ReportDocument cryRpt2 = new ReportDocument();
                        StrSearch = " SELECT * FROM `expenses_db`";
                        cmd.CommandText = StrSearch;
                        adap2 = new MySqlDataAdapter();
                        adap2.SelectCommand = cmd;
                        DataSet custDB2 = new DataSet();
                        custDB2.Clear();
                        adap2.Fill(custDB2, "Expenses_db");
                        myReport.SetDataSource(custDB2);

                        crystalReportViewer1.ReportSource = myReport;
                        crystalReportViewer1.Refresh();
                        cryRpt = myReport;

                        cryRpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"C:\File1.pdf");*/


            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF files|*.pdf" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Document doc = new Document(iTextSharp.text.PageSize.A4, 10f, 10f, 10f, 0f);
                        doc.SetMargins(20f, 20f, 20f, 20f);
                        PdfWriter pdfWriter = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        PdfContentByte pdfContent = pdfWriter.DirectContent;
                        iTextSharp.text.Rectangle rectangle = new iTextSharp.text.Rectangle(doc.PageSize);
                        //customized border sizes
                        rectangle.Left += doc.LeftMargin - 5;
                        rectangle.Right -= doc.RightMargin - 5;
                        rectangle.Top -= doc.TopMargin - 5;
                        rectangle.Bottom += doc.BottomMargin - 5;
                        pdfContent.SetColorStroke(BaseColor.WHITE);//setting the color of the border to white
                        pdfContent.Rectangle(rectangle.Left, rectangle.Bottom, rectangle.Width, rectangle.Height);
                        pdfContent.Stroke();
                        //setting font type, font size and font color
                        iTextSharp.text.Font headerFont = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 25, BaseColor.DARK_GRAY);
                        Paragraph p = new Paragraph();
                        p.Alignment = Element.ALIGN_CENTER;//adjust the alignment of the heading
                        p.Add(new Chunk("LEARNING RESULT" + "\n\n", headerFont));//adding a heading to the PDF
                        doc.Add(p);//adding component to the document

                        student student = studentController.getStudentById(stuId);

                        Paragraph fullName = new Paragraph("Name: " + student.last_name + " " + student.first_name);
                        doc.Add(fullName);
                        Paragraph id = new Paragraph("Student ID: " + student.ID_Student);
                        doc.Add(id);
                        Paragraph birthPlace = new Paragraph("Place of birth: " + student.birth_place);
                        doc.Add(birthPlace);
                        Paragraph major = new Paragraph("Major: " + student.major.name + "\n\n");
                        doc.Add(major);

                        iTextSharp.text.Font font = iTextSharp.text.FontFactory.GetFont(FontFactory.TIMES_BOLD, 12, BaseColor.BLACK);
                        PdfPTable table = new PdfPTable(dgvData.Columns.Count);
                        for (int j = 0; j < dgvData.Columns.Count; j++)
                        {
                            PdfPCell cell = new PdfPCell(); //create object from the pdfpcell                          
                            cell.BackgroundColor = BaseColor.WHITE;//set color of cells
                            cell.AddElement(new Chunk(dgvData.Columns[j].HeaderText.ToUpper(), font));
                            table.AddCell(cell);
                        }
                        //adding rows from gridview to table
                        for (int i = 0; i < dgvData.Rows.Count; i++)
                        {
                            table.WidthPercentage = 100;//set width of the table
                            for (int j = 0; j < dgvData.Columns.Count; j++)
                            {
                                if (dgvData[j, i].Value != null)
                                    table.AddCell(new Phrase(dgvData[j, i].Value.ToString()));
                            }
                        }
                        //adding table to document
                        doc.Add(table);
                        doc.Close();
                        MessageBox.Show("You have successfully exported the file.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
