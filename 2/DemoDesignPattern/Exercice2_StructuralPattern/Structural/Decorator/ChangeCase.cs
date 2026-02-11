using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice2_StructuralPattern.Structural.Decorator
{
    internal class ChangeCase: TextTransformer
    {
        private readonly bool _toUpper;

        public ChangeCase(IText text, bool toUpper = true) : base(text)
        {
            _toUpper = toUpper;
        }

        public override string Transform()
        {
            string result = _text.Transform();
            return _toUpper ? result.ToUpper() : result.ToLower();
        }
    }
}
