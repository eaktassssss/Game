using System;
using System.Collections.Generic;
using System.Text;

namespace TurtleGame.Services.Models.General
{
    public class Board
    {
        public void CreateMines(List<Point> mines, Grid grid)
        {
            foreach (var minePosition in mines)
            {
                try
                {
                    grid[minePosition] = new Mine() { Position = minePosition };
                }
                catch
                {
                }
            }
        }
        public void CreateExit(Point exit, Grid grid)
        {
            try
            {
                grid[exit] = new Exit() { Position = exit };
            }
            catch
            {
            }
             
        }
        public void CreateTurtle(Point position, Grid grid)
        {
            try
            {
                grid[position] = Turtle.CreateInstance(position);
            }
            catch
            {
            }

            
        }
    }
}
