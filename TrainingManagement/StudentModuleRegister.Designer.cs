
namespace TrainingManagement
{
    partial class StudentModuleRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentModuleRegister));
            this.dgvClassModulesRegistered = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbCredits = new System.Windows.Forms.Label();
            this.dgvClassModules = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbLessonId = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbStudyingId = new System.Windows.Forms.TextBox();
            this.txbTotalCredtis = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassModulesRegistered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassModules)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClassModulesRegistered
            // 
            this.dgvClassModulesRegistered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassModulesRegistered.Location = new System.Drawing.Point(6, 36);
            this.dgvClassModulesRegistered.Name = "dgvClassModulesRegistered";
            this.dgvClassModulesRegistered.RowHeadersWidth = 51;
            this.dgvClassModulesRegistered.RowTemplate.Height = 24;
            this.dgvClassModulesRegistered.Size = new System.Drawing.Size(1030, 223);
            this.dgvClassModulesRegistered.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Teal;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(12, 266);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // lbCredits
            // 
            this.lbCredits.AutoSize = true;
            this.lbCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCredits.ForeColor = System.Drawing.Color.Black;
            this.lbCredits.Location = new System.Drawing.Point(426, 271);
            this.lbCredits.Name = "lbCredits";
            this.lbCredits.Size = new System.Drawing.Size(110, 18);
            this.lbCredits.TabIndex = 3;
            this.lbCredits.Text = "Total of credits:";
            // 
            // dgvClassModules
            // 
            this.dgvClassModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassModules.Location = new System.Drawing.Point(0, 38);
            this.dgvClassModules.Name = "dgvClassModules";
            this.dgvClassModules.RowHeadersWidth = 51;
            this.dgvClassModules.RowTemplate.Height = 24;
            this.dgvClassModules.Size = new System.Drawing.Size(1030, 229);
            this.dgvClassModules.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbLessonId);
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Controls.Add(this.dgvClassModules);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(5, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1030, 312);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTER CLASS MODULES";
            // 
            // txbLessonId
            // 
            this.txbLessonId.BackColor = System.Drawing.SystemColors.Control;
            this.txbLessonId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbLessonId.ForeColor = System.Drawing.SystemColors.Control;
            this.txbLessonId.Location = new System.Drawing.Point(254, 17);
            this.txbLessonId.Name = "txbLessonId";
            this.txbLessonId.Size = new System.Drawing.Size(31, 17);
            this.txbLessonId.TabIndex = 22;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Teal;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(12, 277);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(92, 29);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbStudyingId);
            this.groupBox2.Controls.Add(this.txbTotalCredtis);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.lbCredits);
            this.groupBox2.Controls.Add(this.dgvClassModulesRegistered);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Teal;
            this.groupBox2.Location = new System.Drawing.Point(5, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1030, 301);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CLASS MODULES REGISTERED";
            // 
            // txbStudyingId
            // 
            this.txbStudyingId.BackColor = System.Drawing.SystemColors.Control;
            this.txbStudyingId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbStudyingId.ForeColor = System.Drawing.SystemColors.Control;
            this.txbStudyingId.Location = new System.Drawing.Point(296, 13);
            this.txbStudyingId.Name = "txbStudyingId";
            this.txbStudyingId.Size = new System.Drawing.Size(31, 17);
            this.txbStudyingId.TabIndex = 23;
            // 
            // txbTotalCredtis
            // 
            this.txbTotalCredtis.Location = new System.Drawing.Point(551, 268);
            this.txbTotalCredtis.Name = "txbTotalCredtis";
            this.txbTotalCredtis.ReadOnly = true;
            this.txbTotalCredtis.Size = new System.Drawing.Size(39, 24);
            this.txbTotalCredtis.TabIndex = 4;
            this.txbTotalCredtis.TabStop = false;
            // 
            // StudentModuleRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1085, 575);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentModuleRegister";
            this.Text = "Register Modules";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassModulesRegistered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassModules)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClassModulesRegistered;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbCredits;
        private System.Windows.Forms.DataGridView dgvClassModules;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbTotalCredtis;
        private System.Windows.Forms.TextBox txbLessonId;
        private System.Windows.Forms.TextBox txbStudyingId;
    }
}