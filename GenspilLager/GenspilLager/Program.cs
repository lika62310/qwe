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

            //Game[] games2 = stock.ReadToArray();
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(games2[i]);
            //}


            //stock.WriteGames(list);
            //stock.ReadGames();

            // ggggggggggg
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
                        //implementér søgning
                    break;
                case "2":
                    stock.WriteGames(Stock.AddGames());
                    break;
                case "3":
                    Console.Clear();
                    stock.ReadGames();
                    //sortér
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
