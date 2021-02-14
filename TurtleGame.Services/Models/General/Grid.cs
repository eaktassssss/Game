using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TurtleGame.Services.Models.General
{
    public sealed class Grid
    {
        private Element[][] _elements;
        public int Width { get; private set; }
        public int Height { get; private set; }
        public Grid(int x, int y)
        {
            Width = x;
            Height = y;
            _elements = new Element[Width][];
            for (int i = 0; i < Width; i++)
            {
                _elements[i] = new Element[Height];
                for (int j = 0; j < Height; j++)
                {
                    _elements[i][j] = new Element() { Position = new Point { X = i, Y = j } };
                }
            }
        }
        public Element this[int index1, int index2]
        {
            get { return _elements[index1][index2]; }
            set { _elements[index1][index2] = value; }
        }
        public Element this[Point p]
        {
            get { return _elements[p.X][p.Y]; }
            set { _elements[p.X][p.Y] = value; }
        }
    }
}
