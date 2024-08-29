using System.Net.NetworkInformation;

namespace ExtensionsEvents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string word = "hejsa";
            string upword = word.Capitalize();
            Console.WriteLine(upword);
            Random rnd = new Random();
            double r = rnd.NextDouble(10);
            Console.WriteLine(r);

            string[] words = { "Nord", "Syd", "Øst", "Vest" };


            for (int i = 0; i < 10; i++)
            {
                bool slag = rnd.CoinFlip(0.75);
                Console.WriteLine(slag);
                Console.WriteLine(rnd.NextString(words));
                //Console.WriteLine(rnd.NextDouble(10));
            }




        }

    }
}
