using System;
using System.Collections.Generic;
using System.Text;
using TP_SantaFactory.Models;

namespace TP_SantaFactory.Creational.FactoryMethod
{
    internal class DollFactory : ToyFactory
    {
        public override IToy CreateToy() => new Doll();
    }
}
