using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyScriptRunner
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

            if (string.IsNullOrEmpty(Program.ScriptFolder))
            {
                MessageBox.Show("Please set the Script folder in the config file first.");
                return;
            }


            ScriptOpener.Init();

            Application.Run(new MainForm());

        }

        


        public static string ScriptFolder
        {
            get
            {
                return Properties.Settings.Default.ScriptFolder;
            }
        }

        internal static void OpenScriptFolder()
        {
            System.Diagnostics.Process.Start(Program.ScriptFolder);
        }

    }
}
