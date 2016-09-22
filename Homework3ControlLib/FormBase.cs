using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3ControlLib {
    public partial class FormBase : Form {

        private Point mouseDownLocation = Point.Empty;

        public FormBase() {
            InitializeComponent();
        }

        private void fileCloseMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void preferencesColorsMenuItem_Click(object sender, EventArgs e) {
            using (ColorDialog colorDialog =
                new ColorDialog() { Color = this.BackColor }) {
                DialogResult result = colorDialog.ShowDialog(this);
                if (result == DialogResult.OK) {
                    this.BackColor = colorDialog.Color;
                }
            }
        }

        private void BaseForm_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                mouseDownLocation = new Point(e.X, e.Y);
            }
        }

        private void BaseForm_MouseUp(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                mouseDownLocation = Point.Empty;
            }
        }

        private void BaseForm_MouseMove(object sender, MouseEventArgs e) {
            if (mouseDownLocation != Point.Empty) {
                this.Location =
                    new Point(
                        this.Left + e.X - mouseDownLocation.X,
                        this.Top + e.Y - mouseDownLocation.Y);
            }
        }
    }
}
