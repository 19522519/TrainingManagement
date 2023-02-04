
namespace TrainingManagement
{
    partial class ChangePasswordForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelSecurity = new System.Windows.Forms.Label();
            this.labelNewPass = new System.Windows.Forms.Label();
            this.txbNewPass = new System.Windows.Forms.TextBox();
            this.labelConfirmNewPass = new System.Windows.Forms.Label();
            this.txbConfirmNewPass = new System.Windows.Forms.TextBox();
            this.labelCurrentPass = new System.Windows.Forms.Label();
            this.txbCurrentPass = new System.Windows.Forms.TextBox();
            this.btnSaveSecurity = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowNewPass = new System.Windows.Forms.Button();
            this.btnShowConfirmNewPass = new System.Windows.Forms.Button();
            this.btnHideNewPass = new System.Windows.Forms.Button();
            this.btnHideConfirmNewPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(155, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(280, 244);
            this.listBox1.TabIndex = 14;
            // 
            // labelSecurity
            // 
            this.labelSecurity.AutoSize = true;
            this.labelSecurity.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecurity.ForeColor = System.Drawing.Color.Teal;
            this.labelSecurity.Location = new System.Drawing.Point(257, 39);
            this.labelSecurity.Name = "labelSecurity";
            this.labelSecurity.Size = new System.Drawing.Size(77, 23);
            this.labelSecurity.TabIndex = 15;
            this.labelSecurity.Text = "Bảo mật";
            // 
            // labelNewPass
            // 
            this.labelNewPass.AutoSize = true;
            this.labelNewPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPass.ForeColor = System.Drawing.Color.Teal;
            this.labelNewPass.Location = new System.Drawing.Point(165, 80);
            this.labelNewPass.Name = "labelNewPass";
            this.labelNewPass.Size = new System.Drawing.Size(108, 20);
            this.labelNewPass.TabIndex = 16;
            this.labelNewPass.Text = "Mật khẩu mới:";
            // 
            // txbNewPass
            // 
            this.txbNewPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewPass.Location = new System.Drawing.Point(169, 103);
            this.txbNewPass.Name = "txbNewPass";
            this.txbNewPass.Size = new System.Drawing.Size(220, 27);
            this.txbNewPass.TabIndex = 19;
            // 
            // labelConfirmNewPass
            // 
            this.labelConfirmNewPass.AutoSize = true;
            this.labelConfirmNewPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmNewPass.ForeColor = System.Drawing.Color.Teal;
            this.labelConfirmNewPass.Location = new System.Drawing.Point(165, 148);
            this.labelConfirmNewPass.Name = "labelConfirmNewPass";
            this.labelConfirmNewPass.Size = new System.Drawing.Size(174, 20);
            this.labelConfirmNewPass.TabIndex = 24;
            this.labelConfirmNewPass.Text = "Xác nhận mật khẩu mới:";
            // 
            // txbConfirmNewPass
            // 
            this.txbConfirmNewPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConfirmNewPass.Location = new System.Drawing.Point(169, 171);
            this.txbConfirmNewPass.Name = "txbConfirmNewPass";
            this.txbConfirmNewPass.Size = new System.Drawing.Size(220, 27);
            this.txbConfirmNewPass.TabIndex = 25;
            // 
            // labelCurrentPass
            // 
            this.labelCurrentPass.AutoSize = true;
            this.labelCurrentPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentPass.ForeColor = System.Drawing.Color.Teal;
            this.labelCurrentPass.Location = new System.Drawing.Point(165, 216);
            this.labelCurrentPass.Name = "labelCurrentPass";
            this.labelCurrentPass.Size = new System.Drawing.Size(174, 20);
            this.labelCurrentPass.TabIndex = 27;
            this.labelCurrentPass.Text = "Nhập mật khẩu hiện tại:";
            // 
            // txbCurrentPass
            // 
            this.txbCurrentPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCurrentPass.Location = new System.Drawing.Point(169, 239);
            this.txbCurrentPass.Name = "txbCurrentPass";
            this.txbCurrentPass.Size = new System.Drawing.Size(220, 27);
            this.txbCurrentPass.TabIndex = 28;
            this.txbCurrentPass.UseSystemPasswordChar = true;
            // 
            // btnSaveSecurity
            // 
            this.btnSaveSecurity.BackColor = System.Drawing.Color.Teal;
            this.btnSaveSecurity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSecurity.ForeColor = System.Drawing.Color.White;
            this.btnSaveSecurity.Location = new System.Drawing.Point(155, 336);
            this.btnSaveSecurity.Name = "btnSaveSecurity";
            this.btnSaveSecurity.Size = new System.Drawing.Size(143, 34);
            this.btnSaveSecurity.TabIndex = 29;
            this.btnSaveSecurity.Text = "Lưu thay đổi";
            this.btnSaveSecurity.UseVisualStyleBackColor = false;
            this.btnSaveSecurity.Click += new System.EventHandler(this.btnSaveSecurity_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Teal;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(342, 336);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 35);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShowNewPass
            // 
            this.btnShowNewPass.Image = global::TrainingManagement.Properties.Resources.Show_16px;
            this.btnShowNewPass.Location = new System.Drawing.Point(395, 101);
            this.btnShowNewPass.Name = "btnShowNewPass";
            this.btnShowNewPass.Size = new System.Drawing.Size(27, 24);
            this.btnShowNewPass.TabIndex = 31;
            this.btnShowNewPass.UseVisualStyleBackColor = true;
            this.btnShowNewPass.Click += new System.EventHandler(this.btnShowNewPass_Click);
            // 
            // btnShowConfirmNewPass
            // 
            this.btnShowConfirmNewPass.Image = global::TrainingManagement.Properties.Resources.Show_16px;
            this.btnShowConfirmNewPass.Location = new System.Drawing.Point(395, 171);
            this.btnShowConfirmNewPass.Name = "btnShowConfirmNewPass";
            this.btnShowConfirmNewPass.Size = new System.Drawing.Size(27, 24);
            this.btnShowConfirmNewPass.TabIndex = 32;
            this.btnShowConfirmNewPass.UseVisualStyleBackColor = true;
            this.btnShowConfirmNewPass.Click += new System.EventHandler(this.btnShowConfirmNewPass_Click);
            // 
            // btnHideNewPass
            // 
            this.btnHideNewPass.Image = global::TrainingManagement.Properties.Resources.Hide;
            this.btnHideNewPass.Location = new System.Drawing.Point(395, 101);
            this.btnHideNewPass.Name = "btnHideNewPass";
            this.btnHideNewPass.Size = new System.Drawing.Size(27, 24);
            this.btnHideNewPass.TabIndex = 33;
            this.btnHideNewPass.UseVisualStyleBackColor = true;
            this.btnHideNewPass.Click += new System.EventHandler(this.btnHideNewPass_Click);
            // 
            // btnHideConfirmNewPass
            // 
            this.btnHideConfirmNewPass.Image = global::TrainingManagement.Properties.Resources.Hide;
            this.btnHideConfirmNewPass.Location = new System.Drawing.Point(395, 171);
            this.btnHideConfirmNewPass.Name = "btnHideConfirmNewPass";
            this.btnHideConfirmNewPass.Size = new System.Drawing.Size(27, 24);
            this.btnHideConfirmNewPass.TabIndex = 34;
            this.btnHideConfirmNewPass.UseVisualStyleBackColor = true;
            this.btnHideConfirmNewPass.Click += new System.EventHandler(this.btnHideConfirmNewPass_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnHideConfirmNewPass);
            this.Controls.Add(this.btnHideNewPass);
            this.Controls.Add(this.btnShowConfirmNewPass);
            this.Controls.Add(this.btnShowNewPass);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveSecurity);
            this.Controls.Add(this.txbCurrentPass);
            this.Controls.Add(this.labelCurrentPass);
            this.Controls.Add(this.txbConfirmNewPass);
            this.Controls.Add(this.labelConfirmNewPass);
            this.Controls.Add(this.txbNewPass);
            this.Controls.Add(this.labelNewPass);
            this.Controls.Add(this.labelSecurity);
            this.Controls.Add(this.listBox1);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelSecurity;
        private System.Windows.Forms.Label labelNewPass;
        private System.Windows.Forms.TextBox txbNewPass;
        private System.Windows.Forms.Label labelConfirmNewPass;
        private System.Windows.Forms.TextBox txbConfirmNewPass;
        private System.Windows.Forms.Label labelCurrentPass;
        private System.Windows.Forms.TextBox txbCurrentPass;
        private System.Windows.Forms.Button btnSaveSecurity;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShowNewPass;
        private System.Windows.Forms.Button btnShowConfirmNewPass;
        private System.Windows.Forms.Button btnHideNewPass;
        private System.Windows.Forms.Button btnHideConfirmNewPass;
    }
}