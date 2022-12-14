
namespace TrainingManagement
{
    partial class LecturerHomePage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.classesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmModulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.điểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classesToolStripMenuItem,
            this.timeableToolStripMenuItem,
            this.confirmModulesToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.điểmToolStripMenuItem,
            this.exitsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(969, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // classesToolStripMenuItem
            // 
            this.classesToolStripMenuItem.Name = "classesToolStripMenuItem";
            this.classesToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.classesToolStripMenuItem.Text = "Classes";
            // 
            // timeableToolStripMenuItem
            // 
            this.timeableToolStripMenuItem.Name = "timeableToolStripMenuItem";
            this.timeableToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.timeableToolStripMenuItem.Text = "Timeable";
            // 
            // confirmModulesToolStripMenuItem
            // 
            this.confirmModulesToolStripMenuItem.Name = "confirmModulesToolStripMenuItem";
            this.confirmModulesToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.confirmModulesToolStripMenuItem.Text = "Confirm Modules";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // điểmToolStripMenuItem
            // 
            this.điểmToolStripMenuItem.Name = "điểmToolStripMenuItem";
            this.điểmToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.điểmToolStripMenuItem.Text = "Điểm";
            this.điểmToolStripMenuItem.Click += new System.EventHandler(this.điểmToolStripMenuItem_Click);
            // 
            // exitsToolStripMenuItem
            // 
            this.exitsToolStripMenuItem.Name = "exitsToolStripMenuItem";
            this.exitsToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitsToolStripMenuItem.Text = "Exit";
            // 
            // pnlContent
            // 
            this.pnlContent.Location = new System.Drawing.Point(0, 32);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(969, 516);
            this.pnlContent.TabIndex = 1;
            // 
            // LecturerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 582);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LecturerHomePage";
            this.Text = "LecturerHomePage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem classesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confirmModulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem điểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlContent;
    }
}