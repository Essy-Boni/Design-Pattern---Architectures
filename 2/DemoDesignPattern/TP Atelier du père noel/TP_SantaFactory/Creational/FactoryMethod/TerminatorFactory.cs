using System;
using System.Collections.Generic;
using System.Text;
using TP_SantaFactory.Models;

namespace TP_SantaFactory.Creational.FactoryMethod
{
    internal class TerminatorFactory : ToyFactory
    {
        public override IToy CreateToy() => new Terminator();
    }
}
