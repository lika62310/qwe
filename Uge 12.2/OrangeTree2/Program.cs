namespace OrangeTreeSim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrangeTree myot = new OrangeTree();

            myot.SetAge(1);
            int age = myot.GetAge();

            Console.WriteLine(age);

            myot.OneYearPasses();
        }
    }
}
