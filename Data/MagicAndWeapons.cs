using System;
using System.Collections.Generic;
using SazaracsMagicSword.GameObjects;

namespace SazaracsMagicSword.Data
{
    public class Spells
    {
        List<Magic> BasicSpells = new List<Magic>()
        {
            new Magic("Flash", 1, 0, true, 0.9),
            new Magic("FireBall", 10, 0, true, 0.1),
            new Magic("Freaze", 5, 0, true, 0.5)
        };

        List<Magic> AdvancedSpells = new List<Magic>()
        {
            new Magic("Heal", 0, -20, false, 0),
            new Magic("Slow Time", 0, 0, true, 1),
            new Magic("Rock Slide", 15, 0, true, 0.4)
        };

        List<Magic> MasterSpells = new List<Magic>()
        {
            new Magic("Tornado", 35, 0, true, 0.2),
            new Magic("Bless", 0, -50, true, 0.5),
            new Magic("Curse", 50, 10, true, 0.2)
        };
    }
    public class Weapons
    {
        List<Weapon> WeakWeapons = new List<Weapon>()
        {
            new Weapon("Knive", 5, null),
            new Weapon("Short Sword", 8, null),
            new Weapon("Hammer", 12, null)
        };
        List<Weapon> AverageWeapons = new List<Weapon>()
        {
            new Weapon("Bow", 10, null),
            new Weapon("Sword", 13, null),
            new Weapon("Spear", 18, null)
        };
        List<Weapon> GoodWeapons = new List<Weapon>()
        {
            new Weapon("Revolver", 25, null),
            new Weapon("Holly Sword", 33, null),
            new Weapon("Heavy Hammer", 40, null)
        };
        List<Weapon> Uniques = new List<Weapon>()
        {
            new Weapon("Fork of DOOM", 1, new Magic("DOOM", 70, 20)), // a joke

            new Weapon("Sazarac's Magic Sword", 45, new Magic("Steal Life", 30, -30, true, 0.3)) // the weapon of the final boss - Sazarac
        };
    }
}
