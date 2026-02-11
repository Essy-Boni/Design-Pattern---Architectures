using System;
using System.Collections.Generic;
using System.Text;
using TP_SantaFactory.Models;

namespace TP_SantaFactory.Behavorial.Observer
{
    internal class ProductionManager 
    {
        private readonly List<ILutin> _observers = new List<ILutin>();

        public void AddObserver(ILutin observer) => _observers.Add(observer);
        public void RemoveObserver(ILutin observer) => _observers.Remove(observer);

        public void NotifyObservers(string message)
        {
            foreach (var observer in _observers)
                observer.Notifier(message);
        }

    } 
}
