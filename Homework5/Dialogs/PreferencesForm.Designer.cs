namespace Homework5
{
    partial class PreferencesForm
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
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonFont = new System.Windows.Forms.Button();
            this.pictureBoxColor = new System.Windows.Forms.PictureBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelFont = new System.Windows.Forms.Label();
            this.textBoxFont = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxFontSize = new System.Windows.Forms.TextBox();
            this.textBoxFontStyle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonColor
            // 
            this.buttonColor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonColor.Location = new System.Drawing.Point(205, 55);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(102, 32);
            this.buttonColor.TabIndex = 0;
            this.buttonColor.Text = "Change Color";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonFont
            // 
            this.buttonFont.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonFont.Location = new System.Drawing.Point(205, 127);
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.Size = new System.Drawing.Size(102, 32);
            this.buttonFont.TabIndex = 1;
            this.buttonFont.Text = "Change Font";
            this.buttonFont.UseVisualStyleBackColor = true;
            this.buttonFont.Click += new System.EventHandler(this.buttonFont_Click);
            // 
            // pictureBoxColor
            // 
            this.pictureBoxColor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxColor.Location = new System.Drawing.Point(27, 55);
            this.pictureBoxColor.Name = "pictureBoxColor";
            this.pictureBoxColor.Size = new System.Drawing.Size(43, 32);
            this.pictureBoxColor.TabIndex = 2;
            this.pictureBoxColor.TabStop = false;
            // 
            // labelColor
            // 
            this.labelColor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(24, 19);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(92, 17);
            this.labelColor.TabIndex = 3;
            this.labelColor.Text = "Current Color";
            // 
            // labelFont
            // 
            this.labelFont.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFont.AutoSize = true;
            this.labelFont.Location = new System.Drawing.Point(24, 105);
            this.labelFont.Name = "labelFont";
            this.labelFont.Size = new System.Drawing.Size(87, 17);
            this.labelFont.TabIndex = 4;
            this.labelFont.Text = "Current Font";
            // 
            // textBoxFont
            // 
            this.textBoxFont.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxFont.Location = new System.Drawing.Point(27, 127);
            this.textBoxFont.Name = "textBoxFont";
            this.textBoxFont.ReadOnly = true;
            this.textBoxFont.Size = new System.Drawing.Size(149, 22);
            this.textBoxFont.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(205, 195);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(102, 32);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Apply";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxFontSize
            // 
            this.textBoxFontSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxFontSize.Location = new System.Drawing.Point(27, 195);
            this.textBoxFontSize.Name = "textBoxFontSize";
            this.textBoxFontSize.ReadOnly = true;
            this.textBoxFontSize.Size = new System.Drawing.Size(100, 22);
            this.textBoxFontSize.TabIndex = 7;
            // 
            // textBoxFontStyle
            // 
            this.textBoxFontStyle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxFontStyle.Location = new System.Drawing.Point(27, 162);
            this.textBoxFontStyle.Name = "textBoxFontStyle";
            this.textBoxFontStyle.ReadOnly = true;
            this.textBoxFontStyle.Size = new System.Drawing.Size(149, 22);
            this.textBoxFontStyle.TabIndex = 8;
            // 
            // PreferencesForm
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(326, 250);
            this.Controls.Add(this.textBoxFontStyle);
            this.Controls.Add(this.textBoxFontSize);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxFont);
            this.Controls.Add(this.labelFont);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.pictureBoxColor);
            this.Controls.Add(this.buttonFont);
            this.Controls.Add(this.buttonColor);
            this.MaximizeBox = false;
            this.Name = "PreferencesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preferences";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonFont;
        private System.Windows.Forms.PictureBox pictureBoxColor;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelFont;
        private System.Windows.Forms.TextBox textBoxFont;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxFontSize;
        private System.Windows.Forms.TextBox textBoxFontStyle;
    }
}