 
using System;
using TurtleGame.Services.Models.Colors;
using TurtleGame.Services.Models.Enums;
using TurtleGame.Services.Models.General;
using TurtleGame.Services.Strategy;

namespace TurtleGame.Services.Helpers
{
    public  class PrinterHelper
    {
        public static void Print(Point pointFrom, Point pointTo)
        {
            var context = new ColorStrategyContext(new Yellow());
            context.ChangeColor();
            var combinePointFrom = $"({pointFrom.X},{pointFrom.Y})";
            var combinePointTo = $"({pointTo.X},{pointTo.Y})";
            var printText = Message.MovedFromTo.Replace("{from}", combinePointFrom).Replace("{to}", combinePointTo);
            Console.WriteLine(printText);
            var contextRed = new ColorStrategyContext(new Red());
            contextRed.ChangeColor();
            Console.WriteLine(new string('-', 50));
        }

        public static void Print(string text)
        {
            var contextWhite = new ColorStrategyContext(new White());
            contextWhite.ChangeColor();
            Console.WriteLine(text);
            var contextRed = new ColorStrategyContext(new Red());
            contextRed.ChangeColor();
            Console.WriteLine(new string('-', 50));
        }

        public static void Print(Directions dir)
        {
            var contextWhite = new ColorStrategyContext(new White());
            contextWhite.ChangeColor();
            Console.WriteLine(Message.Rotate.Replace("{to}", dir.ToString()));
            var contextRed = new ColorStrategyContext(new Red());
            contextRed.ChangeColor();
            Console.WriteLine(new string('-', 50));
        }

        public static void Print(Turtle turtle)
        {
            var contextWhite = new ColorStrategyContext(new White());
            contextWhite.ChangeColor();
            Console.WriteLine(Message.StartPosition.Replace("{x}", turtle.Position.X.ToString()).Replace("{y}", turtle.Position.Y.ToString()).Replace("{dir}", turtle.Direction.ToString()));
            var contextRed = new ColorStrategyContext(new Red());
            contextRed.ChangeColor();
            Console.WriteLine(new string('-', 50));
        }
    }
}
