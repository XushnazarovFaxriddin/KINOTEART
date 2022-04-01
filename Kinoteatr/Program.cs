using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinoteatr
{
    public static class Program
    {
        public static string path = @"C:\Kinoteatr";
        public static Kinoteatr kinoteatr;
        public static Konsert konsert;
        public static newKonsert newkonsert;
        public static List<db> dbList;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory($@"{path}");
            }
            kinoteatr = new Kinoteatr();
            konsert = new Konsert();
            newkonsert = new newKonsert();
            dbList = new List<db>();


            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(kinoteatr);
        }
    }
}
