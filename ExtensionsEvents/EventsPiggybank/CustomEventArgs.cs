using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsPiggybank
{
    public class CustomEventArgs : EventArgs
    {
        public double Amount { get; }
        public CustomEventArgs(double amount)
        {
            Amount = amount;
        }
    }
}
