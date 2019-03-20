

namespace TDDByExample
{
    class Dollar
    {
        private int amount { get; set; }

        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar times(int multiplier)
        {
            return new Dollar(this.amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            Dollar dollar = (Dollar)obj;
            return this.amount == dollar.amount;
        }
    }
}
