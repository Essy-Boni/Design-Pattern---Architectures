using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDesignPattern.Structural.Decorator
{
    internal class OliveDecorator : PizzaDecorator
    {
        public OliveDecorator(IPizza pizza) : base(pizza) //base sert à faire référence au Parent
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " , avec olive ";
        }

        public override double GetCost()
        {
            return base.GetCost() + 1.0;
        }
    }
}