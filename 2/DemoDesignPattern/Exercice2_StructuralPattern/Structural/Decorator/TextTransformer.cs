using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice2_StructuralPattern.Structural.Decorator
{
    internal abstract class TextTransformer : IText 
    {
        protected readonly IText _text;

        protected TextTransformer(IText text)
        {
            _text = text;
        }

        public abstract string Transform();
    }
}