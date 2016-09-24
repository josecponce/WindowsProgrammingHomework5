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
    public partial class OathDialog : DialogBase
    {
        public OathUserControl OathControl { get; set; }

        public OathDialog()
        {
            InitializeComponent();
            OathControl = new OathUserControl();
            OathControl.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(OathControl);
        }
    }
}
