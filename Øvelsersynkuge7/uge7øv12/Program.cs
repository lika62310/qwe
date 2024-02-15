namespace uge7øv12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indast startpunktets x-koordinat");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Indast startpunktets y-koordinat");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Indast slutpunktets x-koordinat");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Indast slutpunktets x-koordinat");
            int y2 = int.Parse(Console.ReadLine());
            int result = (y2 - y1) / (x2 - x1);
            Console.WriteLine("Hældningen er " + result);

        }
    }
}
