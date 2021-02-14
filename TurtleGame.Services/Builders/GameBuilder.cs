using System;
using System.Collections.Generic;
using System.Threading;
using TurtleGame.Services.Helpers;
using TurtleGame.Services.Models.Enums;
using TurtleGame.Services.Models.General;
using TurtleGame.Services.Models.Settings;
using TurtleGame.Services.Strategy;

namespace TurtleGame.Services.Builders
{
    public class GameBuilder
    {
        private Grid _grid;
        private ProjectSetting _projectSetting;
        private Observer _observer;
        private GameBuilder()
        {
            _projectSetting = FileHelper.GetProjectSetting();
            _grid = new Grid(_projectSetting.Size.X, _projectSetting.Size.Y);
            BoardBuilder.Build(_projectSetting.ExitPoint, _projectSetting.StartPoint, _projectSetting.MinePoints, _grid);
            _observer = ObserverBuilder.Build(_grid);
        }
        public static GameBuilder Build()
        {
            return new GameBuilder();
        }
        public void Start()
        {
            var turtle = _grid[_projectSetting.StartPoint] as Turtle;
            WriteMoveMessage(_projectSetting.Moves, turtle, _projectSetting);
        }
        int moveCount = 0;
        private void WriteMoveMessage(List<string> moves, Turtle turtle, ProjectSetting projectSetting)
        {
            PrinterHelper.Print(turtle);
            if (Enum.TryParse<Directions>(projectSetting.Direction, out var dir))
            {
                turtle.Direction = dir;
                for (int i = 0; i < moves.Count; i++)
                {
                    var array = moves[i].Split(' ');
                    var count = array.Length;
                    for (int j = 0; j < array.Length; j++)
                    {
                        MoveStrategyService.MakeMove(turtle, array[j]);
                        var observe = _observer.Observe(turtle.Position);
                        moveCount++;
                        if (observe || moveCount == count)
                        {
                            turtle.Position = new Point(1, 0);
                            turtle.Direction = Directions.N;
                            j = array.Length;
                            if (!observe && moveCount == count)
                            {
                                _observer.IsDanger();
                            }
                        }
                    }
                }
            }
        }
    }
}
