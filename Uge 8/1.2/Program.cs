namespace _1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Menu: ");
            Console.Write("1. Gør dit \n2. Gør dat\n3.Gør noget \n4. Få svaret på...");
            Console.WriteLine("\n(Tryk menupunkt 1, 2, 3, eller 4)");
            int choice;
            string message;
            message = "";
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    message = "Gør dit";
                    break;
                case 2:
                    message = "Gør dat";
                    break;
                case 3:
                    message = "Gør noget";
                    break;
                case 4:
                    message = "42";
                    break;
            }

            Console.WriteLine("Punkt {0} er valgt: {1}", choice, message);

        }
    }
}
