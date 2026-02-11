using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDesignPattern.Structural.Decorator
{
    internal abstract class PizzaDecorator : IPizza //Elle n'a pas pour objectif d'êtreinstanciée (abstract) mais transmettre par heritage à d'autres classes Decorator
    {
        protected readonly IPizza Pizza; //readonly avec la valeur constante inscrite ne peut être modifiée & coûplage réduit avec IPizza et Pizza
        protected PizzaDecorator(IPizza pizza)
        { 
            this.Pizza = pizza;
        }

        //Avec virtual, on autorise une surchage avec override
        public virtual string GetDescription() => Pizza.GetDescription();
        public virtual double GetCost() => Pizza.GetCost();
    }
}
