namespace Homework3ControlLib
{
    partial class TeamNames
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
            this.label1 = new System.Windows.Forms.Label();
            this.joseName = new System.Windows.Forms.Label();
            this.alexName = new System.Windows.Forms.Label();
            this.salvadorName = new System.Windows.Forms.Label();
            this.daylinName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "What is the group name?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // joseName
            // 
            this.joseName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.joseName.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joseName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.joseName.Location = new System.Drawing.Point(0, 84);
            this.joseName.Name = "joseName";
            this.joseName.Size = new System.Drawing.Size(168, 20);
            this.joseName.TabIndex = 1;
            this.joseName.Text = "Jose";
            this.joseName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alexName
            // 
            this.alexName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.alexName.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alexName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.alexName.Location = new System.Drawing.Point(0, 64);
            this.alexName.Name = "alexName";
            this.alexName.Size = new System.Drawing.Size(168, 20);
            this.alexName.TabIndex = 2;
            this.alexName.Text = "Alex";
            this.alexName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salvadorName
            // 
            this.salvadorName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.salvadorName.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvadorName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.salvadorName.Location = new System.Drawing.Point(0, 43);
            this.salvadorName.Name = "salvadorName";
            this.salvadorName.Size = new System.Drawing.Size(168, 21);
            this.salvadorName.TabIndex = 3;
            this.salvadorName.Text = "Salvador";
            this.salvadorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // daylinName
            // 
            this.daylinName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.daylinName.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daylinName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.daylinName.Location = new System.Drawing.Point(0, 23);
            this.daylinName.Name = "daylinName";
            this.daylinName.Size = new System.Drawing.Size(168, 20);
            this.daylinName.TabIndex = 4;
            this.daylinName.Text = "Daylin";
            this.daylinName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TeamNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.daylinName);
            this.Controls.Add(this.salvadorName);
            this.Controls.Add(this.alexName);
            this.Controls.Add(this.joseName);
            this.Controls.Add(this.label1);
            this.Name = "TeamNames";
            this.Size = new System.Drawing.Size(168, 104);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label joseName;
        private System.Windows.Forms.Label alexName;
        private System.Windows.Forms.Label salvadorName;
        private System.Windows.Forms.Label daylinName;
    }
}
