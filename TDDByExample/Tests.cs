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
        public void Test_multiplication()
        {
            Dollar five = new Dollar(5);
            Assert.That(new Dollar(10), Is.EqualTo(five.times(2)));
            Assert.That(new Dollar(15), Is.EqualTo(five.times(3)));
        }

        [Test]
        public void Test_equality()
        {
            Assert.That(new Dollar(5), Is.EqualTo(new Dollar(5)));
            Assert.That(new Dollar(5), Is.Not.EqualTo(new Dollar(6)));
        }

        [Test]
        public void Test_franc_multiplication()
        {
            Dollar five = new Dollar(5);
            Assert.That(new Dollar(10), Is.EqualTo(five.times(2)));
            Assert.That(new Dollar(15), Is.EqualTo(five.times(3)));
        }
    }
}
