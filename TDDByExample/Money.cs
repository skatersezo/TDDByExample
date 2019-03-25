
using System;

namespace TDDByExample
{
    class Money : Xpression
    {
        protected int Amount { get; set; }
        public string Currency { get; set; }

        public Money(int amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        public Money Times(int multiplier)
        {
            return new Money(Amount * multiplier, Currency);
        }

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return Amount == money.Amount
                && Currency.Equals(money.Currency);
        }

        public Xpression Plus(Money addend)
        {
            return new Money(Amount + addend.Amount, Currency);
        }

        public override string ToString()
        {
            return $"{Amount} {Currency}";
        }
        
    }
}
