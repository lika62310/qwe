using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class ValuableRepository
    {
        private List<IValuable> valuables = new List<IValuable>();

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }
        public IValuable GetValuable(string id)
        {
            IValuable valuable1 = null;
            foreach (IValuable valuable in valuables)
            {
                if (valuable.ItemId == itemId)
                    book1 = book;
            }
            return book1;

        }

        public double GetTotalValue()
        {
            double value = 0;
            foreach (Book book in books)
            {
                value += utility.GetValueOfBook(book);
            }
            return value;

        }
    }
}
