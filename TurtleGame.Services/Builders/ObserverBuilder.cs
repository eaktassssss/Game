 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TurtleGame.Services.Models.General;

namespace TurtleGame.Services.Builders
{
    public class ObserverBuilder
    {
        public static Observer Build(Grid grid)
        {
            return new Observer(grid).Build();
        }
    }
}
