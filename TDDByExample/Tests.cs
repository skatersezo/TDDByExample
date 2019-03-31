using NUnit.Framework;
using System;
using System.Linq.Expressions;
using System.Reflection;

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
        public void TestMultiplication()
        {
            Money fiveDollars = Money.Dollar(5);
            Assert.That(Money.Dollar(10), Is.EqualTo(fiveDollars.Times(2)));
            Assert.That(Money.Dollar(15), Is.EqualTo(fiveDollars.Times(3)));
        }

        [Test]
        public void TestEquality()
        {
            Assert.That(Money.Dollar(5), Is.EqualTo(Money.Dollar(5)));
            Assert.That(Money.Dollar(5), Is.Not.EqualTo(Money.Dollar(6)));
            Assert.That(Money.Franc(5), Is.Not.EqualTo(Money.Dollar(5)));
        }

        [Test]
        public void TestFrancMultiplication()
        {
            Money fiveFrancs = Money.Franc(5);
            Assert.That(Money.Franc(10), Is.EqualTo(fiveFrancs.Times(2)));
            Assert.That(Money.Franc(15), Is.EqualTo(fiveFrancs.Times(3)));
        }

        [Test]
        public void TestCurrency()
        {
            Assert.That("USD", Is.EqualTo(Money.Dollar(1).Currency));
            Assert.That("CHF", Is.EqualTo(Money.Franc(1).Currency));

        }

        [Test]
        public void TestSimpleAddition()
        {
            Money five = Money.Dollar(5);
            Xpression sum = five.Plus(five);
            Bank bank = new Bank();
            Money reduced = bank.Reduce(sum, "USD");
            Assert.That(Money.Dollar(10), Is.EqualTo(reduced));
        }

        [Test]
        public void TestPlusReturnSum()
        {
            Money five = Money.Dollar(5);
            Xpression result = five.Plus(five);
            Sum sum = (Sum)result;
            Assert.That(five, Is.EqualTo(sum.Augend));
            Assert.That(five, Is.EqualTo(sum.Addend));
        }

        [Test]
        public void TestReduceSum()
        {
            Xpression sum = new Sum(Money.Dollar(3), Money.Dollar(4));
            Bank bank = new Bank();
            Money result = bank.Reduce(sum, "USD");
            Assert.That(Money.Dollar(7), Is.EqualTo(result));
        }

        [Test]
        public void TestReduceMoney()
        {
            Bank bank = new Bank();
            Money result = bank.Reduce(Money.Dollar(1), "USD");
            Assert.That(Money.Dollar(1), Is.EqualTo(result));
        }

        [Test]
        public void ReduceMoneyDifferentCurrency()
        {
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Money result = bank.Reduce(Money.Franc(2), "USD");
            Assert.That(Money.Dollar(1), Is.EqualTo(result));
        }
        
    }

    class Pair
    {
        private string _from;
        private string _to;

        public Pair(string from, string to)
        {
            _from = from;
            _to = to;
        }
    }

    
}
