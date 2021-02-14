using System;
using System.Collections.Generic;
using System.Text;
using TurtleGame.Services.Models.General;

namespace TurtleGame.Services.Models.Moves
{
    public class RotateLeft : MoveBase
    {
        readonly Turtle _turtle;
        public RotateLeft(Turtle turtle)
        {
            _turtle = turtle;
        }
        public override void MoveTurtle()
        {
            _turtle.RotateLeft();
        }
    }
}
