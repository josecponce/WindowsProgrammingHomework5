namespace Homework3ControlLib
{
    partial class OathUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.oathLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oathLabel
            // 
            this.oathLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.oathLabel.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oathLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.oathLabel.Location = new System.Drawing.Point(0, 0);
            this.oathLabel.Name = "oathLabel";
            this.oathLabel.Size = new System.Drawing.Size(212, 23);
            this.oathLabel.TabIndex = 0;
            this.oathLabel.Text = "I understand that this is a group project.";
            this.oathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(0, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 74);
            this.label1.TabIndex = 1;
            this.label1.Text = "It is in my best interest to participate in writing the homework and study all th" +
    "e code from the homework.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OathUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oathLabel);
            this.MinimumSize = new System.Drawing.Size(212, 97);
            this.Name = "OathUserControl";
            this.Size = new System.Drawing.Size(212, 97);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label oathLabel;
        private System.Windows.Forms.Label label1;
    }
}
