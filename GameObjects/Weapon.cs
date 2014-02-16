using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SazaracsMagicSword.GameObjects
{
    public class Weapon
    {
        string name;
        int damage;
        Magic magic;

        public void changeMagic(Magic magic)
        {
            this.magic = magic;
        }

        public Weapon(string name, int damage, Magic magic)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Weapon must have a name");
            }
            if (damage < 0)
            {
                throw new ArgumentException("Weapon must have positive damage");
            }
            this.name = name;
            this.damage = damage;
            this.magic = magic;
        }
    }
}
