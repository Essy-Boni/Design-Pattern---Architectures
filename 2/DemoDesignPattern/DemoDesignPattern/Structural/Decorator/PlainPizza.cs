using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDesignPattern.Structural.Decorator
{
    internal class PlainPizza : IPizza
    {
        public double GetCost() => 5.0;

        public string GetDescription() => "Plain Pizza"; // => équivalent de {return ...;}
        
    }
}
