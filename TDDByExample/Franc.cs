namespace TDDByExample
{
    class Franc
    {
        private int amount { get; set; }

        public Franc(int amount) => this.amount = amount;

        public Franc times(int multiplier)
        {
            return new Franc(this.amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            Franc dollar = (Franc)obj;
            return this.amount == dollar.amount;
        }
    }
}