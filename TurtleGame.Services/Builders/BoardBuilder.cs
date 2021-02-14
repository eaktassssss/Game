using System.Collections.Generic;
using TurtleGame.Services.Models.General;

namespace TurtleGame.Services.Builders
{

    public class BoardBuilder
    {
        public static void Build(Point exit, Point position, List<Point> mines, Grid grid)
        {
            var board = new Board();
            board.CreateTurtle(position, grid);
            board.CreateExit(exit, grid);
            board.CreateMines(mines, grid);
        }
    }
}
