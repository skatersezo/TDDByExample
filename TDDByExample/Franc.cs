namespace TDDByExample
{
    class Franc : Money
    {
        // Base properties
        // int Amount
        // string Currency

        public Franc(int amount, string currency)
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
            return Money.Franc(Amount * multiplier);
        }

    }
}