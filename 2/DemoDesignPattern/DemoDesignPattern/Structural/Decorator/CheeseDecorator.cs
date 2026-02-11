using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDesignPattern.Structural.Decorator
{
    internal class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza) //base sert à faire référence au Parent
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " , avec fromage";
        }

        public override double GetCost()
        {
            return base.GetCost() + 1.5;
        }
    }
}
