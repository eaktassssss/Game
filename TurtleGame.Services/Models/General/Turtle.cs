using System;
using System.Collections.Generic;
using System.Text;
using TurtleGame.Services.Helpers;
using TurtleGame.Services.Models.Enums;

namespace TurtleGame.Services.Models.General
{
    public class Turtle : Element
    {
        public Directions Direction { get; set; }
        private static Turtle _turtle;
        private Turtle(Point position)
        {
            Position = position;
        }
        public static Turtle CreateInstance(Point position)
        {
            return _turtle ?? (_turtle = new Turtle(position));
        }
        public void Move()
        {
            switch (Direction)
            {
                case Directions.N:
                    PrinterHelper.Print(_turtle.Position, new Point { X = _turtle.Position.X, Y = _turtle.Position.Y + 1 });
                    _turtle.Position = new Point { X = _turtle.Position.X, Y = _turtle.Position.Y + 1 };
                    break;
                case Directions.S:
                    PrinterHelper.Print(_turtle.Position, new Point { X = _turtle.Position.X, Y = _turtle.Position.Y - 1 });
                    _turtle.Position = new Point { X = _turtle.Position.X, Y = _turtle.Position.Y - 1 };
                    break;
                case Directions.E:
                    PrinterHelper.Print(_turtle.Position, new Point { X = _turtle.Position.X + 1, Y = _turtle.Position.Y });
                    _turtle.Position = new Point { X = _turtle.Position.X + 1, Y = _turtle.Position.Y };
                    break;
                case Directions.W:
                    PrinterHelper.Print(_turtle.Position, new Point { X = _turtle.Position.X - 1, Y = _turtle.Position.Y });
                    _turtle.Position = new Point { X = _turtle.Position.X - 1, Y = _turtle.Position.Y };
                    break;
            }
        }
        // İki Rotate Fonksinyonu kullanılmak istenilmez ise 
        //public void Rotate(string dir)
        //{

        //    if (dir == "R")
        //    {
        //        var tmp = (int)(Direction + 90) % 360;
        //        Direction = (Directions)tmp;
        //    }
        //    else if (dir == "L")
        //    {
        //        var tmp = (int)(Direction + 270) % 360;
        //        Direction = (Directions)tmp;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid Direction");
        //    }
        //    PrinterHelper.Print(Direction);
        //}

        public void RotateRight()
        {

            switch (Direction)
            {
                case Directions.N:
                    Direction = Directions.E;
                    PrinterHelper.Print(Direction);
                    break;
                case Directions.E:
                    Direction = Directions.S;
                    PrinterHelper.Print(Direction);
                    break;
                case Directions.S:
                    Direction = Directions.W;
                    PrinterHelper.Print(Direction);
                    break;
                case Directions.W:
                    Direction = Directions.N;
                    PrinterHelper.Print(Direction);
                    break;
                default:
                    break;
            }
          
        }
        public void RotateLeft()
        {
            switch (Direction)
            {
                case Directions.N:
                    Direction = Directions.W;
                    PrinterHelper.Print(Direction);
                    break;
                case Directions.W:
                    Direction = Directions.S;
                    PrinterHelper.Print(Direction);
                    break;
                case Directions.S:
                    Direction = Directions.E;
                    PrinterHelper.Print(Direction);
                    break;
                case Directions.E:
                    Direction = Directions.N;
                    PrinterHelper.Print(Direction);
                    break;
                default:
                    break;
            }
        }
    }
}
