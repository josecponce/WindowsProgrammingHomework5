using Homework3ControlLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework5.Dialogs
{
    public partial class AboutDialog : DialogBase
    {
        public AboutDialog()
        {
            InitializeComponent();
            ContentPanel.Controls.Add(createDecriptionLabel(Description));
        }
        private Label createDecriptionLabel(string description)
        {
            var label = new Label();
            label.AutoSize = false;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Dock = DockStyle.Fill;
            label.Text = description;
            return label;
        }

        private const string Description =
            "Create a Single Document Interface (SDI) application " + 
            "that implements a text editor. In order to open multiple " +
            "files at the same time, multiple instances of the application " +
            "must be started.Use a multiline text box to implement the editor. " +
            "Do not use a rich text box. ";
    }
}

