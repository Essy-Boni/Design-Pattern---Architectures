using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice2_StructuralPattern.Structural.Decorator
{
    internal class AddSuffix : TextTransformer
    {
        private readonly string _suffix;

        public AddSuffix(IText text, string suffix) : base(text)
        {
            _suffix = suffix;
        }

        public override string Transform()
        {
            return _text.Transform() + _suffix;
        }
    }
}