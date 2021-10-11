using Britannia.Objects;
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
            //Application.Run(new Britannia());

            
            Ship ship = new Ship("New Jersey", "068", Rarity.UltraRare, "Eagle Union", ShipTypes.BB, ArmorType.Heavy, 72, 33, -1, -1,
                new int[] { 1594, 8619, 9745 }, new int[] { 87, 426, 453 }, new int[] { 84, 394, 438 }, new int[] { 0, 0, 0 },
                new int[] { 9, 34, 40 }, new int[] { 0, 0, 0 }, new int[] { 9, 17, 17 }, new int[] { 62, 161, 172 }, new int[] { 0, 0, 0 },
                new int[] { 24, 66, 76 }, GearTypes.BBGun, GearTypes.DDGun | GearTypes.CLGun, GearTypes.AAGun, new int[] { 120, 150 }, new int[] { 210, 210 },
                new int[] { 130, 130 }, 3, 3, 1);

            var options = new JsonSerializerOptions
            {
                IncludeFields = true,
                PropertyNameCaseInsensitive = true
            };

            var roundTrippedJson =
                JsonSerializer.Serialize(ship, options);



            Debug.WriteLine($"Output JSON: {roundTrippedJson}");

            var ship2 = JsonSerializer.Deserialize<Ship>(roundTrippedJson, options);

            Debug.WriteLine($"Good stuff: {ship2.GetTorpedo(1)}");
            Debug.WriteLine($"Good stuff: {ship2.Slot2}");
            Debug.WriteLine($"Good stuff: {ship2.Name}");

            var bruh =
                JsonSerializer.Serialize(ship2, options);
            Debug.WriteLine($"Output JSON: {bruh}");
        }
    }
}
