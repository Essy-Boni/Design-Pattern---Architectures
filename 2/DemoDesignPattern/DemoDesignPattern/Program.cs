
using DemoDesignPattern.Behavorial.Observer;
using DemoDesignPattern.Creational.Builder;
using DemoDesignPattern.Creational.FactoryMethod;
using DemoDesignPattern.Structural.Decorator;

Console.WriteLine("Demo Design Pattern");

/* CREATIONAL PATTERN : Builder
//Person person = new Person.Builder()
//    .LastNameValue("Dupont")
//    .AgeValue(42)
//    .FirstNameValue("Marie")
//    .Build();

//Console.WriteLine(person);

//var person2 = new Person.Builder()
//    .AgeValue(43)
//    .Build();
//Console.WriteLine(person2);

var person3 = new Person.Builder()
    .FirstNameValue("toto")
    .LastNameValue("tata")
    .Build();
Console.WriteLine(person3); */

/* CREATIONAL PATTERN : Factory Method*/

VehicleFactory factory = new CarFactory();
var vehicle = factory.CreateVehicle();
vehicle.Drive();

factory=new TruckFactory();
vehicle = factory.CreateVehicle();
vehicle.Drive();


/* STRUCTURAL PATTERN : Decorator
//Pizza avec toutes les décorations (olive et fromage)
IPizza pizza = new PlainPizza();
pizza = new CheeseDecorator(pizza);
pizza = new OliveDecorator(pizza);
Console.WriteLine(pizza.GetDescription());
Console.WriteLine(pizza.GetCost());

//Pizza standard sans décoration
IPizza pizza1 = new PlainPizza();
Console.WriteLine(pizza1.GetDescription());
Console.WriteLine(pizza1.GetCost());

//Pizza avec seulement des olives
IPizza pizza2 = new PlainPizza();
pizza2 = new OliveDecorator(pizza2);
Console.WriteLine(pizza2.GetDescription());
Console.WriteLine(pizza2.GetCost());*/

/* STRUCTURAL PATTERN : Decorator

var subject = new Subject();
subject.AddObserver(new MyObserver("Espion 1"));
subject.AddObserver(new MyObserver("Espion 2"));

subject.NotifyObserver("Hello World");*/