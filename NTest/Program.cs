using System;
using System.Windows.Forms;
using TestLib;

namespace NTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mf = new MainForm();
            Application.Run(mf);
            mf.ListOfTests.Serializing(MainForm.PathToTests);
        }
    }
}
