using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SazaracsMagicSword.GameObjects
{
    public struct Position
    {
        public int row { get; set; }
        public int col { get; set; }

        public Position(int row, int col) : this()
        {
            this.row = row;
            this.col = col;
        }
    }

    public enum Direction {up, down, left, right};

    interface IMove
    {
        void Move(Direction direction);
    }
}
