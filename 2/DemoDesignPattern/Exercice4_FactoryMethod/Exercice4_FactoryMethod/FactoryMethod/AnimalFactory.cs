using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice4_FactoryMethod.FactoryMethod
{
    internal abstract class AnimalFactory 
    {
        public abstract IAnimal CreateAnimal();
    }
}
