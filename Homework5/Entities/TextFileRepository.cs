using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Homework5.Entities {
    public class TextFileRepository : ITextFileRepository {

        private IFormatter formatter;

        public TextFileRepository(IFormatter formatter) {
            this.formatter = formatter;
        }

        public TextFile LoadTextFile(string path) {
            TextFile file = null;
            using (Stream stream = File.OpenRead(path)) {        
                file = formatter.Deserialize(stream) as TextFile;
            }
            return file;
        }

        public void SaveTextFile(TextFile file, string path) {
            using (Stream stream = File.OpenWrite(path)) {
                formatter.Serialize(stream, file);
            }
        }
    }
}
