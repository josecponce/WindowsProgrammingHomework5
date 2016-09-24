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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }


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



    }
}
