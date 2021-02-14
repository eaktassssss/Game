using System;
using System.Collections.Generic;
using System.Text;
using TurtleGame.Services.Models.General;

namespace TurtleGame.Services.Models.Moves
{
    public class RotateRight : MoveBase
    {
        readonly Turtle _turtle;
        public RotateRight(Turtle turtle)
        {
            _turtle = turtle;
        }
        public override void MoveTurtle()
        {
            _turtle.RotateRight();
        }
    }
}
