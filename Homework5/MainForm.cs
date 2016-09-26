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
using System.IO;

namespace Homework5 {
    public partial class MainForm : Form {

        private AboutDialog aboutDialog;
        private object openFileDialog;

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

        /*upon closing ask if the user wants to quit*/
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?",
                "Exit Now?", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }


        private void CopyText_Event(object sender, EventArgs e)
        {
            try {
                Clipboard.SetText(MainTextBox.SelectedText);
            } catch (Exception ae) {
                //nothing selected
                MessageBox.Show("nothing selected");
            }
        }


        private void CutText_Event(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(MainTextBox.SelectedText);
                MainTextBox.SelectedText = "";
            }
            catch (Exception ae)
            {
                //nothing selected
                MessageBox.Show("nothing selected");
            }

        }


        private void PasteText_Event(object sender, EventArgs e)
        {
            try
            {
                MainTextBox.Paste(Clipboard.GetText().ToString());
            }
            catch (Exception ae)
            {
                //no data on clipboard
                MessageBox.Show("no data on clipboard");
            }        
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MainTextBox.Text != null)
            {
                DialogResult result =  MessageBox.Show("You do want to save before opening a new file", "", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                }
                if(result == DialogResult.No)
                {
                    MainTextBox.Clear();
                }
            }    
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                     MainTextBox.Paste( File.ReadAllText(file));
                }
                catch (IOException){}
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();

            string path = saveFileDialog.FileName;
            File.WriteAllText(path += ".txt", MainTextBox.Text);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
  