using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice4_FactoryMethod.FactoryMethod
{
    internal class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Je suis un chat : Je miaule");
        }
    }
}
