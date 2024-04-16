using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class MerchandiseRepository
    {
        Utility utility = new Utility();
        private List<Merchandise> merchandises = new List<Merchandise>();

        public void AddMerchandise(Merchandise merchandise)
        {
            merchandises.Add(merchandise);
        }
        public Merchandise GetMerchandise(string itemId)
        {
            Merchandise merchandise1 = null;
            foreach (Merchandise merchandise in merchandises)
            {
                if (merchandise.ItemId == itemId)
                    merchandise1 = merchandise;
            }
            return merchandise1;

        }

        public double GetTotalValue()
        {
            double value = 0;
            foreach (Merchandise merchandise in merchandises)
            {
                value += utility.GetValueOfMerchandise(merchandise);
            }
            return value;
        }
    }
}

