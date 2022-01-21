using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;



namespace Britannia.Objects
{

    // :O
    [Flags]
    public enum ShipTypes
    {
        NA  = 0b_0000_0000_0000_0000,
        DD  = 0b_0000_0000_0000_0001,
        CL  = 0b_0000_0000_0000_0010,
        CA  = 0b_0000_0000_0000_0100,
        CB  = 0b_0000_0000_0000_1000,
        AE  = 0b_0000_0000_0001_0000,
        BB  = 0b_0000_0000_0010_0000,
        BC  = 0b_0000_0000_0100_0000,
        BBV = 0b_0000_0000_1000_0000,
        BM  = 0b_0000_0001_0000_0000,
        CV  = 0b_0000_0010_0000_0000,
        CVL = 0b_0000_0100_0000_0000,
        AR  = 0b_0000_1000_0000_0000,
        SS  = 0b_0001_0000_0000_0000,
        SSV = 0b_0010_0000_0000_0000
    }

    public enum Rarity
    {
        Common,
        Rare,
        Elite,
        SuperRare,
        Priority,
        UltraRare,
        Decisive
    }

    public enum ArmorType
    {
        Light,
        Medium,
        Heavy
    }
    public class Ship
    {
        private readonly string _name;
        private readonly string _id;
        private readonly Rarity _rarity;
        private readonly string _nation;
        private readonly ShipTypes _type;
        private readonly ArmorType _armor;
        private readonly int _luck;
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
        private readonly int _efficiencySlot1;
        private readonly int _efficiencySlot2;
        private readonly int _efficiencySlot3;
        private readonly GearTypes _slot1;
        private readonly GearTypes _slot2;
        private readonly GearTypes _slot3;
        private readonly int _maxSlot1;
        private readonly int _maxSlot2;
        private readonly int _maxSlot3;
        

        public Ship(string name, string id, Rarity rarity, string nation, ShipTypes type, ArmorType armor,
            int luck, int speed, int oxygen, int ammo, int health, int firepower, int aa, int torpedo,
            int evasion, int airPower, int oil, int reload, int asw, int accuracy,
            GearTypes slot1, GearTypes slot2, GearTypes slot3, int efficiencySlot1, int efficiencySlot2,
            int efficiencySlot3, int maxSlot1, int maxSlot2, int maxSlot3)
        {
            _name = name;
            _id = id;
            _rarity = rarity;
            _nation = nation;
            _type = type;
            _armor = armor;
            _luck = luck;
            _speed = speed;
            _oxygen = oxygen;
            _ammo = ammo;
            _health = health;
            _firepower = firepower;
            _aa = aa;
            _torpedo = torpedo;
            _evasion = evasion;
            _airPower = airPower;
            _oil = oil;
            _reload = reload;
            _asw = asw;
            _accuracy = accuracy;
            _slot1 = slot1;
            _slot2 = slot2;
            _slot3 = slot3;
            _efficiencySlot1 = efficiencySlot1;
            _efficiencySlot2 = efficiencySlot2;
            _efficiencySlot3 = efficiencySlot3;
            _maxSlot1 = maxSlot1;
            _maxSlot2 = maxSlot2;
            _maxSlot3 = maxSlot3;
        }

        public string Name => _name;

        public string ID => _id;

        public string Nation => _nation;

        public int Luck => _luck;

        public int Speed => _speed;

        public int Oxygen => _oxygen;

        public int Ammo => _ammo;

        public Rarity Rarity => _rarity;

        public ShipTypes Type => _type;

        public ArmorType Armor => _armor;

        public int MaxSlot1 => _maxSlot1;

        public int MaxSlot2 => _maxSlot2;

        public int MaxSlot3 => _maxSlot3;

        public GearTypes Slot1 => _slot1;

        public GearTypes Slot2 => _slot2;

        public GearTypes Slot3 => _slot3;

        public int Health => _health;

        public int Firepower => _firepower;

        public int Aa => _aa;

        public int Torpedo => _torpedo;

        public int Evasion => _evasion;

        public int AirPower => _airPower;

        public int Oil => _oil;

        public int Reload => _reload;

        public int Asw => _asw;

        public int Accuracy => _accuracy;

        public int EfficiencySlot1 => _efficiencySlot1;

        public int EfficiencySlot2 => _efficiencySlot2;

        public int EfficiencySlot3 => _efficiencySlot3;

        public override bool Equals(object obj)
        {
            return obj is Ship ship &&
                   _name == ship._name &&
                   _id == ship._id &&
                   _rarity == ship._rarity &&
                   _nation == ship._nation &&
                   _type == ship._type &&
                   _armor == ship._armor &&
                   _luck == ship._luck &&
                   _speed == ship._speed &&
                   _oxygen == ship._oxygen &&
                   _ammo == ship._ammo &&
                   _health == ship._health &&
                   _firepower == ship._firepower &&
                   _aa == ship._aa &&
                   _torpedo == ship._torpedo &&
                   _evasion == ship._evasion &&
                   _airPower == ship._airPower &&
                   _oil == ship._oil &&
                   _reload == ship._reload &&
                   _asw == ship._asw &&
                   _accuracy == ship._accuracy &&
                   _efficiencySlot1 == ship._efficiencySlot1 &&
                   _efficiencySlot2 == ship._efficiencySlot2 &&
                   _efficiencySlot3 == ship._efficiencySlot3 &&
                   _slot1 == ship._slot1 &&
                   _slot2 == ship._slot2 &&
                   _slot3 == ship._slot3 &&
                   _maxSlot1 == ship._maxSlot1 &&
                   _maxSlot2 == ship._maxSlot2 &&
                   _maxSlot3 == ship._maxSlot3 &&
                   Name == ship.Name &&
                   ID == ship.ID &&
                   Nation == ship.Nation &&
                   Luck == ship.Luck &&
                   Speed == ship.Speed &&
                   Oxygen == ship.Oxygen &&
                   Ammo == ship.Ammo &&
                   Rarity == ship.Rarity &&
                   Type == ship.Type &&
                   Armor == ship.Armor &&
                   MaxSlot1 == ship.MaxSlot1 &&
                   MaxSlot2 == ship.MaxSlot2 &&
                   MaxSlot3 == ship.MaxSlot3 &&
                   Slot1 == ship.Slot1 &&
                   Slot2 == ship.Slot2 &&
                   Slot3 == ship.Slot3 &&
                   Health == ship.Health &&
                   Firepower == ship.Firepower &&
                   Aa == ship.Aa &&
                   Torpedo == ship.Torpedo &&
                   Evasion == ship.Evasion &&
                   AirPower == ship.AirPower &&
                   Oil == ship.Oil &&
                   Reload == ship.Reload &&
                   Asw == ship.Asw &&
                   Accuracy == ship.Accuracy &&
                   EfficiencySlot1 == ship.EfficiencySlot1 &&
                   EfficiencySlot2 == ship.EfficiencySlot2 &&
                   EfficiencySlot3 == ship.EfficiencySlot3;
        }
    }
}
