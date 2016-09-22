namespace Homework3ControlLib {
    partial class DialogBase {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.mainContentPanel = new System.Windows.Forms.Panel();
            this.courseInfo1 = new Homework3ControlLib.CourseInfo();
            this.teamNames1 = new Homework3ControlLib.TeamNames();
            this.SuspendLayout();
            // 
            // mainContentPanel
            // 
            this.mainContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContentPanel.Location = new System.Drawing.Point(0, 51);
            this.mainContentPanel.Name = "mainContentPanel";
            this.mainContentPanel.Size = new System.Drawing.Size(398, 183);
            this.mainContentPanel.TabIndex = 2;
            // 
            // courseInfo1
            // 
            this.courseInfo1.BackColor = System.Drawing.Color.Transparent;
            this.courseInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseInfo1.Location = new System.Drawing.Point(0, 0);
            this.courseInfo1.Name = "courseInfo1";
            this.courseInfo1.Size = new System.Drawing.Size(398, 51);
            this.courseInfo1.TabIndex = 1;
            // 
            // teamNames1
            // 
            this.teamNames1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.teamNames1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.teamNames1.Location = new System.Drawing.Point(0, 234);
            this.teamNames1.Name = "teamNames1";
            this.teamNames1.Size = new System.Drawing.Size(398, 103);
            this.teamNames1.TabIndex = 0;
            // 
            // DialogBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 337);
            this.Controls.Add(this.mainContentPanel);
            this.Controls.Add(this.courseInfo1);
            this.Controls.Add(this.teamNames1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogBase";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "DialogBase";
            this.ResumeLayout(false);

        }

        #endregion

        private TeamNames teamNames1;
        private CourseInfo courseInfo1;
        private System.Windows.Forms.Panel mainContentPanel;
    }
}