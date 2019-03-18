using NUnit.Framework;

/**
 * Instrument   Shares  Price   Total
 * IBM          1000    25USD   25000USD
 * GE           400     150CHF  40000CHF
 *                              65000USD
 * 
 * From         To      Rate
 * CHF          USD     1.5
 * 
 */

namespace TDDByExample
{
    class Tests
    {
        [Test]
        public void Test_Multiplication()
        {
            Dollar five = new Dollar(5);
            five.times(2);
            Assert.That(10, Is.EqualTo(five.amount));
        }
    }

    class Dollar
    {
        public int amount { get; set; }

        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public void times(int times)
        {
            this.amount *= times;
        }
    }
}
