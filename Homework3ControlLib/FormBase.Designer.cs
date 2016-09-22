namespace Homework3ControlLib {
    partial class FormBase {
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
            this.components = new System.ComponentModel.Container();
            this.baseFormContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseFormMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseFormContextMenu.SuspendLayout();
            this.baseFormMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseFormContextMenu
            // 
            this.baseFormContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.baseFormContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem});
            this.baseFormContextMenu.Name = "baseFormContextMenu";
            this.baseFormContextMenu.Size = new System.Drawing.Size(121, 30);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.preferencesColorsMenuItem_Click);
            // 
            // baseFormMenu
            // 
            this.baseFormMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.baseFormMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.preferencesToolStripMenuItem});
            this.baseFormMenu.Location = new System.Drawing.Point(0, 0);
            this.baseFormMenu.Name = "baseFormMenu";
            this.baseFormMenu.Size = new System.Drawing.Size(379, 28);
            this.baseFormMenu.TabIndex = 1;
            this.baseFormMenu.Text = "baseFormMenu";
            this.baseFormMenu.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.closeToolStripMenuItem.Text = "Close Child";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.fileCloseMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorsToolStripMenuItem});
            this.preferencesToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.colorsToolStripMenuItem.Text = "Colors";
            this.colorsToolStripMenuItem.Click += new System.EventHandler(this.preferencesColorsMenuItem_Click);
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.ContextMenuStrip = this.baseFormContextMenu;
            this.Controls.Add(this.baseFormMenu);
            this.MainMenuStrip = this.baseFormMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormBase";
            this.Text = "BaseForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BaseForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BaseForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BaseForm_MouseUp);
            this.baseFormContextMenu.ResumeLayout(false);
            this.baseFormMenu.ResumeLayout(false);
            this.baseFormMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip baseFormContextMenu;
        private System.Windows.Forms.MenuStrip baseFormMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
    }
}