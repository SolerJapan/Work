using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StrVsStrBuilder
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            StringBuilder wordString = new StringBuilder(" We");
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();

            string word = " red ";
             word += " blue ";
            MessageBox.Show(word);
             word += " green ";
            MessageBox.Show(word);
            word += " purple ";
            MessageBox.Show(word);
            word += " orange ";
            MessageBox.Show(word);
            word += " pink ";
            MessageBox.Show(word);

            watch.Stop();
            MessageBox.Show("Time:" + watch.ElapsedMilliseconds + "ms");

            watch.Restart();
            watch.Start();

            wordString.Append(" Are ");
            MessageBox.Show(wordString.ToString());
            wordString.Append(" Software ");
            MessageBox.Show(wordString.ToString());
            wordString.Append(" Engineers ");
            MessageBox.Show(wordString.ToString());
            wordString.Append(" In ");
            MessageBox.Show(wordString.ToString());
            wordString.Append(" Training ");
            MessageBox.Show(wordString.ToString());

            watch.Stop();
            MessageBox.Show("Time:" + watch.ElapsedMilliseconds + "ms");

        }
    }
}
