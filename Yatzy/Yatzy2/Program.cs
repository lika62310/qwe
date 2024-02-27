namespace Yatzy2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //terninger
            int terning1, terning2, terning3, terning4, terning5;
            int res1, res2;
            Random rnd = new Random();
            //terning1 = rnd.Next(1, 6);
            //terning2 = rnd.Next(1, 6);
            terning3 = rnd.Next(1, 6);
            terning4 = rnd.Next(1, 6);
            terning5 = rnd.Next(1, 6);
            bool keep = false;
            string ask = "";
            int score = 0;
            int sum = 0;



            //runder
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Runde " + (i + 1));
                for (int j = 0; j < 3; j++)
                {
                    terning1 = rnd.Next(1, 6);
                    terning2 = rnd.Next(1, 6);
                    Console.WriteLine("Du har slået: " + terning1 + " " + terning2);
                    Console.WriteLine("Skriv nummer på de terninger, du vil beholde:");
                    ask = Console.ReadLine();

                    res1 = terning1;
                    res2 = terning2;

                    for (int k = 0; k < ask.Length; k++)
                    {
                        switch (ask[k])
                        {
                            case '1':
                                keep = true;
                                res1 = terning1;
                                break;
                            case '2':
                                keep = true;
                                break;
                        }
                        //if (keep = true) break;
                    }

                    if (keep = true) break;
                    //if (ask == "y")
                    //{
                    //    keep = true;
                    //    break;
                    //}
                    score = res1 + res2;
                }
                Console.WriteLine("Score for denne runde er: " + score);
                sum = sum + score;
                Console.WriteLine("Samlet score :" + sum);
            }
        }
    }
}
