using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GenspilLager
{
    internal class Stock
    {
        public string FileName { get; }
        
        public Stock(string fileName)
        {
            FileName = fileName;
        }
        public void WriteGames(List<Game> games)
        {
            StreamWriter sw = new StreamWriter(FileName, true);
            foreach (Game game in games)
            {
                if (game != null)
                    sw.WriteLine(game.CreateGameString());
                else
                    break;
            }
            sw.Close();
        }
        public void ReadGames()
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

        public List<Game> ReadToList()
        {
            List<Game> games = new List<Game>();
            string[] delim = {" (", "),", ",", "-", "styk", "kr.", "reserveret af " };
            char[] delimiterChars = { ' ', ',', '.', ':', '\t', '-'};

            StreamReader sr = new StreamReader(FileName);
            string line = sr.ReadLine();
            int i = 0;
            while (line != null)
            {
                string[] parts = line.Split(delim, System.StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 8)
                    games.Add(new Game(parts[0], parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), parts[5], int.Parse(parts[6]), int.Parse(parts[7])));
                else if (parts.Length == 9)
                    games.Add(new Game(parts[0], parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), parts[5], int.Parse(parts[6]), int.Parse(parts[7]), parts[8]));
                line = sr.ReadLine();
                i++;
            }
            sr.Close();
            return games;
        }


        //Skift til try.Parse


        public static List<Game> AddGames()
        {
            List<Game> games = new List<Game>();
            bool cont = true;
            int i = 0;
            bool reserved = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Skal det reserveres til nogen? j/n");
                string reservation = Console.ReadLine();
                if (reservation == "j")
                    reserved = true;
                else reserved = false;
                Console.Write("Indtast titel:");
                string title = Console.ReadLine();
                Console.Write("Indtast version:");
                string version = Console.ReadLine();
                Console.Write("Indtast kategori:");
                string category = Console.ReadLine();
                Console.Write("Indtast mininum antal spillere:");
                int minPlayers = int.Parse(Console.ReadLine());
                Console.Write("Indtast maksimun antal spillere:");
                int maxPlayer = int.Parse(Console.ReadLine());
                Console.Write("Indtast stand:");
                string condition = Console.ReadLine();
                Console.Write("Indtast antal:");
                int amount = int.Parse(Console.ReadLine());
                Console.Write("Indtast pris:");
                int price = int.Parse(Console.ReadLine());
                if (reserved == true)
                {
                    Console.WriteLine("Hvem er spillet reserveret til?");

                    string reservedBy = Console.ReadLine();
                    games.Add(new Game(title, version, category, minPlayers, maxPlayer, condition, amount, price, reservedBy));
                }
                else  games.Add(new Game(title, version, category, minPlayers, maxPlayer, condition, amount, price));
                Console.Clear();
                Console.Write($"Spil '{title}' oprettet");
                Console.ReadLine();
                Console.Clear();
                Console.Write("Fortsæt? y/n");
                char conts = Console.ReadLine()[0];
                if (conts == 'n')
                    cont = false;

            } while (cont);
            return games;
        }

    }
}
