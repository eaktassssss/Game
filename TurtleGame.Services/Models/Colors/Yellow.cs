﻿ 
using System;
using TurtleGame.Services.Strategy;

namespace TurtleGame.Services.Models.Colors
{
    public class Yellow : ColorStrategy
    {
        public override void ChangeColor() => Console.ForegroundColor = ConsoleColor.Yellow;
    }
}
