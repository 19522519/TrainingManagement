
namespace TrainingManagement
{
    partial class TrainingManagerHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainingManagerHomePage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registerModulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturerManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerModulesToolStripMenuItem,
            this.lecturerManagementToolStripMenuItem,
            this.studentManagementToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1788, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // registerModulesToolStripMenuItem
            // 
            this.registerModulesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.registerModulesToolStripMenuItem.Name = "registerModulesToolStripMenuItem";
            this.registerModulesToolStripMenuItem.Size = new System.Drawing.Size(155, 27);
            this.registerModulesToolStripMenuItem.Text = "Register Modules";
            this.registerModulesToolStripMenuItem.Click += new System.EventHandler(this.registerModulesToolStripMenuItem_Click);
            // 
            // lecturerManagementToolStripMenuItem
            // 
            this.lecturerManagementToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.lecturerManagementToolStripMenuItem.Name = "lecturerManagementToolStripMenuItem";
            this.lecturerManagementToolStripMenuItem.Size = new System.Drawing.Size(193, 27);
            this.lecturerManagementToolStripMenuItem.Text = "Lecturer Management";
            this.lecturerManagementToolStripMenuItem.Click += new System.EventHandler(this.lecturerManagementToolStripMenuItem_Click);
            // 
            // studentManagementToolStripMenuItem
            // 
            this.studentManagementToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.studentManagementToolStripMenuItem.Name = "studentManagementToolStripMenuItem";
            this.studentManagementToolStripMenuItem.Size = new System.Drawing.Size(190, 27);
            this.studentManagementToolStripMenuItem.Text = "Student Management";
            this.studentManagementToolStripMenuItem.Click += new System.EventHandler(this.studentManagementToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(51, 27);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 31);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1788, 907);
            this.pnlContent.TabIndex = 1;
            // 
            // TrainingManagerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1788, 938);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TrainingManagerHomePage";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerModulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturerManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentManagementToolStripMenuItem;
    }
}

