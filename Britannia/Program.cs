using Britannia.Objects;
using Britannia.Utils;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows.Forms;

namespace Britannia
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
            Britannia br = new Britannia();
            if (br == null)
            {
                return;
            } else
            {
                Application.Run(br);

            } 
            tmp TMP = new tmp();
            TMP.doIt();
        }
    }
}
