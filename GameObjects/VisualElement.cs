using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SazaracsMagicSword.GameObjects
{
    public class VisualElement : IMove
    {
        public int width;
        public int height;
        public ConsoleColor backbroundColor;
        public string text;
        bool isSolid; /// player can not pass through solid elements;

        public Position position;

        public VisualElement(int width, int height, ConsoleColor backbroundColor, string text, bool isSolid, Position position)
        {
            if (width < 1 || height < 1)
            {
                throw new ArgumentException("Both Width and height must be positive.");
            }
            this.width = width;
            this.height = height;
            this.backbroundColor = backbroundColor;
            this.text = text;
            this.isSolid = isSolid;
            this.position = position;
        }

        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.up:
                    position.row--;
                    break;
                case Direction.down:
                    position.row++;
                    break;
                case Direction.left:
                    position.col--;
                    break;
                case Direction.right:
                    position.col++;
                    break;
                default:
                    break;
            }
        }
    }
}
