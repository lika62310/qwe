namespace OT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrangeTree myot = new OrangeTree();

            myot.Height = 1;
            int age = myot.Age;

            Console.WriteLine(age);

            myot.OneYearPasses();
        }
    }
}
