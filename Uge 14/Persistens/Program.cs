namespace Persistens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person merson = new Person("Anders Andersen", new DateTime(1975, 8, 24), 175.9, true, 3);

            DataHandler handler = new DataHandler("Data.txt");
            handler.SavePerson(merson);

            Console.Write("Writing Person: ");
            Console.WriteLine(merson.MakeTitle());

            Console.ReadLine();

            string[] words = { "one", "two" };

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
