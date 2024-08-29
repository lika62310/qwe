using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsEvents
{
    public static class Extensions
    {
        public static string Capitalize(this string str)
        {
            if(string.IsNullOrEmpty(str)) return str;
            return str.Substring(0, 1).ToUpper() + str.Substring(1, str.Length - 1);
        }

        public static double NextDouble(this Random random, double maxValue)
        {
            return random.NextDouble() * maxValue;
        }

        public static bool CoinFlip(this Random rnd, double chance = 0.5)
        {

            if (rnd.NextDouble() < chance)  return true;
            
            else return false;
            
        }

        public static string NextString(this Random rnd, string[] array)
        {
            return array[rnd.Next(array.Length)];
        }

    }
}
