
namespace TrainingManagement
{
    partial class ViewScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewScore));
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lbTimetableTitle = new System.Windows.Forms.Label();
            this.btnViewScore = new System.Windows.Forms.Button();
            this.cmbSchoolYear = new System.Windows.Forms.ComboBox();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbStudentId = new System.Windows.Forms.TextBox();
            this.txbBirthPlace = new System.Windows.Forms.TextBox();
            this.txbMajor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(13, 306);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.Size = new System.Drawing.Size(1038, 254);
            this.dgvData.TabIndex = 4;
            // 
            // lbTimetableTitle
            // 
            this.lbTimetableTitle.AutoSize = true;
            this.lbTimetableTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimetableTitle.ForeColor = System.Drawing.Color.Teal;
            this.lbTimetableTitle.Location = new System.Drawing.Point(145, 252);
            this.lbTimetableTitle.Name = "lbTimetableTitle";
            this.lbTimetableTitle.Size = new System.Drawing.Size(765, 32);
            this.lbTimetableTitle.TabIndex = 20;
            this.lbTimetableTitle.Text = "LEARNING RESULT SEMETER 1 SCHOOL YEAR 2019";
            // 
            // btnViewScore
            // 
            this.btnViewScore.BackColor = System.Drawing.Color.Teal;
            this.btnViewScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewScore.ForeColor = System.Drawing.Color.White;
            this.btnViewScore.Location = new System.Drawing.Point(453, 199);
            this.btnViewScore.Name = "btnViewScore";
            this.btnViewScore.Size = new System.Drawing.Size(126, 36);
            this.btnViewScore.TabIndex = 18;
            this.btnViewScore.Text = "View Score";
            this.btnViewScore.UseVisualStyleBackColor = false;
            // 
            // cmbSchoolYear
            // 
            this.cmbSchoolYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSchoolYear.FormattingEnabled = true;
            this.cmbSchoolYear.Location = new System.Drawing.Point(782, 152);
            this.cmbSchoolYear.Name = "cmbSchoolYear";
            this.cmbSchoolYear.Size = new System.Drawing.Size(104, 28);
            this.cmbSchoolYear.TabIndex = 17;
            // 
            // cmbSemester
            // 
            this.cmbSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(337, 152);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(104, 28);
            this.cmbSemester.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(578, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Select school year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Select semester:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbMajor);
            this.groupBox1.Controls.Add(this.txbBirthPlace);
            this.groupBox1.Controls.Add(this.txbStudentId);
            this.groupBox1.Controls.Add(this.txbName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1039, 114);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(601, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Major:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(601, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Birth place:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Student ID:";
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.SystemColors.Control;
            this.txbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(192, 38);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(252, 20);
            this.txbName.TabIndex = 4;
            // 
            // txbStudentId
            // 
            this.txbStudentId.BackColor = System.Drawing.SystemColors.Control;
            this.txbStudentId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStudentId.Location = new System.Drawing.Point(192, 77);
            this.txbStudentId.Name = "txbStudentId";
            this.txbStudentId.Size = new System.Drawing.Size(252, 20);
            this.txbStudentId.TabIndex = 5;
            // 
            // txbBirthPlace
            // 
            this.txbBirthPlace.BackColor = System.Drawing.SystemColors.Control;
            this.txbBirthPlace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbBirthPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBirthPlace.Location = new System.Drawing.Point(724, 40);
            this.txbBirthPlace.Name = "txbBirthPlace";
            this.txbBirthPlace.Size = new System.Drawing.Size(252, 20);
            this.txbBirthPlace.TabIndex = 6;
            // 
            // txbMajor
            // 
            this.txbMajor.BackColor = System.Drawing.SystemColors.Control;
            this.txbMajor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMajor.Location = new System.Drawing.Point(724, 77);
            this.txbMajor.Name = "txbMajor";
            this.txbMajor.Size = new System.Drawing.Size(252, 20);
            this.txbMajor.TabIndex = 7;
            // 
            // ViewScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 573);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTimetableTitle);
            this.Controls.Add(this.btnViewScore);
            this.Controls.Add(this.cmbSchoolYear);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewScore";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lbTimetableTitle;
        private System.Windows.Forms.Button btnViewScore;
        private System.Windows.Forms.ComboBox cmbSchoolYear;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbMajor;
        private System.Windows.Forms.TextBox txbBirthPlace;
        private System.Windows.Forms.TextBox txbStudentId;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}