using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Disaheim
{
    public class AmuletRepository
    {
        Utility utility = new Utility();
        public List<Amulet> amulets = new List<Amulet>();

        public void AddAmulet(Amulet amulet)
        {
            amulets.Add(amulet);
        }
        public Amulet GetAmulet(string itemId)
        {
            Amulet amulet1 = null;
            foreach (Amulet amulet in amulets)
            {
                if (amulet.ItemId == itemId)
                    amulet1 = amulet;
            }
            return amulet1;

        }

        public double GetTotalValue()
        {
            double value = 0;
            foreach (Amulet amulet in amulets)
            {
                value += utility.GetValueOfAmulet(amulet);
            }
            return value;
        }

    }
}
