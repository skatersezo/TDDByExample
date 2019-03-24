
using System;

namespace TDDByExample
{
    abstract class Money
    {
        protected int Amount { get; set; }
        protected string Currency;

        public static Dollar Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Franc Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public abstract Money Times(int multiplier);

        public abstract string GetCurrency();

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return Amount == money.Amount
                && GetType().Name.Equals(money.GetType().Name);
        }
    }
}
