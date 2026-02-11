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


Console.WriteLine("\nL'usine à animaux");

//Version améliorée avec BigFactory 

var bigFactory = new BigFactory();

var chat = bigFactory.ProduireAnimal("chat");
chat.MakeSound();

var chien = bigFactory.ProduireAnimal("chien");
chien.MakeSound();

var cheval = bigFactory.ProduireAnimal("cheval");
cheval.MakeSound();

// Test animal inconnu
try
{
    var inconnu = bigFactory.ProduireAnimal("poisson");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"\nErreur : {ex.Message}");
}