namespace uge7øv22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv noget: ");
            string str = Console.ReadLine();
            string str2 = str.Substring(2,4);
            Console.WriteLine(str2);
        }
    }
}
