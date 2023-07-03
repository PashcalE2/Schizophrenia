using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schizophrenia
{
    public abstract class AnyValidator<T>
    {
        protected T Result;
        public abstract bool Validate(string value);

        public T GetResult()
        {
            return Result;
        }
    }

    public class DoubleValidator : AnyValidator<double>
    {
        public override bool Validate(string value)
        {
            return double.TryParse(value, out Result);
        }
    }

    public static class Validators
    {
        public static readonly DoubleValidator DefaultDoubleValidator = new DoubleValidator();
    }
}
