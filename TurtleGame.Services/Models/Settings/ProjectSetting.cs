using System;
using System.Collections.Generic;

using System.Text;
using TurtleGame.Services.Models.General;

namespace TurtleGame.Services.Models.Settings
{
    public class ProjectSetting
    {
        public Point Size { get; set; }
        public Point StartPoint { get; set; }
        public Point ExitPoint { get; set; }
        public List<Point> MinePoints { get; set; } = new List<Point>();
        public string Direction { get; set; }

        public List<string> Moves { get; set; } = new List<string>();
    }
}
