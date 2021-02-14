using System;
using System.Collections.Generic;
using TurtleGame.Services.Models.General;
using TurtleGame.Services.Models.Moves;
using TurtleGame.Services.Strategy;

namespace TurtleGame.Services.Strategy
{
   
    
    public static class MoveStrategyService
    {
        public static void MakeMove(Turtle turtle, string moveType)
        {
            #region 
            //if (moveType.Trim().ToUpper() == Moves.R.ToString().Trim().ToUpper() ||
            //        moveType.Trim().ToUpper() == Moves.L.ToString().Trim().ToUpper())
            //{
            //    turtle.Rotate(moveType.Trim().ToUpper());
            //}
            //else if (moveType.Trim().ToUpper() == Moves.M.ToString().Trim().ToUpper())
            //{
            //    turtle.Move();
            //}
            #endregion
            MoveFactory.GetMove(turtle, moveType).MoveTurtle();
        }
    }
   

   

    
    public class UnhandledMove : MoveBase
    {
        public override void MoveTurtle() => Console.WriteLine("Unhandled Move");
    }
}
