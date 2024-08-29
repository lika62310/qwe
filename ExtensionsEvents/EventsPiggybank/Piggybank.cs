using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace EventsPiggybank
{
    public class Piggybank
    {
        public event EventHandler<CustomEventArgs> Message;

        public double Amount = 0;

        public void InsertAmount(double amount)
        {
            this.Amount += amount;
            OnMessage();
        }

        protected virtual void OnMessage()
        {
            Message?.Invoke(this, new CustomEventArgs(Amount));
        }


    }
}
