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
        
        public void doIt()
        {
            Ship ship = new Ship("New Jersey", "068", Directory.GetCurrentDirectory() + "\\Utils\\" + 21 + ".png", Rarity.UltraRare, "Eagle Union", ShipTypes.BB, ArmorType.Heavy, 72, 33, -1, -1,
                   9745, 453, 438, 0,
                  40, 0, 17, 172, 0,
                   76, GearTypes.BBGun, GearTypes.DDGun | GearTypes.CLGun, GearTypes.AAGun);
            var options = new JsonSerializerOptions
            {
                IncludeFields = true,
                PropertyNameCaseInsensitive = true
            };
            List<Gear> bleh = new List<Gear>();
            String[] name4 =
            {
                "Quadruple 330mm (Mle 1931)",
"Quadruple 356mm (14\"/50 Mark B Prototype)",
"Triple 283mm (SK C/34)",
"Triple 381mm (Model 1934)",
"Triple 406mm (MK-1)",
"Triple 406mm (Mle 1938 Prototype)",
"Twin 305mm (41st Year Type)",
"Twin 410mm (Type 3 Shell)",
"Twin 457mm (Mark A Prototype)",
"533mm Quadruple Homing Torpedo Mount",
"533mm Quadruple Torpedo Mount Mk 17",
"533mm Triple Torpedo Mount Mk IX"
            };
            Random rand = new Random();
            for (int i = 0; i < 12; i++)
            {
                bleh.Add(new Gear(name4[i], String.Format("{0,0:D3}", i + 100), 2, ArmorType.Medium, rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100),""));
            }
            string etmp = JsonSerializer.Serialize(bleh, options);
            File.WriteAllText(@"C:\Users\Melly\Documents\gcatalogue.txt", etmp);
            List<Ship> bruh = new List<Ship>();
            
            Ship ship2 = new Ship("Univeral Bulin", "001", Directory.GetCurrentDirectory() + "\\Utils\\1.png", Rarity.Elite, "Universal", ShipTypes.DD,
                ArmorType.Light, 100, 35, -1, -1, 237, 23, 23, 23, 118, 23, 3, 118, 34, 118,
                GearTypes.DDGun, GearTypes.AAGun, GearTypes.AAGun);
     
            String[] name1 = {"Dewey",
"Cassin",
"Downes",
"Gridley",
"Craven",
"McCall",
"Maury",
"Fletcher"};
            String[] name2 =
            {
                "Fusou",
"Yamashiro",
"Ise",
"Hyuuga",
"Nagato",
"Mutsu",
"Kii"
            };
            String[] name3 =
            {
                "U-556",
"U-73",
"I-25",
"I-56",
"I-168",
"U-101",
"U-522",
"Cavalla",
"U-110",
"Bluegill",
"U-96"
            };
            for (int i = 0; i < 6; i++)
            {
                bruh.Add(new Ship(name2[i], String.Format("{0,0:D3}", i + 100), Directory.GetCurrentDirectory() + "\\Utils\\" + (i + 2) + ".png", Rarity.Common, "Eagle Union", ShipTypes.BB, ArmorType.Heavy, rand.Next(0, 100), rand.Next(0, 100)
                    , -1, -1, rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), 0, rand.Next(0, 100),
                    rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), GearTypes.BBGun, GearTypes.DDGun | GearTypes.CLGun, GearTypes.AAGun));
            }
            for (int i = 0; i < 6; i++)
            {
                bruh.Add(new Ship(name1[i], String.Format("{0,0:D3}", i+300), Directory.GetCurrentDirectory() + "\\Utils\\" + (i + 8) + ".png", Rarity.Rare, "Universal", ShipTypes.DD, ArmorType.Light, rand.Next(0, 100), rand.Next(0, 100)
                    , -1, -1, rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), 0, rand.Next(0, 100),
                    rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), GearTypes.DDGun, GearTypes.AAGun, GearTypes.AAGun));
            }
            Ship ship3 = new Ship("U-81", "341", Directory.GetCurrentDirectory() + "\\Utils\\" + 14 + ".png", Rarity.SuperRare, "Iron Blood", ShipTypes.SS,
                ArmorType.Light, 23, 14, 188, 2, 1341, 51, 0, 562, 38, 0, 7, 110, 0, 179,
                GearTypes.SubTorp, GearTypes.SubTorp, GearTypes.DDGun);
            for (int i = 0; i < 6; i++)
            {
                bruh.Add(new Ship(name3[i], String.Format("{0,0:D3}", i + 500), Directory.GetCurrentDirectory() + "\\Utils\\" + (i + 15) + ".png", Rarity.Rare, "Universal", ShipTypes.SS, ArmorType.Light, rand.Next(0, 100), rand.Next(0, 100)
                    , rand.Next(0, 100), -1, rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100), 0, rand.Next(0, 100),
                    rand.Next(0, 100), rand.Next(0, 100), rand.Next(0, 100),
                GearTypes.SubTorp, GearTypes.SubTorp, GearTypes.DDGun));
            }
            bruh.Add(ship);
            bruh.Add(ship2);
            bruh.Add(ship3);
            ImmutableList<Ship> lmao = bruh.ToImmutableList();

           

            List<Ship> help = new List<Ship>();
            string tmp = JsonSerializer.Serialize(bruh, options);
            File.WriteAllText(@"C:\Users\Melly\Documents\catalogue.txt", tmp);
        }
    }
}
