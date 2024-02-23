namespace _1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Skriv noget:");
            string str = Console.ReadLine();
            int length = str.Length;
            int index = 0;

            while (length > index)
            {
                char ch = str[index];
                Console.WriteLine(index + ": " + ch);
                index++;
            }
        }
    }
}
