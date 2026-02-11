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
        var lutin_Prod = new Lutin("Lutin_Prod");
        var lutin_Deliveroo = new Lutin("Lutin_Deliveroo");

        production.AddObserver(lutin_Prod);
        production.AddObserver(lutin_Deliveroo);

        ToyFactory factory = new DollFactory();
        var Toy = factory.CreateToy();
        Toy.GetDescription();

        lutin_Prod.Notifier($"Nouveau jouet produit : {Toy.GetDescription()} !!!");

        ToyFactory factory2 = new TrainFactory();
        var Toy2 = factory2.CreateToy();
        Toy.GetDescription();

        lutin_Prod.Notifier($"Nouveau jouet produit : {Toy2.GetDescription()} !!!");
        

        Console.WriteLine("\nJouets avant decoration:");
        Console.WriteLine("=======================");
        Console.WriteLine(Toy.GetDescription());
        Console.WriteLine(Toy2.GetDescription());

       

        // Decorer les Toys
        IToy dollDecore = new Ribbon(Toy);
        IToy trainDecore = new Wrapping(
            new Ribbon(Toy2)
        );

        Console.WriteLine("\nJouets avec decoration :");
        Console.WriteLine("==========================");
        Console.WriteLine(dollDecore.GetDescription());
        Console.WriteLine(trainDecore.GetDescription());

        lutin_Deliveroo.Notifier($"Cadeaux prêts pour la cheminée : {dollDecore.GetDescription()} ; {trainDecore.GetDescription()} !!!");

        Console.WriteLine("\nImplémentation d'une Big Factory :");
        Console.WriteLine("====================================");
       
        //var lutin3 = new Lutin("Lutin 3");
        //var lutin4 = new Lutin("Lutin 4");
        //production.AddObserver(lutin3);
        //production.AddObserver(lutin4);


        var bigFactory = new BigFactory();

        var doll = bigFactory.ProduceToy("doll");
        var train = bigFactory.ProduceToy("train");
        var gameBoy = bigFactory.ProduceToy("gameboy");
        var terminator = bigFactory.ProduceToy("terminator");
        lutin_Prod.Notifier($"[ALERT]Nouveaux jouets produits : {doll.GetDescription()}, {train.GetDescription()}, {gameBoy.GetDescription()}, {terminator.GetDescription()}!!!!");

        IToy train2Decore = new Wrapping(new Ribbon(train));
        IToy gameBoyDecore = new Wrapping(gameBoy);
        lutin_Deliveroo.Notifier($"Cadeau prêt pour la cheminée : {train2Decore.GetDescription()}, {gameBoyDecore.GetDescription()}!!!");

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