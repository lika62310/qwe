namespace Øvelsersynkuge7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast højde: ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Intast bredde: ");
            int width = int.Parse(Console.ReadLine());
            int result = (height * width);
            Console.WriteLine("Resultatet er " + result);

        }
    }
}
