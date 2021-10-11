using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;



namespace Britannia.Objects
{
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
    class Ship
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
        private readonly int[] _health;
        private readonly int[] _firepower;
        private readonly int[] _aa;
        private readonly int[] _torpedo;
        private readonly int[] _evasion;
        private readonly int[] _airPower;
        private readonly int[] _oil;
        private readonly int[] _reload;
        private readonly int[] _asw;
        private readonly int[] _accuracy;
        private readonly int[] _efficiencySlot1;
        private readonly int[] _efficiencySlot2;
        private readonly int[] _efficiencySlot3;
        private readonly GearTypes _slot1;
        private readonly GearTypes _slot2;
        private readonly GearTypes _slot3;
        private readonly int _maxSlot1;
        private readonly int _maxSlot2;
        private readonly int _maxSlot3;
        

        public Ship(string name, string id, Rarity rarity, string nation, ShipTypes type, ArmorType armor,
            int luck, int speed, int oxygen, int ammo, int[] health, int[] firepower, int[] aa, int[] torpedo,
            int[] evasion, int[] airPower, int[] oil, int[] reload, int[] asw, int[] accuracy,
            GearTypes slot1, GearTypes slot2, GearTypes slot3, int[] efficiencySlot1, int[] efficiencySlot2,
            int[] efficiencySlot3, int maxSlot1, int maxSlot2, int maxSlot3)
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

        public int[] Health => _health;

        public int[] Firepower => _firepower;

        public int[] Aa => _aa;

        public int[] Torpedo => _torpedo;

        public int[] Evasion => _evasion;

        public int[] AirPower => _airPower;

        public int[] Oil => _oil;

        public int[] Reload => _reload;

        public int[] Asw => _asw;

        public int[] Accuracy => _accuracy;

        public int[] EfficiencySlot1 => _efficiencySlot1;

        public int[] EfficiencySlot2 => _efficiencySlot2;

        public int[] EfficiencySlot3 => _efficiencySlot3;

        public int GetHealth(int level)
        {
            switch (level)
            {
                case 1:
                    return _health[0];
                case 100:
                    return _health[1];
                case 125:
                    return _health[2];
                default:
                    throw new ArgumentOutOfRangeException("Levels must be 1, 100, or 125.");
            }
        }

        public int GetFirepower(int level)
        {
            switch (level)
            {
                case 1:
                    return _firepower[0];
                case 100:
                    return _firepower[1];
                case 125:
                    return _firepower[2];
                default:
                    throw new ArgumentOutOfRangeException("Levels must be 1, 100, or 125.");
            }
        }
        public int GetAA(int level)
        {
            switch (level)
            {
                case 1:
                    return _aa[0];
                case 100:
                    return _aa[1];
                case 125:
                    return _aa[2];
                default:
                    throw new ArgumentOutOfRangeException("Levels must be 1, 100, or 125.");
            }
        }

        public int GetTorpedo(int level)
        {
            switch (level)
            {
                case 1:
                    return _torpedo[0];
                case 100:
                    return _torpedo[1];
                case 125:
                    return _torpedo[2];
                default:
                    throw new ArgumentOutOfRangeException("Levels must be 1, 100, or 125.");
            }
        }

        public int GetEvasion(int level)
        {
            switch (level)
            {
                case 1:
                    return _evasion[0];
                case 100:
                    return _evasion[1];
                case 125:
                    return _evasion[2];
                default:
                    throw new ArgumentOutOfRangeException("Levels must be 1, 100, or 125.");
            }
        }

        public int GetAirPower(int level)
        {
            switch (level)
            {
                case 1:
                    return _airPower[0];
                case 100:
                    return _airPower[1];
                case 125:
                    return _airPower[2];
                default:
                    throw new ArgumentOutOfRangeException("Levels must be 1, 100, or 125.");
            }
        }

        public int GetOil(int level)
        {
            switch (level)
            {
                case 1:
                    return _oil[0];
                case 100:
                    return _oil[1];
                case 125:
                    return _oil[2];
                default:
                    throw new ArgumentOutOfRangeException("Levels must be 1, 100, or 125.");
            }
        }

        public int GetReload(int level)
        {
            switch (level)
            {
                case 1:
                    return _reload[0];
                case 100:
                    return _reload[1];
                case 125:
                    return _reload[2];
                default:
                    throw new ArgumentOutOfRangeException("Levels must be 1, 100, or 125.");
            }
        }

        public int GetASW(int level)
        {
            switch (level)
            {
                case 1:
                    return _asw[0];
                case 100:
                    return _asw[1];
                case 125:
                    return _asw[2];
                default:
                    throw new ArgumentOutOfRangeException("Levels must be 1, 100, or 125.");
            }
        }

        public int GetAccuracy(int level)
        {
            switch (level)
            {
                case 1:
                    return _accuracy[0];
                case 100:
                    return _accuracy[1];
                case 125:
                    return _accuracy[2];
                default:
                    throw new ArgumentOutOfRangeException("Levels must be 1, 100, or 125.");
            }
        }

        public int GetEfficiencySlot1(bool maxLB)
        {
            return maxLB ? _efficiencySlot1[0] : _efficiencySlot1[1];
        }
        public int GetEfficiencySlot2(bool maxLB)
        {
            return maxLB ? _efficiencySlot2[0] : _efficiencySlot2[1];
        }
        public int GetEfficiencySlot3(bool maxLB)
        {
            return maxLB ? _efficiencySlot3[0] : _efficiencySlot3[1];
        }
    }
}
