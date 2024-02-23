namespace _1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv noget:");
            string str = Console.ReadLine();
            int length = str.Length;
            int index = 0;

            do
            {
                char ch = str[index];
                Console.WriteLine(index + ": " + ch);
                index++;
            } while (length > index);
        }
    }
}
