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
            "Create a Multiple Document Interface application. "
            + "The app will open child windows that are "
            + "either ellipses, rectangles or custom shapes. "
            + "One dimension(height or width) of each will "
            + "be determined by a ratio that is set by the user. "
            + "The child windows can have different colors and can "
            + "be moved by the mouse.";
    }
}

