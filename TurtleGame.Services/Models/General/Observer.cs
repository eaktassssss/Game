using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TurtleGame.Services.Models.General
{
    public class Observer
    {
        private int _width;
        private int _height;
        private Grid _grid;
        public Observer(Grid grid)
        {
            _width = grid.Width;
            _height = grid.Height;
            _grid = grid;
        }
        public Observer Build()
        {
            return new Observer(_grid);
        }
        public bool Observe(Point position)
        {
            if (IsOutOfBounds(position)) { Console.WriteLine(Message.Out); return true; }
            else if (IsDead(position)) { Console.WriteLine(Message.Dead); return true; }
            else if (IsExit(position)) { Console.WriteLine(Message.Success); return true; }
            else
                return false;
        }
        public void IsDanger()
        {
            Console.WriteLine(Message.IsNear);
        }
        private bool IsDead(Point position)
        {
            return _grid[position] is Mine;
        }
        private bool IsOutOfBounds(Point position)
        {
            return position.X < 0 || position.X > _width || position.Y < 0 || position.Y > _height;
        }
        private bool IsExit(Point position)
        {
            return _grid[position] is Exit;

        }
    }
}
