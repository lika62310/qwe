namespace _1._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "g65mx+z2htd-d7kgkk9";
            Console.WriteLine(str);
            int length = str.Length;
            int index = 0;

            while (length > index)
            {
                char ch = str[index];
                if (ch >= '0' && ch <= '9')
                {
                    Console.WriteLine(index + ": " + ch + "(ciffer)");
                }
                else if (ch == '-' || ch == '+')
                {
                    Console.WriteLine(index + ": " + ch + "(operator)");
                }
                else
                {
                    Console.WriteLine(index + ": " + ch + "(ukendt)");
                }
                index++;
            }

        }
    }
}
