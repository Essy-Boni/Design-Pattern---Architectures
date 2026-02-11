using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDesignPattern.Creational.Builder
{
    internal class Person //Internal Class = portée à l'intérieur de ce projet uniquement dans cette solution
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }

        private Person(Builder builder) //On met le constructeur en private pour obliger à créer un objet de type builder en passant par la classe Builder 
        {
            FirstName = builder.FirstName ?? "";
            LastName = builder.LastName ?? "";
            Age = builder.Age;
        }

        public override string ToString()
        {
            return $"Person : firstname {FirstName}, lastname : {LastName}, age {Age}";
        }

        public sealed class Builder
        {
            public string? FirstName { get; private set; } //private set, modification qu'à l'intérieur de la classe Builder
            public string? LastName { get; private set; }
            public int Age { get; private set; }

            public Builder FirstNameValue(string firstname) //méthode public accessible partout renvoie objet/instance de type builder et recoit en paramètre firstname
            {
                FirstName = firstname;      //Set firstname
                return this;                //renvoie la valeur de firstname
            }

            public Builder LastNameValue(string lastname)
            {
                LastName = lastname;
                return this;
            }

            public Builder AgeValue(int age)
            {
                Age = age;
                return this;
            }

            public Person Build() => new(this); //Je renvoie obligatoire un objet de type person new(this) = new Person(this)
            
        }

    }
}
