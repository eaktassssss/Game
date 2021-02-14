
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TurtleGame.Services.Models.General;
using TurtleGame.Services.Models.Settings;

namespace TurtleGame.Services.Helpers
{
    public class FileHelper
    {
        public static ProjectSetting GetProjectSetting()
        {
            var settingString = File.ReadAllLines(@"C:\Users\EVREN\source\repos\TurtleGame\TurtleGame.UI\Settings\project.txt");
            var settings = new ProjectSetting();

            var sizeStrings = settingString[0].Split(' ');
            int.TryParse(sizeStrings[0], out var sizeX);
            int.TryParse(sizeStrings[1], out var sizeY);
            settings.Size = new Point(sizeX, sizeY);

            var startPositionStrings = settingString[3].Split(' ');
            int.TryParse(startPositionStrings[0], out var posX);
            int.TryParse(startPositionStrings[1], out var posY);
            settings.StartPoint = new Point(posX, posY);
            settings.Direction = startPositionStrings[2];

            var exitPointStrings = settingString[2].Split(' ');
            int.TryParse(exitPointStrings[0], out var exitX);
            int.TryParse(exitPointStrings[1], out var exitY);
            settings.ExitPoint = new Point(exitX, exitY);

            var moves = new List<string>();
            for (int i = 4; i < settingString.Length; i++)
            {
                moves.Add(settingString[i]);
            }
            settings.Moves = moves;
            var mines = settingString[1].Split(' ');
            for (int i = 0; i < mines.Length; i++)
            {
                var split = mines[i].Split(',');
                settings.MinePoints.Add(new Point(int.Parse(split[0]), int.Parse(split[1])));
            }
            return settings;
        }
    }
}
