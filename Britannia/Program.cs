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


            Ship ship = new Ship("New Jersey", "068", Rarity.UltraRare, "Eagle Union", ShipTypes.BB, ArmorType.Heavy, 72, 33, -1, -1,
                9745, 453, 438 ,0,
               40,0,17, 172,0,
                76, GearTypes.BBGun, GearTypes.DDGun | GearTypes.CLGun, GearTypes.AAGun, 150, 120,
                130, 3, 3, 1);
            tmp tmp = new tmp();
            //tmp.doIt();
        }
    }
}
