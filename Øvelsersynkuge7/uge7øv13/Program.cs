namespace uge7øv13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indast startpunktets x-koordinat");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Indast startpunktets y-koordinat");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Indast slutpunktets x-koordinat");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Indast slutpunktets x-koordinat");
            double y2 = double.Parse(Console.ReadLine());
            double result = (y2 - y1) / (x2 - x1);
            Console.WriteLine("Hældningen er " + result);
        }
    }
}
