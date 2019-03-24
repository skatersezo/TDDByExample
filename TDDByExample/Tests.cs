using NUnit.Framework;
using System;

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
            Money fiveDollars = Money.Dollar(5);
            Assert.That(Money.Dollar(10), Is.EqualTo(fiveDollars.Times(2)));
            Assert.That(Money.Dollar(15), Is.EqualTo(fiveDollars.Times(3)));
        }

        [Test]
        public void Test_equality()
        {
            Assert.That(Money.Dollar(5), Is.EqualTo(Money.Dollar(5)));
            Assert.That(Money.Dollar(5), Is.Not.EqualTo(Money.Dollar(6)));
            Assert.That(Money.Franc(5), Is.EqualTo(Money.Franc(5)));
            Assert.That(Money.Franc(5), Is.Not.EqualTo(Money.Franc(6)));
            Assert.That(Money.Franc(5), Is.Not.EqualTo(Money.Dollar(5)));
        }

        [Test]
        public void Test_franc_multiplication()
        {
            Money fiveFrancs = Money.Franc(5);
            Assert.That(Money.Franc(10), Is.EqualTo(fiveFrancs.Times(2)));
            Assert.That(Money.Franc(15), Is.EqualTo(fiveFrancs.Times(3)));
        }

        [Test]
        public void Test_currency()
        {
            Assert.That("USD", Is.EqualTo(Money.Dollar(1).GetCurrency()));
            Assert.That("CHF", Is.EqualTo(Money.Franc(1).GetCurrency()));

        }
    }
}
