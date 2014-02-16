using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SazaracsMagicSword.GameObjects
{
    public class Magic
    {
        string Name;
        int damage;
        int damageOnSelf;
        bool crippleFoe;
        double chanceToCrippleFoe;

        public Magic(string Name, int damage, int damageOnSelf)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentException("Magic must have a name");
            }
            this.Name = Name;
            this.damage = damage;
            this.damageOnSelf = damageOnSelf;
            this.crippleFoe = false;
            this.chanceToCrippleFoe = 0;
        }
        public Magic(string Name, int damage, int damageOnSelf, bool crippleFoe, double chanceToCrippleFoe)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentException("Magic must have a name");
            }
            if (chanceToCrippleFoe < 0 || chanceToCrippleFoe > 1)
            {
                throw new ArgumentException("chanceToCrippleFoe must be between 0 and 1.");
            }
            this.Name = Name;
            this.damage = damage;
            this.damageOnSelf = damageOnSelf;
            this.crippleFoe = crippleFoe;
            this.chanceToCrippleFoe = chanceToCrippleFoe;
        }
    }
}
