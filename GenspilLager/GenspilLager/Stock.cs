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
        public void WriteGames(Game[] games)
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

        public Game[] ReadToArray()
        {
            Game[] games = new Game[15];
            string[] delim = {" ", "(", ")", ",", "-", "styk", "kr."};
            StreamReader sr = new StreamReader(FileName);
            string line = sr.ReadLine();
            int i = 0;
            while (line != null)
            {
                string[] parts = line.Split(delim, System.StringSplitOptions.RemoveEmptyEntries);
                games[i] = new Game(parts[0], parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), parts[5], int.Parse(parts[6]), int.Parse(parts[7]));
                line = sr.ReadLine();
                i++;
            }
            sr.Close();
            return games;

            //Student[] students = new Student[100];
            //string line;
            //try
            //{
            //    StreamReader sr = new StreamReader(DataFileName);
            //    line = sr.ReadLine();
            //    int i = 0;

            //    while (line != null)
            //    {
            //        string[] parts = line.Split(',');
            //        string fullName = parts[0];
            //        int groupNumber = int.Parse(parts[1]);
            //        students[i] = new Student(fullName, groupNumber);
            //        line = sr.ReadLine();
            //        i++;
            //    }
            //    sr.Close();
            

        }


        //Skab game array
        //Skift til try.Parse
        //Array størrelse
        public static Game[] AddGames()
        {
            Console.WriteLine("Hvor mange spil vil du tilføje?");
            int n = int.Parse(Console.ReadLine());
            Game[] games = new Game[n];
            bool cont = true;
            int i = 0;
            do
            {
                Console.Clear();
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
                //if (condition = "Reserveret")
                //{
                //      Console.WriteLine("Hvem er spillet reserveret til?)
                //      string reservedBy = Console.ReadLine();
                //}
                Console.Clear();
                games[i] = new Game(title, version, category, minPlayers, maxPlayer, condition, amount, price);
                Console.Write($"Spil '{title}' oprettet");
                Console.ReadLine();
                Console.Clear();
                Console.Write("Fortsæt? y/n");
                char conts = Console.ReadLine()[0];
                if (conts == 'n')
                    cont = false;
                i++;

            } while (cont);
            return games;
        }
    }
}
