using Exercice2_StructuralPattern.Structural.Decorator;
using System.Globalization;

Console.WriteLine("STRUCTURAL PATTERNS : Decorator");

// Texte de base
IText text = new PlainText("Coucou");
Console.WriteLine(text.Transform());

// Décorateur 1 : Majuscule
IText upper = new ChangeCase(text, toUpper: true);
Console.WriteLine($"Texte en majuscule : {upper.Transform()}");

// Décorateur 2 : Ajout préfixe
IText prefix = new AddPrefix(text, "[ALERT]");
Console.WriteLine($"Avec préfixe : {prefix.Transform()}");

// Décorateur 3 : Ajout suffixe
IText suffix = new AddSuffix(text, " !!!");
Console.WriteLine($"Avec suffixe : {suffix.Transform()}");

