
namespace TrainingManagement
{
    partial class InputScore
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.cmbSchoolYear = new System.Windows.Forms.ComboBox();
            this.cmbClassModule = new System.Windows.Forms.ComboBox();
            this.btnInputScore = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbScore = new System.Windows.Forms.TextBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnViewScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(59, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Semester:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(323, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "School year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(621, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Class module:";
            // 
            // cmbSemester
            // 
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Location = new System.Drawing.Point(156, 36);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(121, 24);
            this.cmbSemester.TabIndex = 4;
            // 
            // cmbSchoolYear
            // 
            this.cmbSchoolYear.FormattingEnabled = true;
            this.cmbSchoolYear.Location = new System.Drawing.Point(433, 33);
            this.cmbSchoolYear.Name = "cmbSchoolYear";
            this.cmbSchoolYear.Size = new System.Drawing.Size(121, 24);
            this.cmbSchoolYear.TabIndex = 5;
            // 
            // cmbClassModule
            // 
            this.cmbClassModule.FormattingEnabled = true;
            this.cmbClassModule.Location = new System.Drawing.Point(739, 32);
            this.cmbClassModule.Name = "cmbClassModule";
            this.cmbClassModule.Size = new System.Drawing.Size(189, 24);
            this.cmbClassModule.TabIndex = 6;
            this.cmbClassModule.SelectedIndexChanged += new System.EventHandler(this.cmbClassModule_SelectedIndexChanged);
            this.cmbClassModule.Click += new System.EventHandler(this.cmbClassModule_Click);
            // 
            // btnInputScore
            // 
            this.btnInputScore.BackColor = System.Drawing.Color.Teal;
            this.btnInputScore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputScore.ForeColor = System.Drawing.Color.White;
            this.btnInputScore.Location = new System.Drawing.Point(315, 82);
            this.btnInputScore.Name = "btnInputScore";
            this.btnInputScore.Size = new System.Drawing.Size(133, 36);
            this.btnInputScore.TabIndex = 8;
            this.btnInputScore.Text = "Input score";
            this.btnInputScore.UseVisualStyleBackColor = false;
            this.btnInputScore.Click += new System.EventHandler(this.btnInputScore_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(59, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Input score:";
            // 
            // txbScore
            // 
            this.txbScore.Location = new System.Drawing.Point(156, 90);
            this.txbScore.Name = "txbScore";
            this.txbScore.Size = new System.Drawing.Size(121, 22);
            this.txbScore.TabIndex = 10;
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(188, 137);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(598, 367);
            this.dgvData.TabIndex = 11;
            // 
            // btnViewScore
            // 
            this.btnViewScore.BackColor = System.Drawing.Color.Teal;
            this.btnViewScore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewScore.ForeColor = System.Drawing.Color.White;
            this.btnViewScore.Location = new System.Drawing.Point(518, 82);
            this.btnViewScore.Name = "btnViewScore";
            this.btnViewScore.Size = new System.Drawing.Size(133, 36);
            this.btnViewScore.TabIndex = 12;
            this.btnViewScore.Text = "View score";
            this.btnViewScore.UseVisualStyleBackColor = false;
            this.btnViewScore.Click += new System.EventHandler(this.btnViewScore_Click);
            // 
            // InputScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 516);
            this.ControlBox = false;
            this.Controls.Add(this.btnViewScore);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.txbScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnInputScore);
            this.Controls.Add(this.cmbClassModule);
            this.Controls.Add(this.cmbSchoolYear);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputScore";
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.ComboBox cmbSchoolYear;
        private System.Windows.Forms.ComboBox cmbClassModule;
        private System.Windows.Forms.Button btnInputScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbScore;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnViewScore;
    }
}