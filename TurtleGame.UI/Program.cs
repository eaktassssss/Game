using System;
using System.Threading;
using TurtleGame.Services.Builders;

namespace TurtleGame.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            GameBuilder.Build().Start();
            Thread.Sleep(60000);
            System.Console.ReadKey();
        }
    }
}
