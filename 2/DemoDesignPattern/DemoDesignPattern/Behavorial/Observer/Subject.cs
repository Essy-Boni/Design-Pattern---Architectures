using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDesignPattern.Behavorial.Observer
{
    internal class Subject
    {
        private readonly List<IObserver> _observers = new List<IObserver>(); //Initialisation de la liste d'espions. 

        public void AddObserver(IObserver observer) => _observers.Add(observer);
        public void RemoveObserver(IObserver observer) => _observers.Remove(observer);

        //A rajouter dans toutes les classes qu'on souhaite observer :
        public void NotifyObserver(string message)
        { 
            foreach (var observer in _observers)
                observer.Update(message);
        }


    }
}
