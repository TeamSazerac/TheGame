using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace SazaracsMagicSword.GameObjects
{
    class Hero : Human
    {
        public Statistics statistics;
        public Weapon weapon;
        public VisualElement visibleHero;
        public string pathToImage;

        public Hero(string Name, Statistics statistics, Weapon weapon, VisualElement visibleHero, string pathToImage)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentNullException("Name is empty.");
            }
            if (!File.Exists(pathToImage))
            {
                throw new ArgumentException("Could not find the specified file.");
            }
            this.Name = Name;
            this.statistics = statistics;
            this.weapon = weapon;
            this.visibleHero = visibleHero;
            this.pathToImage = pathToImage;
        }
    }
}
