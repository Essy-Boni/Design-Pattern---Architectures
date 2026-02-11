using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice4_FactoryMethod.FactoryMethod
{
    internal class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Je suis un chien : J'aboie");
        }
    }
}
