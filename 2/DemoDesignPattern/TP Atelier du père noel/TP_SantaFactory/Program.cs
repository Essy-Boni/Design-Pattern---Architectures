using System.Threading.Channels;
using TP_SantaFactory.Behavorial.Observer;
using TP_SantaFactory.Creational.FactoryMethod;
using TP_SantaFactory.Models;
using TP_SantaFactory.Structural.Decorator.ToyDecorator;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\nTP Atelier du Pere Noel");

        var production = new ProductionManager();
        var lutin1 = new Lutin("Lutin 1");
        var lutin2 = new Lutin("Lutin 2");

        production.AddObserver(lutin1);
        production.AddObserver(lutin2);

        ToyFactory factory = new DollFactory();
        var Toy = factory.CreateToy();
        Toy.GetDescription();

        lutin1.Notifier($"Nouveau jouet produit : {Toy.GetDescription()} !!!");

        ToyFactory factory2 = new TrainFactory();
        var Toy2 = factory2.CreateToy();
        Toy.GetDescription();

        lutin2.Notifier($"Nouveau jouet produit : {Toy2.GetDescription()} !!!");
        

        Console.WriteLine("\nJouets avant decoration:");
        Console.WriteLine("=======================");
        Console.WriteLine(Toy.GetDescription());
        Console.WriteLine(Toy2.GetDescription());

       

        // Decorer les Toys
        IToy dollDecore = new Ribbon(Toy);
        IToy trainDecoree = new Wrapping(
            new Ribbon(Toy2)
        );

        Console.WriteLine("\nJouets avec decoration :");
        Console.WriteLine("==========================");
        Console.WriteLine(dollDecore.GetDescription());
        Console.WriteLine(trainDecoree.GetDescription());

        Console.WriteLine("\nImplémentation d'une Big Factory :");
        Console.WriteLine("====================================");
       
        var lutin3 = new Lutin("Lutin 3");
        var lutin4 = new Lutin("Lutin 4");
        production.AddObserver(lutin3);
        production.AddObserver(lutin4);


        var bigFactory = new BigFactory();

        var doll = bigFactory.ProduceToy("doll");
        lutin1.Notifier($"[ALERT]Nouveau jouet produit : {doll.GetDescription()} !!!");

        var train = bigFactory.ProduceToy("train");
        lutin2.Notifier($"[ALERT]Nouveau jouet produit : {train.GetDescription()} !!!");

        var gameboy = bigFactory.ProduceToy("gameboy");
        lutin3.Notifier($"[ALERT]Nouveau jouet produit : {gameboy.GetDescription()} !!!");

        var terminator = bigFactory.ProduceToy("terminator");
        lutin4.Notifier($"[ALERT]Nouveau jouet produit : {terminator.GetDescription()} !!!");

        IToy train2Decore = new Wrapping(
            new Ribbon(train)
        );
        lutin2.Notifier($"Cadeau prêt pour la cheminée : {train2Decore.GetDescription()} !!!");

        //// Test jouet inconnu
        //try
        //{
        //    var inconnu = bigFactory.ProduceToy("avion");
        //}
        //catch (ArgumentException ex)
        //{
        //    Console.WriteLine($"\nErreur : {ex.Message}");
        //}
    }

}