using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenspilLager
{
    public class Game
    {
        public string Title { get; set; }
        public string Version { get; set; }
        public string Category { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public string Condition { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
        public string ReservedBy { get; set; }

        public Game(string title, string version, string category, int minplayers, int maxplayers, string condition, int amount, int price)
        {
            Title = title;
            Version = version;
            Category = category;
            MinPlayers = minplayers;
            MaxPlayers = maxplayers;
            Condition = condition;
            Amount = amount;
            Price = price;
            ReservedBy = " ";
        }
        public Game(string title, string version, string category, int minplayers, int maxplayers, string condition, int amount, int price, string reservedBy)
        {
            Title = title;
            Version = version;
            Category = category;
            MinPlayers = minplayers;
            MaxPlayers = maxplayers;
            Condition = condition;
            Amount = amount;
            Price = price;
            ReservedBy = reservedBy;
        }

        public string CreateGameString()
        {
            string str = " ";
            if (ReservedBy == " ")
            str = $"{Title} ({Version}), {Category}, {MinPlayers}-{MaxPlayers}, {Condition}, {Amount} styk, {Price} kr.";
            else
                str = $"{Title} ({Version}), {Category}, {MinPlayers}-{MaxPlayers}, {Condition}, {Amount} styk, {Price} kr.,  Reserveret af {ReservedBy}";

            return str;
        }

    }
}
