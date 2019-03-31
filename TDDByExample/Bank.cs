using System;
using System.Collections.Generic;
using System.Text;

namespace TDDByExample
{
    public class Bank
    {
        public Money Reduce(Xpression source, string to)
        {
            return source.Reduce(this, to);
        }

        public int Rate(string from, string to)
        {
            return (from.Equals("CHF") && to.Equals("USD"))
                ? 2
                : 1;
        }

        public void AddRate(string chf, string usd, int i)
        {
            throw new NotImplementedException();
        }
    }
}
