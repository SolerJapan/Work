using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountWords
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
            StringBuilder block = new StringBuilder("");
           

            string paragraph = "Puer/puellae/rosam/dat/This/sentence/translated/literally/into/English/would/be/Boy/to/girl/rose/he/is/giving./Latin/does/on/occasion,/provide/a/method/of/specifying/a/definite/noun";
            int loc = 0;
            int CapWords = 0;
            int words = 0;
            char test;
            bool result = false;

            while(loc <= paragraph.Length -1)
            {
                block.Append(paragraph[loc]);

                if (paragraph[loc]==' '|| paragraph[loc]=='/')
                {
                    test = Convert.ToChar(block[0]);
                    result = Char.IsUpper(test);
                    if (result == true)
                    {
                        CapWords++;
                    }
                    else
                    {
                        words++;
                    }
                    block.Clear();
                }
                loc++;
            }

            MessageBox.Show("there are " + CapWords + " capitalized and " + words + " non capitalized ");

        }
    }
}
