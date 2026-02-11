using System;
using System.Collections.Generic;
using System.Text;
using TP_SantaFactory.Models;

namespace TP_SantaFactory.Structural.Decorator.ToyDecorator
{
    internal class Ribbon : ToyDecorator
    {
        public Ribbon(IToy toy) : base(toy) { }

        public override string GetDescription() => _ToyDecore.GetDescription() + " avec un joli ruban";
    }
}

