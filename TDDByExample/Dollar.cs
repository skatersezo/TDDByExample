

namespace TDDByExample
{
    class Dollar : Money
    {
        // Base properties
        // int Amount;
        // string Currency;

        public Dollar(int amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public override string GetCurrency()
        {
            return Currency;
        }

        public override Money Times(int multiplier)
        {
            return Money.Dollar(Amount * multiplier);
        }
    }
}
