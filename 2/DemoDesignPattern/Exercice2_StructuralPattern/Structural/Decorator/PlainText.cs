using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice2_StructuralPattern.Structural.Decorator
{
    internal class PlainText : IText
    {
        private readonly string _text;

        public PlainText(string text) => _text = text;
        
        public string Transform() => _text;

    }
}
