using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice1.Creational.Builder
{
    internal class Home
    {
        public int Floors { get; }
        public bool HasPool { get; }
        public string? RoofType { get; }

        public string? Color { get; }


        private Home(Builder builder) //On met le constructeur en private pour obliger à créer un objet de type builder en passant par la classe Builder 
        {
            Floors = builder.Floors;
            HasPool = builder.HasPool;
            RoofType = builder.RoofType ??"M Shaped";
            Color = builder.Color?? "Yellow";
        }

        public override string ToString()
        {
            return $"Home - features | Floors: {Floors}, HasPool: {HasPool}, Roof type: {RoofType}, Color: {Color}";
        }

        public sealed class Builder
        {
            public bool HasPool { get; private set; } 
            public string? RoofType { get; private set; }
            public int Floors { get; private set; }
            public string? Color { get; private set; }

            public Builder FloorsValue(int floors)
            {
                if (floors > 0)
                {
                    Floors = floors;
                    return this;
                }
                else
                {
                    return this;
                }
            }

            public Builder HasPoolValue(bool hasPool)
            {
                HasPool = hasPool;
                return this;
            }

            public Builder RoofTypeValue(string roofType)
            {
                RoofType = roofType;
                return this;
            }

            public Builder ColorValue(string color)
            {
                Color = color;
                return this;
            }

            public Home Build() => new(this); 
        }

    }
}
