using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SazaracsMagicSword.GameObjects
{
    public struct Statistics
    {
        public int strength;
        public int dextirity;
        public int willpower;

        public Statistics(int str, int dex, int will)
        {
            this.strength = str;
            this.dextirity = dex;
            this.willpower = will;
        }
    }
}
