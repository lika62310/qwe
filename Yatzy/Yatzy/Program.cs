namespace Yatzy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //terninger
            int terning1, terning2, terning3, terning4, terning5;
            Random rnd = new Random();
            //terning1 = rnd.Next(1, 6);
            //terning2 = rnd.Next(1, 6);
            terning3 = rnd.Next(1, 6);
            terning4 = rnd.Next(1, 6);
            terning5 = rnd.Next(1, 6);
            bool keep1 = false;
            bool keep2, keep3, keep4;
            string ask = "";
            int score = 0;
            int sum = 0;
            int sum1 = 0;
            int sum2 = 0;

            

            //runder
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Runde " + (i+1));
                for (int j = 0; j < 3; j++)
                {
                    terning1 = rnd.Next(1, 6);
                    terning2 = rnd.Next(1, 6);
                    Console.WriteLine("Du har slået: " + terning1 + " " + terning2);
                    Console.WriteLine("Skriv nummer på de terninger, du vil beholde:");
                    ask = Console.ReadLine();

                    for (int k = 0; k < ask.Length; k++)
                    {
                        switch (ask[k])
                        {
                            case '1':
                                keep1 = true;
                                break;
                            case '2':
                                keep2 = true;
                                break;
                            
                        }
                        //if (keep = true) break;
                    }
                    // udregen antal

                    switch (terning1)
                    {
                        case 1:
                            sum1++;
                            break;
                        case 2:
                            sum2++;
                            break;
                    }
                    switch (terning2)
                    {
                        case 1:
                            sum1++;
                            break;
                        case 2:
                            sum2++;
                            break;
                    }

                    score = terning1 + terning2;
                    if (keep1 = true) break;

                    //if (ask == "y")
                    //{
                    //    keep = true;
                    //    break;
                    //}
                    score = terning1 + terning2;
                }
                Console.WriteLine("Score for denne runde er: " + score);
                sum = sum + score;
                Console.WriteLine("Samlet score: " + sum + "\n");
                Console.WriteLine("Antal ettere: " + sum1);
                Console.WriteLine("Antal toere : " + sum2);
                //keep1 = false;
            }
        }
    }
}
