// See https://aka.ms/new-console-template for more information
using Exercice4_FactoryMethod.FactoryMethod;

Console.WriteLine("Apprenons le langage des animaux... ");

AnimalFactory factory = new DogFactory();
var Animal = factory.CreateAnimal();
Animal.MakeSound();

factory = new HorseFactory();
Animal = factory.CreateAnimal();
Animal.MakeSound();

factory = new CatFactory();
Animal = factory.CreateAnimal();
Animal.MakeSound();
