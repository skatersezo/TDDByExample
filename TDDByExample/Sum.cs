namespace TDDByExample
{
    public class Sum : Xpression
    {
        public Money Augend { get; set; }
        public Money Addend { get; set; }

        public Sum(Money augend, Money addend)
        {
            Augend = augend;
            Addend = addend;
        }

        public Money Reduce(string to)
        {
            int amount = Augend.Amount + Addend.Amount;
            return new Money(amount, to);
        }

        public Money Reduce(Bank bank, string to)
        {
            int amount = Augend.Amount + Addend.Amount;
            return new Money(amount, to);
        }
    }
}