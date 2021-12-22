using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Britannia.Objects;

namespace Britannia.Utils
{
    class tmp
    {
        Ship ship = new Ship("New Jersey", "068", Rarity.UltraRare, "Eagle Union", ShipTypes.BB, ArmorType.Heavy, 72, 33, -1, -1,
                9745, 453, 438, 0,
               40, 0, 17, 172, 0,
                76, GearTypes.BBGun, GearTypes.DDGun | GearTypes.CLGun, GearTypes.AAGun, 150, 120,
                130, 3, 3, 1);
        public void doIt()
        {
            List<Ship> bruh = new List<Ship>();
            Ship ship2 = new Ship("Univeral Bulin", "001", Rarity.Elite, "Universal", ShipTypes.DD,
                ArmorType.Light, 100, 35, -1, -1, 237, 23, 23, 23, 118, 23, 3, 118, 34, 118,
                GearTypes.DDGun, GearTypes.AAGun, GearTypes.AAGun, 100, 100, 100, 1, 1, 1);
            bruh.Add(ship);
            bruh.Add(ship2);
            ImmutableList<Ship> lmao = bruh.ToImmutableList();

            var options = new JsonSerializerOptions
            {
                IncludeFields = true,
                PropertyNameCaseInsensitive = true
            };

            List<Ship> help = new List<Ship>();
            string tmp = JsonSerializer.Serialize(help, options);
            File.WriteAllText(@"C:\Users\Melly\source\repos\Britannia\Britannia\Utils\ships.txt", tmp);
        }
    }
}
