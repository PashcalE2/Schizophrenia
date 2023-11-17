using System;

namespace Schizophrenia
{
    public abstract class AnyValidator<T>
    {
        protected T Result;
        protected Func<T, bool> Condition;

        public AnyValidator()
        {
            Condition = (value) => true;
        }

        public AnyValidator(Func<T, bool> condition)
        {
            Condition = condition;
        }

        protected abstract bool ValidateValue(string value);

        public bool Validate(string value)
        {
            bool isValidated = ValidateValue(value);
            return isValidated && Condition.Invoke(Result);
        }

        public T GetResult()
        {
            return Result;
        }
    }

    public class DoubleValidator : AnyValidator<double>
    {
        public DoubleValidator() : base()
        {
        }

        public DoubleValidator(Func<double, bool> condition) : base(condition)
        {
        }

        protected override bool ValidateValue(string value)
        {
            return double.TryParse(value, out Result);
        }
    }

    public class IntValidator : AnyValidator<int>
    {
        public IntValidator() : base()
        {
        }

        public IntValidator(Func<int, bool> condition) : base(condition)
        {
        }

        protected override bool ValidateValue(string value)
        {
            return int.TryParse(value, out Result);
        }
    }

    public static class Validators
    {
        public static readonly DoubleValidator DefaultDoubleValidator = new DoubleValidator();
        public static readonly IntValidator DefaultIntValidator = new IntValidator();
    }
}
