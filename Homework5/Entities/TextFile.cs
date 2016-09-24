using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5.Entities {
    [Serializable]
    public class TextFile {
        public string Text { get; set; }
        public Color TextColor { get; set; }
        public Font Font { get; set; }
    }
}
