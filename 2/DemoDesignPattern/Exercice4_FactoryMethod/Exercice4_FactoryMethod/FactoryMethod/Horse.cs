using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice4_FactoryMethod.FactoryMethod
{
    internal class Horse : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Je suis un cheval : Je hennis");
        }
    }
}
