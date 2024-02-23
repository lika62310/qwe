namespace _1._10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str = "g65mxxz2htdyd7kgkk9";
            Console.WriteLine(str);
            int length = str.Length;
            int index = 0;

            while (length > index)
            {
                char ch = str[index];
                if (ch >= '0' && ch <= '9')
                {
                    Console.WriteLine(index + ": " + ch);
                }
                index++;
            }
        }
    }
}
