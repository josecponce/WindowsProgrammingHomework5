namespace Homework3ControlLib {
    partial class CourseInfo {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.courseName = new System.Windows.Forms.Label();
            this.semester = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // courseName
            // 
            this.courseName.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseName.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.courseName.Location = new System.Drawing.Point(0, 0);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(86, 23);
            this.courseName.TabIndex = 0;
            this.courseName.Text = "COP 4226";
            this.courseName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // semester
            // 
            this.semester.Dock = System.Windows.Forms.DockStyle.Fill;
            this.semester.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semester.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.semester.Location = new System.Drawing.Point(0, 23);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(86, 28);
            this.semester.TabIndex = 1;
            this.semester.Text = "Fall 2016";
            this.semester.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CourseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.semester);
            this.Controls.Add(this.courseName);
            this.Name = "CourseInfo";
            this.Size = new System.Drawing.Size(86, 51);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label courseName;
        private System.Windows.Forms.Label semester;
    }
}
