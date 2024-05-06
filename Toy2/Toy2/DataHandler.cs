using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy2
{
    public class DataHandler
    {
        public string FileName { get; set; }
        public DataHandler(string fileName) 
        { 
            FileName = fileName;
        }

        public void CreateOrder(Order order)
        { 
        }

        public void CloseOrder(Order order)
        { 
        }

        public void PrintOrders()
        {

        }

        public void ReadOrders()
        { }
    }
}
