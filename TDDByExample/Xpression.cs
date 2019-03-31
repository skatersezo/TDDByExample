using System;
using System.Collections.Generic;
using System.Text;

namespace TDDByExample
{
    public interface Xpression
    {
        Money Reduce(Bank bank, String to);
    }
}
