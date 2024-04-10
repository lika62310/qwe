using System.Net.Sockets;
using static System.Net.Mime.MediaTypeNames;

namespace GenspilLager
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Game Sequence = new Game("Sequence", "Berlin", "Strategi", 2, 4, "God stand", 3, 150);
            //Console.WriteLine(Sequence.CreateGameString());
            Stock stock = new Stock("lagerliste.txt");
            //Game[] list = Stock.AddGames();

            List<Game> games2 = stock.ReadToList();
            for (int i = 0; i < games2.Count; i++)
            {
                Console.WriteLine(games2[i].Title);
            }


            //stock.WriteGames(list);
            //stock.ReadGames();

            while (true)
            {

            
            Console.WriteLine("Vælg handling");
            Console.WriteLine("1. Søg");
            Console.WriteLine("2. Opret");
            Console.WriteLine("3. Se lagerliste");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                        Console.WriteLine("Indtast søgeterm:");
                        string search = Console.ReadLine();

                        Filter.SearchTitle(stock.ReadToList(), search);
                        
                    break;
                case "2":
                    stock.WriteGames(Stock.AddGames());
                    break;
                case "3":
                        Console.Clear();

                        Console.WriteLine("Vælg visning: ");
                        Console.WriteLine("1. Usorteret");
                        Console.WriteLine("2. Sorteret eter navn");
                        Console.WriteLine("3. Sorteret eter pris");
                        string sortchoice = Console.ReadLine();
                        if (sortchoice == "1")
                            stock.ReadGames();
                        else if (sortchoice == "2")
                        {
                            List<Game> games = Filter.SortListTitle(stock.ReadToList());

                            foreach (Game game in games)
                            {
                                Console.WriteLine(game.CreateGameString());
                            }
                        }
                        else if (sortchoice == "3")
                        {
                            List<Game> games = Filter.SortListPrice(stock.ReadToList());

                            foreach (Game game in games)
                            {
                                Console.WriteLine(game.CreateGameString());
                            }
                        }

                    break;
            }
                Console.WriteLine("Ønsker du at lukke? y/n");
                char cont = Console.ReadLine()[0];
                if (cont == 'y')
                    break;
                Console.Clear();
            }

        }
    }
}
