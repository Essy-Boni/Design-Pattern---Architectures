using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercice2_StructuralPattern.Structural.Decorator
{
    internal class AddPrefix : TextTransformer
    {
        private readonly string _prefix;

        public AddPrefix(IText text, string prefix) : base(text)
        {
            _prefix = prefix;
        }

        public override string Transform()
        {
            return _prefix + _text.Transform();
        }
    }
}