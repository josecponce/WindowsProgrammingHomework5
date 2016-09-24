using Homework5.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework5 {
    static class Program {
        private static string 
            path = @"C:\Users\josecponce\Desktop\someFile.txtx";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            var file = new TextFile {
                Text = "Some text",
                TextColor = System.Drawing.Color.AliceBlue,
                Font = new Font(FontFamily.GenericMonospace, 10)
            };
            file.Save(path);
            var loadedFile = TextFile.LoadFromFile(path);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
