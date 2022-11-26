
namespace TrainingManagement
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.panel = new System.Windows.Forms.Panel();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.labelĐK = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBoxTTCN = new System.Windows.Forms.GroupBox();
            this.cmbRight = new System.Windows.Forms.ComboBox();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.labelNLMK = new System.Windows.Forms.Label();
            this.labelTND = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelMK = new System.Windows.Forms.Label();
            this.labelQTC = new System.Windows.Forms.Label();
            this.labelTĐN = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.groupBoxTTCN.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Control;
            this.panel.Controls.Add(this.picAvatar);
            this.panel.Controls.Add(this.labelĐK);
            this.panel.Controls.Add(this.btnExit);
            this.panel.Controls.Add(this.groupBoxTTCN);
            this.panel.Controls.Add(this.btnRegister);
            this.panel.Location = new System.Drawing.Point(1, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(682, 387);
            this.panel.TabIndex = 8;
            // 
            // picAvatar
            // 
            this.picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            this.picAvatar.Location = new System.Drawing.Point(34, 116);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(139, 140);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 8;
            this.picAvatar.TabStop = false;
            this.picAvatar.Click += new System.EventHandler(this.picAvatar_Click);
            // 
            // labelĐK
            // 
            this.labelĐK.AutoSize = true;
            this.labelĐK.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelĐK.ForeColor = System.Drawing.Color.Teal;
            this.labelĐK.Location = new System.Drawing.Point(207, 32);
            this.labelĐK.Name = "labelĐK";
            this.labelĐK.Size = new System.Drawing.Size(292, 22);
            this.labelĐK.TabIndex = 1;
            this.labelĐK.Text = "CREATE NEW USER ACCOUNT";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.CadetBlue;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(459, 308);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 44);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBoxTTCN
            // 
            this.groupBoxTTCN.Controls.Add(this.cmbRight);
            this.groupBoxTTCN.Controls.Add(this.txtRePassword);
            this.groupBoxTTCN.Controls.Add(this.labelNLMK);
            this.groupBoxTTCN.Controls.Add(this.labelTND);
            this.groupBoxTTCN.Controls.Add(this.txtPassword);
            this.groupBoxTTCN.Controls.Add(this.txtUsername);
            this.groupBoxTTCN.Controls.Add(this.txtEmail);
            this.groupBoxTTCN.Controls.Add(this.labelMK);
            this.groupBoxTTCN.Controls.Add(this.labelQTC);
            this.groupBoxTTCN.Controls.Add(this.labelTĐN);
            this.groupBoxTTCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTTCN.Location = new System.Drawing.Point(190, 88);
            this.groupBoxTTCN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTTCN.Name = "groupBoxTTCN";
            this.groupBoxTTCN.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTTCN.Size = new System.Drawing.Size(439, 199);
            this.groupBoxTTCN.TabIndex = 0;
            this.groupBoxTTCN.TabStop = false;
            this.groupBoxTTCN.Text = "Enter User Information";
            // 
            // cmbRight
            // 
            this.cmbRight.FormattingEnabled = true;
            this.cmbRight.Location = new System.Drawing.Point(191, 161);
            this.cmbRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRight.Name = "cmbRight";
            this.cmbRight.Size = new System.Drawing.Size(223, 28);
            this.cmbRight.TabIndex = 8;
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(191, 128);
            this.txtRePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Size = new System.Drawing.Size(223, 27);
            this.txtRePassword.TabIndex = 10;
            this.txtRePassword.UseSystemPasswordChar = true;
            // 
            // labelNLMK
            // 
            this.labelNLMK.AutoSize = true;
            this.labelNLMK.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNLMK.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelNLMK.Location = new System.Drawing.Point(7, 132);
            this.labelNLMK.Name = "labelNLMK";
            this.labelNLMK.Size = new System.Drawing.Size(160, 19);
            this.labelNLMK.TabIndex = 9;
            this.labelNLMK.Text = "Confirm Password:";
            // 
            // labelTND
            // 
            this.labelTND.AutoSize = true;
            this.labelTND.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTND.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelTND.Location = new System.Drawing.Point(7, 64);
            this.labelTND.Name = "labelTND";
            this.labelTND.Size = new System.Drawing.Size(94, 19);
            this.labelTND.TabIndex = 4;
            this.labelTND.Text = "Username:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(191, 94);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(223, 27);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(191, 60);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(223, 27);
            this.txtUsername.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(191, 28);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 27);
            this.txtEmail.TabIndex = 5;
            // 
            // labelMK
            // 
            this.labelMK.AutoSize = true;
            this.labelMK.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMK.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelMK.Location = new System.Drawing.Point(7, 98);
            this.labelMK.Name = "labelMK";
            this.labelMK.Size = new System.Drawing.Size(93, 19);
            this.labelMK.TabIndex = 3;
            this.labelMK.Text = "Password:";
            // 
            // labelQTC
            // 
            this.labelQTC.AutoSize = true;
            this.labelQTC.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQTC.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelQTC.Location = new System.Drawing.Point(7, 165);
            this.labelQTC.Name = "labelQTC";
            this.labelQTC.Size = new System.Drawing.Size(118, 19);
            this.labelQTC.TabIndex = 2;
            this.labelQTC.Text = "Access Right:";
            // 
            // labelTĐN
            // 
            this.labelTĐN.AutoSize = true;
            this.labelTĐN.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTĐN.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelTĐN.Location = new System.Drawing.Point(7, 32);
            this.labelTĐN.Name = "labelTĐN";
            this.labelTĐN.Size = new System.Drawing.Size(62, 19);
            this.labelTĐN.TabIndex = 0;
            this.labelTĐN.Text = "Email: ";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.CadetBlue;
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegister.Location = new System.Drawing.Point(218, 308);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(120, 44);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Đăng Kí";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 387);
            this.Controls.Add(this.panel);
            this.Name = "Register";
            this.Text = "Register";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.groupBoxTTCN.ResumeLayout(false);
            this.groupBoxTTCN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label labelĐK;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBoxTTCN;
        private System.Windows.Forms.ComboBox cmbRight;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.Label labelNLMK;
        private System.Windows.Forms.Label labelTND;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labelMK;
        private System.Windows.Forms.Label labelQTC;
        private System.Windows.Forms.Label labelTĐN;
        private System.Windows.Forms.Button btnRegister;
    }
}