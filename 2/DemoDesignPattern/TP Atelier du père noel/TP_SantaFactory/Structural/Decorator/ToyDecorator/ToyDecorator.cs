using System;
using System.Collections.Generic;
using System.Text;
using TP_SantaFactory.Models;

namespace TP_SantaFactory.Structural.Decorator.ToyDecorator
{
    internal abstract class ToyDecorator : IToy
    {
        protected readonly IToy _ToyDecore;

        protected ToyDecorator(IToy Toy)
        {
            _ToyDecore = Toy ?? throw new ArgumentNullException(nameof(Toy));
        }

        public abstract string GetDescription();
    }
   
}
