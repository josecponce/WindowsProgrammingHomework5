using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace Homework5.Entities {
    [Serializable]
    public class TextFile {
        private string text;
        public string Text {
            get { return text; }
            set {
                dirty = true;
                text = value;
            }
        }
        private Color textColor;
        public Color TextColor {
            get { return textColor; }
            set {
                dirty = true;
                textColor = value;
            }
        }
        private Font font;
        public Font Font {
            get { return font; }
            set {
                dirty = true;
                font = value;
            }
        }

        [NonSerialized]
        public bool dirty;
        [NonSerialized]
        private static ITextFileRepository fileRepository =
            UnityConfig.RegisterComponents().Resolve<ITextFileRepository>();

        public void Save(string path) {
            fileRepository.SaveTextFile(this, path);
            dirty = false;
        }

        public static TextFile LoadFromFile(string path) {
            TextFile file = fileRepository.LoadTextFile(path);
            file.dirty = false;
            return file;
        }
    }
}
