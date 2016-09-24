using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5.Entities {
    public interface ITextFileRepository {
        void SaveTextFile(TextFile file, string path);
        TextFile LoadTextFile(string path);
    }
}
