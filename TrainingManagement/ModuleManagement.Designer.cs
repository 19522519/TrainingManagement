
namespace TrainingManagement
{
    partial class ModuleManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuleManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSchoolYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCurriculum = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbCurriculumId = new System.Windows.Forms.TextBox();
            this.txbTrainingType = new System.Windows.Forms.TextBox();
            this.txbTrainingSystem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvModuleList = new System.Windows.Forms.DataGridView();
            this.btnSearchModule = new System.Windows.Forms.Button();
            this.txbModuleCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbModuleName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbVisitingLessons = new System.Windows.Forms.TextBox();
            this.txbSelfStudyLessons = new System.Windows.Forms.TextBox();
            this.txbPracticeLessons = new System.Windows.Forms.TextBox();
            this.txbTheoryLessons = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.txbSchoolYear = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txbModuleId = new System.Windows.Forms.TextBox();
            this.txbCredits = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvModule = new System.Windows.Forms.DataGridView();
            this.txbCode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModuleList)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModule)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select school year:";
            // 
            // cmbSchoolYear
            // 
            this.cmbSchoolYear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSchoolYear.FormattingEnabled = true;
            this.cmbSchoolYear.Location = new System.Drawing.Point(24, 69);
            this.cmbSchoolYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSchoolYear.Name = "cmbSchoolYear";
            this.cmbSchoolYear.Size = new System.Drawing.Size(224, 28);
            this.cmbSchoolYear.TabIndex = 1;
            this.cmbSchoolYear.SelectedIndexChanged += new System.EventHandler(this.cmbSchoolYear_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(325, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select curriculum:";
            // 
            // cmbCurriculum
            // 
            this.cmbCurriculum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCurriculum.FormattingEnabled = true;
            this.cmbCurriculum.Location = new System.Drawing.Point(328, 69);
            this.cmbCurriculum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCurriculum.Name = "cmbCurriculum";
            this.cmbCurriculum.Size = new System.Drawing.Size(224, 28);
            this.cmbCurriculum.TabIndex = 3;
            this.cmbCurriculum.SelectedIndexChanged += new System.EventHandler(this.cmbCurriculum_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbCurriculumId);
            this.groupBox1.Controls.Add(this.txbTrainingType);
            this.groupBox1.Controls.Add(this.txbTrainingSystem);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbSchoolYear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbCurriculum);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(11, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(590, 211);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Curriculum";
            // 
            // txbCurriculumId
            // 
            this.txbCurriculumId.BackColor = System.Drawing.SystemColors.Control;
            this.txbCurriculumId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCurriculumId.ForeColor = System.Drawing.SystemColors.Control;
            this.txbCurriculumId.Location = new System.Drawing.Point(190, 28);
            this.txbCurriculumId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCurriculumId.Name = "txbCurriculumId";
            this.txbCurriculumId.Size = new System.Drawing.Size(35, 19);
            this.txbCurriculumId.TabIndex = 21;
            // 
            // txbTrainingType
            // 
            this.txbTrainingType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTrainingType.Location = new System.Drawing.Point(328, 152);
            this.txbTrainingType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbTrainingType.Name = "txbTrainingType";
            this.txbTrainingType.ReadOnly = true;
            this.txbTrainingType.Size = new System.Drawing.Size(224, 27);
            this.txbTrainingType.TabIndex = 19;
            // 
            // txbTrainingSystem
            // 
            this.txbTrainingSystem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTrainingSystem.Location = new System.Drawing.Point(24, 152);
            this.txbTrainingSystem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbTrainingSystem.Name = "txbTrainingSystem";
            this.txbTrainingSystem.ReadOnly = true;
            this.txbTrainingSystem.Size = new System.Drawing.Size(224, 27);
            this.txbTrainingSystem.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(19, 125);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Training system:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(325, 125);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Training type:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvModuleList);
            this.groupBox2.Controls.Add(this.btnSearchModule);
            this.groupBox2.Controls.Add(this.txbModuleCode);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txbModuleName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Teal;
            this.groupBox2.Location = new System.Drawing.Point(11, 254);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(590, 609);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Module";
            // 
            // dgvModuleList
            // 
            this.dgvModuleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModuleList.Location = new System.Drawing.Point(0, 200);
            this.dgvModuleList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvModuleList.Name = "dgvModuleList";
            this.dgvModuleList.RowHeadersWidth = 51;
            this.dgvModuleList.RowTemplate.Height = 24;
            this.dgvModuleList.Size = new System.Drawing.Size(590, 410);
            this.dgvModuleList.TabIndex = 11;
            this.dgvModuleList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModuleList_CellClick);
            // 
            // btnSearchModule
            // 
            this.btnSearchModule.BackColor = System.Drawing.Color.Teal;
            this.btnSearchModule.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchModule.ForeColor = System.Drawing.Color.White;
            this.btnSearchModule.Location = new System.Drawing.Point(171, 132);
            this.btnSearchModule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchModule.Name = "btnSearchModule";
            this.btnSearchModule.Size = new System.Drawing.Size(225, 44);
            this.btnSearchModule.TabIndex = 10;
            this.btnSearchModule.Text = "Search";
            this.btnSearchModule.UseVisualStyleBackColor = false;
            this.btnSearchModule.Click += new System.EventHandler(this.btnSearchModule_Click);
            // 
            // txbModuleCode
            // 
            this.txbModuleCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbModuleCode.Location = new System.Drawing.Point(24, 80);
            this.txbModuleCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbModuleCode.Name = "txbModuleCode";
            this.txbModuleCode.Size = new System.Drawing.Size(224, 27);
            this.txbModuleCode.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(19, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Code:";
            // 
            // txbModuleName
            // 
            this.txbModuleName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbModuleName.Location = new System.Drawing.Point(327, 80);
            this.txbModuleName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbModuleName.Name = "txbModuleName";
            this.txbModuleName.Size = new System.Drawing.Size(224, 27);
            this.txbModuleName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(323, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name:";
            // 
            // txbVisitingLessons
            // 
            this.txbVisitingLessons.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbVisitingLessons.Location = new System.Drawing.Point(722, 299);
            this.txbVisitingLessons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbVisitingLessons.Name = "txbVisitingLessons";
            this.txbVisitingLessons.Size = new System.Drawing.Size(146, 27);
            this.txbVisitingLessons.TabIndex = 18;
            // 
            // txbSelfStudyLessons
            // 
            this.txbSelfStudyLessons.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSelfStudyLessons.Location = new System.Drawing.Point(497, 299);
            this.txbSelfStudyLessons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbSelfStudyLessons.Name = "txbSelfStudyLessons";
            this.txbSelfStudyLessons.Size = new System.Drawing.Size(146, 27);
            this.txbSelfStudyLessons.TabIndex = 17;
            // 
            // txbPracticeLessons
            // 
            this.txbPracticeLessons.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPracticeLessons.Location = new System.Drawing.Point(262, 299);
            this.txbPracticeLessons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbPracticeLessons.Name = "txbPracticeLessons";
            this.txbPracticeLessons.Size = new System.Drawing.Size(146, 27);
            this.txbPracticeLessons.TabIndex = 16;
            // 
            // txbTheoryLessons
            // 
            this.txbTheoryLessons.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTheoryLessons.Location = new System.Drawing.Point(36, 299);
            this.txbTheoryLessons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbTheoryLessons.Name = "txbTheoryLessons";
            this.txbTheoryLessons.Size = new System.Drawing.Size(146, 27);
            this.txbTheoryLessons.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(719, 271);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Visiting lessons:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(493, 271);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Self study lessons";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(259, 271);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Practice lessons:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(33, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Theory lessons:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbSemester);
            this.groupBox3.Controls.Add(this.txbSchoolYear);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txbModuleId);
            this.groupBox3.Controls.Add(this.txbCredits);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.btnCreate);
            this.groupBox3.Controls.Add(this.dgvModule);
            this.groupBox3.Controls.Add(this.txbCode);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txbName);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txbVisitingLessons);
            this.groupBox3.Controls.Add(this.txbPracticeLessons);
            this.groupBox3.Controls.Add(this.txbSelfStudyLessons);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txbTheoryLessons);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Teal;
            this.groupBox3.Location = new System.Drawing.Point(636, 16);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(904, 848);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Module List";
            // 
            // cmbSemester
            // 
            this.cmbSemester.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(641, 181);
            this.cmbSemester.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(224, 28);
            this.cmbSemester.TabIndex = 41;
            // 
            // txbSchoolYear
            // 
            this.txbSchoolYear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSchoolYear.Location = new System.Drawing.Point(338, 184);
            this.txbSchoolYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbSchoolYear.Name = "txbSchoolYear";
            this.txbSchoolYear.Size = new System.Drawing.Size(224, 27);
            this.txbSchoolYear.TabIndex = 40;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Teal;
            this.label15.Location = new System.Drawing.Point(638, 156);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 20);
            this.label15.TabIndex = 38;
            this.label15.Text = "Semester:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Teal;
            this.label16.Location = new System.Drawing.Point(334, 156);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 20);
            this.label16.TabIndex = 39;
            this.label16.Text = "School year:";
            // 
            // txbModuleId
            // 
            this.txbModuleId.BackColor = System.Drawing.SystemColors.Control;
            this.txbModuleId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbModuleId.ForeColor = System.Drawing.SystemColors.Control;
            this.txbModuleId.Location = new System.Drawing.Point(126, 28);
            this.txbModuleId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbModuleId.Name = "txbModuleId";
            this.txbModuleId.Size = new System.Drawing.Size(35, 19);
            this.txbModuleId.TabIndex = 22;
            // 
            // txbCredits
            // 
            this.txbCredits.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCredits.Location = new System.Drawing.Point(36, 184);
            this.txbCredits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbCredits.Name = "txbCredits";
            this.txbCredits.ReadOnly = true;
            this.txbCredits.Size = new System.Drawing.Size(222, 27);
            this.txbCredits.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Teal;
            this.label17.Location = new System.Drawing.Point(33, 156);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 20);
            this.label17.TabIndex = 30;
            this.label17.Text = "Credits:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Teal;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(644, 370);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(225, 44);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(338, 370);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(225, 44);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Teal;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(36, 370);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(225, 44);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dgvModule
            // 
            this.dgvModule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModule.Location = new System.Drawing.Point(0, 438);
            this.dgvModule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvModule.Name = "dgvModule";
            this.dgvModule.RowHeadersWidth = 51;
            this.dgvModule.RowTemplate.Height = 24;
            this.dgvModule.Size = new System.Drawing.Size(906, 409);
            this.dgvModule.TabIndex = 27;
            this.dgvModule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModule_CellClick);
            // 
            // txbCode
            // 
            this.txbCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCode.Location = new System.Drawing.Point(35, 71);
            this.txbCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbCode.Name = "txbCode";
            this.txbCode.ReadOnly = true;
            this.txbCode.Size = new System.Drawing.Size(224, 27);
            this.txbCode.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Teal;
            this.label13.Location = new System.Drawing.Point(33, 44);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "Code:";
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(339, 71);
            this.txbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbName.Name = "txbName";
            this.txbName.ReadOnly = true;
            this.txbName.Size = new System.Drawing.Size(527, 27);
            this.txbName.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Teal;
            this.label14.Location = new System.Drawing.Point(335, 44);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "Name:";
            // 
            // ModuleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 879);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ModuleManagement";
            this.Text = "Module Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModuleList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSchoolYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCurriculum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbModuleName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearchModule;
        private System.Windows.Forms.TextBox txbModuleCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txbVisitingLessons;
        private System.Windows.Forms.TextBox txbSelfStudyLessons;
        private System.Windows.Forms.TextBox txbPracticeLessons;
        private System.Windows.Forms.TextBox txbTheoryLessons;
        private System.Windows.Forms.TextBox txbTrainingType;
        private System.Windows.Forms.TextBox txbTrainingSystem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvModuleList;
        private System.Windows.Forms.TextBox txbCode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dgvModule;
        private System.Windows.Forms.TextBox txbCredits;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txbCurriculumId;
        private System.Windows.Forms.TextBox txbModuleId;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.TextBox txbSchoolYear;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}