using System;
using System.Collections.Generic;
using System.Text;
using TP_SantaFactory.Models;

namespace TP_SantaFactory.Creational.FactoryMethod
{
    internal class BigFactory
    {
        private readonly Dictionary<string, ToyFactory> _factories;

        public BigFactory()
        {
            _factories = new Dictionary<string, ToyFactory>(StringComparer.OrdinalIgnoreCase)
            {
                { "doll", new DollFactory() },
                { "train", new TrainFactory() },
                { "gameboy", new GameBoyFactory() },
                { "terminator", new GameBoyFactory() }

            };
        }

        public IToy ProduceToy(string key) 
        {
            if (_factories.TryGetValue(key, out var factory))
            {
                return factory.CreateToy();
            }
            throw new ArgumentException($"Jouet inconnu : '{key}'. Catalogue de l'usine : {string.Join(", ", _factories.Keys)}");
        }

    }
}
