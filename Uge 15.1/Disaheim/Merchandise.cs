using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
     public abstract class Merchandise : IValuable
    {
        public string ItemId { get; set; }

        public Merchandise()
        {

        }

        public Merchandise(string itemId)
        {
            ItemId = itemId;
        }

        public abstract string ToString();

        public abstract double GetValue();
    }
}
