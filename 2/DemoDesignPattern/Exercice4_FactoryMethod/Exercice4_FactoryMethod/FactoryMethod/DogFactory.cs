using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice4_FactoryMethod.FactoryMethod
{
    internal class DogFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            return new Dog();
        }
    }
}
