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
        public string FileName { get; }
        public DataHandler(string fileName) 
        { 
            FileName = fileName;
        }

        public void PrintOrders(List<StockItem> items)
        {
            StreamWriter sw = new StreamWriter(FileName);
            sw.WriteLine("Id, Type, Kostpris, Antal");
            for (int i = 0; i < items.Count; i++)
            {
                sw.WriteLine(items[i].ToString());
            }
            sw.Close();

        }

        public void ReadOrders()
        {
            StreamReader sr = new StreamReader(FileName);
            string line = sr.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            sr.Close();
        }
    }
}
