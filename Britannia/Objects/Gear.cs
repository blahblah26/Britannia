using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Britannia.Objects
{

    [Flags]
    public enum GearTypes
    {
        None     = 0b_0000_0000_0000_0000,
        DDGun    = 0b_0000_0000_0000_0001,
        CLGun    = 0b_0000_0000_0000_0010,
        CAGun    = 0b_0000_0000_0000_0100,
        CBGun    = 0b_0000_0000_0000_1000,
        BBGun    = 0b_0000_0000_0001_0000,
        ShipTorp = 0b_0000_0000_0010_0000,
        SubTorp  = 0b_0000_0000_0100_0000,
        Fighter  = 0b_0000_0000_1000_0000,
        DiveBomb = 0b_0000_0001_0000_0000,
        TorpBomb = 0b_0000_0010_0000_0000,
        Seaplane = 0b_0000_0100_0000_0000,
        AAGun    = 0b_0000_1000_0000_0000,
        Cargo    = 0b_0001_0000_0000_0000,
        ASWGear  = 0b_0010_0000_0000_0000
    }
    public class Gear
    {
        private readonly string _name;
        private readonly string _id;
        private readonly int _rarity;
        private readonly ArmorType _armor;
        private readonly int _speed;
        private readonly int _oxygen;
        private readonly int _ammo;
        private readonly int _health;
        private readonly int _firepower;
        private readonly int _aa;
        private readonly int _torpedo;
        private readonly int _evasion;
        private readonly int _airPower;
        private readonly int _oil;
        private readonly int _reload;
        private readonly int _asw;
        private readonly int _accuracy;

        public string Name => _name;

        public string ID => _id;

        public int Rarity => _rarity;

        public ArmorType Armor => _armor;

        public int Speed => _speed;

        public int Oxygen => _oxygen;

        public int Ammo => _ammo;

        public int Health => _health;

        public int Firepower => _firepower;

        public int AA => _aa;

        public int Torpedo => _torpedo;

        public int Evasion => _evasion;

        public int AirPower => _airPower;

        public int Oil => _oil;

        public int Reload => _reload;

        public int ASW => _asw;

        public int Accuracy => _accuracy;

    }
}
