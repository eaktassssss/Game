using System;
using System.Collections.Generic;
using System.Text;
using TurtleGame.Services.Models.Enums;
using TurtleGame.Services.Models.General;
using TurtleGame.Services.Models.Moves;

namespace TurtleGame.Services.Strategy
{
    public class MoveFactory
    {
        public static MoveBase GetMove(Turtle turtle, string moveType)
        {
            if (moveType.Trim().ToUpper() == Moves.R.ToString().Trim().ToUpper())
            {
                return new RotateRight(turtle);
            }
            if (moveType.Trim().ToUpper() == Moves.L.ToString().Trim().ToUpper())
                return new RotateLeft(turtle);
            else if (moveType.Trim().ToUpper() == Moves.M.ToString().Trim().ToUpper())
                return new Move(turtle);
            else
                return new UnhandledMove();
        }
    }
}
