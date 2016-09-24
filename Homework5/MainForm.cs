using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Homework3ControlLib;
using Homework5.Dialogs;

namespace Homework5 {
    public partial class MainForm : Form {

        private AboutDialog aboutDialog;

        public MainForm() {
            InitializeComponent();
        }

        /*display the oath dialog*/
        private void oathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new OathDialog())
            {
                dialog.StartPosition = FormStartPosition.Manual;
                dialog.Location = new Point(this.Location.X + this.Width,
                    this.Location.Y);
                dialog.ShowDialog();
            }
        }

        /*display the about dialog*/
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aboutDialog != null)
            {
                return;
            }
            aboutDialog = new AboutDialog();
            aboutDialog.StartPosition = FormStartPosition.Manual;
            aboutDialog.Location = new Point(this.Location.X,
                this.Location.Y + this.Height);
            aboutDialog.FormClosed += AboutDialog_FormClosed;
            aboutDialog.Show();
        }

        private void AboutDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            aboutDialog = null;
        }

    }
}
