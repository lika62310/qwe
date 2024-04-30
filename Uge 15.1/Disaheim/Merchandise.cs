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


        public double GetValue(Merchandise merchandise)
        {
            double price = 0;
            if (merchandise is Book)
            {
                Book book = (Book)merchandise;
                price = book.Price;
            }
            else if (merchandise is Amulet)
            {
                Amulet amulet = (Amulet)merchandise;
                switch (amulet.Quality)
                {
                    case Level.low:
                        price = amulet.LowQualityValue;
                        break;
                    case Level.medium:
                        price = amulet.MediumQualityValue;
                        break;
                    case Level.high:
                        price = amulet.HighQualityValue;
                        break;
                }
            }
            return price;
        }
    }
}
