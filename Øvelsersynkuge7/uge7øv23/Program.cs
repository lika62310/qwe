namespace uge7øv23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv noget: ");
            string str = Console.ReadLine();
            Console.WriteLine("Skriv hvad du vil finde: ");
            string find = Console.ReadLine();
            int pos = str.IndexOf(find);

            if (pos > 0)
            {
                Console.WriteLine(find + " Fundet ved position " + pos);
            }
            else
                Console.WriteLine("Fejl! Karakter ikke fundet.");

        }
    }
}
