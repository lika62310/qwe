using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenspilLager
{
    public static class Filter
    {
        //Div. sortering

        public static List<Game> SortListTitle(List<Game> games)
        {
            int n = games.Count;
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (games[j].Title[0] < games[min].Title[0])
                        min = j;
                }
                if (min != i)
                {
                    Game temp = games[min];
                    games[min] = games[i];
                    games[i] = temp;
                }
            }

            return games;
        }

        public static List<Game> SortListPrice(List<Game> games)
        {
            int n = games.Count;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (games[j].Price > games[j + 1].Price)
                    {
                        Game temp = games[j];
                        games[j] = games[j + 1];
                        games[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (swapped == false)
                    break;
            }

            return games;
        }

        public static int Partition(List<Game> games, int low, int high)
        {
            int pivot = games[high].Price;
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (games[j].Price < pivot)
                {
                    i++;
                    Game temp1 = games[i];
                    games[i] = games[j];
                    games[j] = temp1;
                }
            }
            Game temp = games[i + 1];
            games[i + 1] = games[high];
            games[high] = temp;
            return (i + 1);
        }

        //public static List<Game> SortListPrice(List<Game> games, int low, int high)
        //{
        //    if (low < high)
        //    {
        //        int pi = Partition(games, low, high);
        //        SortListPrice(games, low, pi - 1);
        //        SortListPrice(games, pi + 1, high);
        //    }
        //    return games;
        //}



        //Søgning

        public static void SearchTitle(List<Game> games, string title)
        {
            foreach (Game game in games)
            {
                if (game.Title.Contains(title)|| game.Version.Contains(title) || game.Category.Contains(title))
                    Console.WriteLine(game.CreateGameString());
            }
        }

    }
}
 