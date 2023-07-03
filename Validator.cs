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

    public class PositiveDoubleValidator : DoubleValidator
    {
        public override bool Validate(string value)
        {
            return base.Validate(value) && (Result > 0);
        }
    }

    public class IntValidator : AnyValidator<int>
    {
        public override bool Validate(string value)
        {
            return int.TryParse(value, out Result);
        }
    }

    public class CTValidator : IntValidator
    {
        public override bool Validate(string value)
        {
            return base.Validate(value) && (Result >= 5) && (Result <= 9);
        }
    }

    public static class Validators
    {
        public static readonly DoubleValidator DefaultDoubleValidator = new DoubleValidator();
        public static readonly PositiveDoubleValidator PositiveDoubleValidator = new PositiveDoubleValidator();
        public static readonly IntValidator DefaultIntValidator = new IntValidator();
        public static readonly CTValidator CTValidator = new CTValidator();
    }
}
