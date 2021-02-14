using System;
using System.Collections.Generic;
using System.Text;

namespace TurtleGame.Services.Strategy
{
    public class ColorStrategyContext
    {
        ColorStrategy _providerStrategy;
        public ColorStrategyContext(ColorStrategy providerStrategy)
        {
            _providerStrategy = providerStrategy;
        }
        public void ChangeColor() => _providerStrategy.ChangeColor();
    }
}
