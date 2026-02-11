using System;
using System.Collections.Generic;
using System.Text;
using TP_SantaFactory.Models;

namespace TP_SantaFactory.Structural.Decorator.ToyDecorator
{
    internal class Wrapping : ToyDecorator
    {
            public Wrapping(IToy toy) : base(toy) { }

        public override string GetDescription() => _ToyDecore.GetDescription() + " dans un joli papier cadeau";
    }
}