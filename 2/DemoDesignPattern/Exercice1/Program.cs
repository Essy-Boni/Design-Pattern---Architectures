using Exercice1.Creational.Builder;

Console.WriteLine("Demo Design Pattern");

Home home = new Home.Builder()
    .FloorsValue(3)
    .ColorValue("Blue")
    .RoofTypeValue("Gambrel")
    .Build();
Console.WriteLine(home);

var Home2 = new Home.Builder()
    .ColorValue("White")
    .HasPoolValue(true)
    .Build();
Console.WriteLine(Home2);

var Home3 = new Home.Builder()
    .RoofTypeValue("Mansard")
    .FloorsValue(-2)
    .Build();
Console.WriteLine(Home3);

var Home4 = new Home.Builder()
    .HasPoolValue(false)
    .FloorsValue(2)
    .Build();
Console.WriteLine(Home4);

var Home5 = new Home.Builder()
    .RoofTypeValue("Saltbox")
    .HasPoolValue(true)
    .Build();
Console.WriteLine(Home5);