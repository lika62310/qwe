using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsPiggybank
{
    public class Customer
    {

        public void Subscribe(Piggybank piggybank)
        {
            piggybank.Message += ShowMessage;
        }


        public void ShowMessage(object sender, CustomEventArgs e)
        {
            if (e.Amount > 1197) Console.WriteLine("Tillykke – du har nu penge nok til tre sæsonkort til OBs kampe");

            else if (e.Amount > 799) Console.WriteLine("Tillykke – du har nu penge nok til et premium sæsonkort til OBs kampe");

            else if (e.Amount > 399) Console.WriteLine("Tillykke – du har nu penge nok til et sæsonkort til OBs kampe");

        }
    }
}
