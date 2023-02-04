﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturerHomePage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.classesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.điểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classesToolStripMenuItem,
            this.timeableToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.điểmToolStripMenuItem,
            this.exitsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(969, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // classesToolStripMenuItem
            // 
            this.classesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.classesToolStripMenuItem.Name = "classesToolStripMenuItem";
            this.classesToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.classesToolStripMenuItem.Text = "Classes";
            this.classesToolStripMenuItem.Click += new System.EventHandler(this.classesToolStripMenuItem_Click);
            // 
            // timeableToolStripMenuItem
            // 
            this.timeableToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.timeableToolStripMenuItem.Name = "timeableToolStripMenuItem";
            this.timeableToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.timeableToolStripMenuItem.Text = "Timeable";
            this.timeableToolStripMenuItem.Click += new System.EventHandler(this.timeableToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // điểmToolStripMenuItem
            // 
            this.điểmToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.điểmToolStripMenuItem.Name = "điểmToolStripMenuItem";
            this.điểmToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.điểmToolStripMenuItem.Text = "Score";
            this.điểmToolStripMenuItem.Click += new System.EventHandler(this.điểmToolStripMenuItem_Click);
            // 
            // exitsToolStripMenuItem
            // 
            this.exitsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitsToolStripMenuItem.Name = "exitsToolStripMenuItem";
            this.exitsToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitsToolStripMenuItem.Text = "Exit";
            this.exitsToolStripMenuItem.Click += new System.EventHandler(this.exitsToolStripMenuItem_Click);
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
            this.ClientSize = new System.Drawing.Size(969, 553);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LecturerHomePage";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem classesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem điểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlContent;
    }
}