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
        Controller controller = new Controller();
        public string FileName { get; }
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
            StreamWriter sw = new StreamWriter(FileName);
            for (int i = 0; i < controller.Connectors.Count; i++)
            {
                sw.WriteLine(controller.Connectors[i].Name);
            }
            sw.Close();
        }

        public void ReadOrders()
        { }
    }
}
