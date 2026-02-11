using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDesignPattern.Structural.Decorator
{
    internal interface IPizza  //On ne met qua des signatures de methodes à l'interieur : nom, type paramètres
    {
        string GetDescription();
        double GetCost();

    }
}
