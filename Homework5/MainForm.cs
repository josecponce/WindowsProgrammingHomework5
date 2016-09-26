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
using Homework5.Entities;

namespace Homework5 {
    public partial class MainForm : Form {

        private AboutDialog aboutDialog;
        private TextFile file;
        private string currentFilePath;

        public MainForm() {            
            InitializeComponent();
            file = new TextFile {
                Font = MainTextBox.Font,
                TextColor = MainTextBox.ForeColor,
                Text = "",
                dirty = false
            };
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
            if(file.dirty)
                promptSaveBeforeChangesLost();
            DialogResult result = MessageBox.Show("Are you sure you want to quit?",
                "Exit Now?", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void promptSaveBeforeChangesLost() {
            DialogResult result = MessageBox.Show("Do you want to save before continuing?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                saveToolStripMenuItem_Click(null, null);
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
            if(file.dirty)
            {
                promptSaveBeforeChangesLost();
            }
            file = new TextFile {
                Font = MainTextBox.Font,
                TextColor = MainTextBox.ForeColor,
                Text = ""
            };
            MainTextBox.Text = file.Text;
            currentFilePath = null;

            StatusStripLabel.Text = "Unsaved File";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (file.dirty)
                promptSaveBeforeChangesLost();
            DialogResult result = mainOpenFileDialog.ShowDialog(); 
            if (result == DialogResult.OK) 
            {
                currentFilePath = mainOpenFileDialog.FileName;
                file = TextFile.LoadFromFile(currentFilePath);

                MainTextBox.Text = file.Text;
                MainTextBox.Font = file.Font;
                MainTextBox.ForeColor = file.TextColor;
            }
            StatusStripLabel.Text = currentFilePath;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile(currentFilePath == null);
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            saveFile(true);
        }

        private void saveFile(bool promptUser) {
            if (promptUser) {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog()) {
                    DialogResult result = saveFileDialog.ShowDialog();
                    if (result != DialogResult.OK)
                        return;
                    currentFilePath = saveFileDialog.FileName;
                }
            }
            file.Save(currentFilePath);
            StatusStripLabel.Text = currentFilePath;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is PreferencesForm)
                {
                    if (f.WindowState == FormWindowState.Minimized)
                        f.WindowState = FormWindowState.Normal;
                    f.Focus();
                    f.BringToFront();
                    f.Focus();
                    return;
                }
            }

            PreferencesForm pForm = new PreferencesForm(this.MainTextBox.ForeColor, this.MainTextBox.Font);
            pForm.Apply += Preference_Apply;
            pForm.Show();
        }

        private void Preference_Apply(object sender, EventArgs e)
        {
            this.MainTextBox.Font = ((PreferencesForm)sender).CurrentFont;
            file.Font = this.MainTextBox.Font;
            this.MainTextBox.ForeColor = ((PreferencesForm)sender).CurrentColor;
            file.TextColor = this.MainTextBox.ForeColor;
        }

        private void MainTextBox_TextChanged(object sender, EventArgs e) {
            if (MainTextBox.Text != file.Text) {
                file.Text = MainTextBox.Text;
            }
        }
    }
}
  