using System;
using System.Collections.Generic;
using System.Text;
using TurtleGame.Services.Models.General;

namespace TurtleGame.Services.Models.Moves
{
    public class Move : MoveBase
    {
        readonly Turtle _turtle;
        public Move(Turtle turtle)
        {
            _turtle = turtle;
        }
        public override void MoveTurtle()
        {
            _turtle.Move();

        }
    }
}
