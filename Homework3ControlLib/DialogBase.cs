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
    public partial class DialogBase : Form {
        public Panel ContentPanel => mainContentPanel;
        public DialogBase() {
            InitializeComponent();
        }
    }
}
