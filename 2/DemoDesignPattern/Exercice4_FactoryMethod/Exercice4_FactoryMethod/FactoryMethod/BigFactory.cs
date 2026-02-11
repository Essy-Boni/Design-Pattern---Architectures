using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice4_FactoryMethod.FactoryMethod
{
    internal class BigFactory
    {
        private readonly Dictionary<string, AnimalFactory> _factories;

        public BigFactory()
        {
            _factories = new Dictionary<string, AnimalFactory>(StringComparer.OrdinalIgnoreCase)
        {
            { "chat", new CatFactory() },
            { "chien", new DogFactory() },
            { "cheval", new HorseFactory() }
        };
        }

        public IAnimal ProduireAnimal(string key) //Je peux placer n'importe quel type d'animal grâce au couplage faible (avec interface)
        {
            if (_factories.TryGetValue(key, out var factory))
            {
                return factory.CreateAnimal();
            }
            throw new ArgumentException($"Animal inconnu : '{key}'. Animaux disponibles : {string.Join(", ", _factories.Keys)}");
        }

        // Permet d'ajouter de nouveaux animaux dynamiquement
        public void AjouterFactory(string key, AnimalFactory factory)
        {
            _factories[key.ToLower()] = factory;
        }

    }
}
