using System;
using System.Collections.Generic;
using System.Text;
using TurtleGame.Services.Models.General;
using Xunit;

namespace TurtleGame.Test
{
    public class GameTest
    {
        [Fact]
        public void Turtle_ShouldAssertTrue_WithoutParameters()
        {
            var turtle = TurtleGame.Services.Models.General.Turtle.CreateInstance(new Point(5, 5));
            var positionX = turtle.Position.X;
            var positionY = turtle.Position.Y;
            Assert.Equal(positionX, 5);
            Assert.Equal(positionY, 5);
        }

        [Fact]
        public void Turtle_ShouldAssertFalse_WithoutParameters()
        {
            var turtle = TurtleGame.Services.Models.General.Turtle.CreateInstance(new Point(5, 6));
            var positionX = turtle.Position.X;
            var positionY = turtle.Position.Y;
            Assert.NotEqual(positionX, 5);
            Assert.NotEqual(positionY, 6);
        }
    }
}
