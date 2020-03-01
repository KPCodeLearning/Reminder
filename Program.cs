using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Diagnostics;

namespace Reminder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            string textFile = "D:\\Reminder.txt";
            StringBuilder sb = new StringBuilder();
            
            if (File.Exists(textFile))
            {
                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(textFile);
                int i = 1;
                foreach (string line in lines)
                {
                    sb.AppendLine(i + ". " + line);
                    i++;
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(sb));
        }
    }
}
