
using System;

namespace TDDByExample
{
    public class Money : Xpression
    {
        public int Amount { get; set; }
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
            return new Sum(this, addend);
        }

        public override string ToString()
        {
            return $"{Amount} {Currency}";
        }

        public Money Reduce(Bank bank, string to)
        {
            int rate = bank.Rate(Currency, to);
            return new Money(rate, to);
        }

        public Money Reduce(string to)
        {
            int rate = (Currency.Equals("CHF") && to.Equals("USD"))
                ? 2
                : 1;
            return new Money(Amount / rate, to);
        }
    }
}
