using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace SazaracsMagicSword.GameObjects
{
    public class Enemy : Human
    {
        public SeenAt seenAt;
        public double chanceToAppear;
        public Statistics statistics;
        public double chanceToEscape;
        public Weapon weapon;
        public string PathToImage;

        public Enemy(string Name, SeenAt seenAt, double chanceToAppear, Statistics statistics, double chanceToEscape, Weapon weapon, string PathToImage)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentNullException("Name is empty.");
            }
            if (chanceToAppear <= 0 || chanceToAppear > 1)
            {
                throw new ArgumentException("chanceToAppear must be in the diapason of (0, 1].");
            }
            if (chanceToEscape < 0 || chanceToEscape > 1)
            {
                throw new ArgumentException("chanceToEscape must be in the diapason of [0, 1].");
            }
            if (!File.Exists(PathToImage))
            {
                throw new ArgumentException("Could not find the image file");
            }
            this.Name = Name;
            this.seenAt = seenAt;
            this.chanceToAppear = chanceToAppear;
            this.statistics = statistics;
            this.chanceToEscape = chanceToEscape;
            this.weapon = weapon;
        }
    }

    public struct SeenAt
    {
        int row;
        int col;
        int width;
        int height;

        public SeenAt(int row, int col, int width, int height)
            : this()
        {
            if (row < 0 || col < 0)
            {
                throw new ArgumentException("row and col must be 0 or positive");
            }
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentException("width and heiht must be positive");
            }

            this.row = row;
            this.col = col;
            this.width = width;
            this.height = height;
        }
    }
}
