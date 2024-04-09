using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book
    {
        public string ItemId { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        public Book(string itemId, string title, double price)
        {
            ItemId = itemId;
            Title = title;
            Price = price;
        }
        public Book (string itemId)
        {
            ItemId = itemId;
        }

        public Book (string itemId, string title)
        {
            ItemId = itemId;
            Title = title;
        }


        //("ItemId: 11, Quality: medium, Design: ")

        public string ToString()
        {
            string s =$"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
            return s;
        }

    }
}
