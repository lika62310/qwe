namespace Yatzy3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 50; i++)
            {
                //terninger
                int terning1, terning2, terning3, terning4, terning5;
                Random rnd = new Random();
                terning1 = rnd.Next(1, 7);
                terning2 = rnd.Next(1, 7);
                terning3 = rnd.Next(1, 6);
                terning4 = rnd.Next(1, 6);
                terning5 = rnd.Next(1, 6);

                int res1 = terning1;
                int res2 = terning2;
                Console.WriteLine(terning1 + " " + terning2);
                //Console.WriteLine((terning1 + terning2));
                //Console.WriteLine((res1 + res2));

            }
            //terninger
            //int terning1, terning2, terning3, terning4, terning5;
            //Random rnd = new Random();
            //terning1 = rnd.Next(1, 6);
            //terning2 = rnd.Next(1, 6);
            //terning3 = rnd.Next(1, 6);
            //terning4 = rnd.Next(1, 6);
            //terning5 = rnd.Next(1, 6);

            //int res1 = terning1;
            //int res2 = terning2;
            //Console.WriteLine(terning1 + " " + terning2);
            //Console.WriteLine((terning1 + terning2));
            //Console.WriteLine((res1 + res2));
        }
    }
}
