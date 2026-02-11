using System;
using System.Collections.Generic;
using System.Text;

namespace TP_SantaFactory.Behavorial.Observer
{
    internal class Lutin : ILutin
    {
        private readonly String _name;
        public Lutin(string name)
        {
            _name = name;
        }

        public void Notifier(string message)
        {
            Console.WriteLine($"{_name} received : {message}");
        }
    }
}