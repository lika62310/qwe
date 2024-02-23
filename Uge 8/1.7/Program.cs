namespace _1._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Første tal: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Andet tal: ");
            int b = int.Parse(Console.ReadLine());
            int intdiv = a / b;
            int remainder = a % b;

            Console.WriteLine("Heltalskvotient: {0}, rest: {1}", intdiv, remainder);

        }
    }
}
