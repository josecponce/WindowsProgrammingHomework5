using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework5
{
    public partial class PreferencesForm : Form
    {
        private Color currentColor;
        private Font currentFont;
        public event EventHandler Apply;

        public PreferencesForm(Color color, Font font)
        {
            InitializeComponent();
            currentColor = color;
            currentFont = font;
            this.pictureBoxColor.BackColor = color;
            this.textBoxFont.Text = font.Name;
            this.textBoxFont.Font = font;
            this.textBoxFontStyle.Text = font.Style.ToString();
            this.textBoxFontSize.Text = font.SizeInPoints.ToString();
        }

        public Color CurrentColor
        {
            get
            {
                return currentColor;
            }

            set
            {
                currentColor = value;
            }
        }

        public Font CurrentFont
        {
            get
            {
                return currentFont;
            }

            set
            {
                currentFont = value;
            }
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    this.currentColor = dlg.Color;
                    this.pictureBoxColor.BackColor = currentColor;
                }
            }
        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            using (FontDialog dlg = new FontDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    this.currentFont = dlg.Font;
                    this.textBoxFont.Text = currentFont.Name;
                    this.textBoxFont.Font = new Font(currentFont.Name, (float)8.0,
                currentFont.Style);
                    this.textBoxFontStyle.Text = currentFont.Style.ToString();
                    this.textBoxFontSize.Text = currentFont.SizeInPoints.ToString();
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (Apply != null)
            {
                Apply(this, EventArgs.Empty);
            }
            this.Close();
        }
    }
}
