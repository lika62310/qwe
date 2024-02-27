namespace Hold
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //terninger
            int terning1, terning2, terning3, terning4, terning5;
            int tern1, tern2, tern3, tern4, tern5;
            Random rnd = new Random();
            //terning1 = rnd.Next(1, 6);
            //terning2 = rnd.Next(1, 6);
            //terning3 = rnd.Next(1, 6);
            //terning4 = rnd.Next(1, 6);
            //terning5 = rnd.Next(1, 6);

            int score = 0;
            int sum = 0;
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int sum4 = 0;
            int sum5 = 0;
            int sum6 = 0;


            //runder
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Runde " + (i + 1));

                terning1 = rnd.Next(1, 7);
                terning2 = rnd.Next(1, 7);
                terning3 = rnd.Next(1, 7);
                terning4 = rnd.Next(1, 7);
                terning5 = rnd.Next(1, 7);

                tern1 = rnd.Next(1, 7);

                Console.WriteLine("[" + terning1 + ", " + terning2 + ", " + terning3 + ", " + terning4 + ", " + terning5 + "]");

                for (int j = 0; j < 2; j++)
                {
                    tern1 = rnd.Next(1, 7);
                    tern2 = rnd.Next(1, 7);
                    tern3 = rnd.Next(1, 7);
                    tern4 = rnd.Next(1, 7);
                    tern5 = rnd.Next(1, 7);
                    Console.WriteLine("Behold?");
                    string behold = Console.ReadLine();
                    if (behold == "1")
                    {
                        tern1 = terning1;
                    }
                    else
                    {
                        tern1 = rnd.Next(1, 7);
                        break;
                    }

                }

                Console.WriteLine("[" + tern1 + ", " + terning2 + ", " + terning3 + ", " + terning4 + ", " + terning5 + "]");

                // udregn antal

                switch (terning1)
                {
                    case 1:
                        sum1++;
                        break;
                    case 2:
                        sum2++;
                        break;
                    case 3:
                        sum3++;
                        break;
                    case 4:
                        sum4++;
                        break;
                    case 5:
                        sum5++;
                        break;
                    case 6:
                        sum6++;
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
                    case 3:
                        sum3++;
                        break;
                    case 4:
                        sum4++;
                        break;
                    case 5:
                        sum5++;
                        break;
                    case 6:
                        sum6++;
                        break;

                }
                switch (terning3)
                {
                    case 1:
                        sum1++;
                        break;
                    case 2:
                        sum2++;
                        break;
                    case 3:
                        sum3++;
                        break;
                    case 4:
                        sum4++;
                        break;
                    case 5:
                        sum5++;
                        break;
                    case 6:
                        sum6++;
                        break;

                }
                switch (terning4)
                {
                    case 1:
                        sum1++;
                        break;
                    case 2:
                        sum2++;
                        break;
                    case 3:
                        sum3++;
                        break;
                    case 4:
                        sum4++;
                        break;
                    case 5:
                        sum5++;
                        break;
                    case 6:
                        sum6++;
                        break;

                }
                switch (terning5)
                {
                    case 1:
                        sum1++;
                        break;
                    case 2:
                        sum2++;
                        break;
                    case 3:
                        sum3++;
                        break;
                    case 4:
                        sum4++;
                        break;
                    case 5:
                        sum5++;
                        break;
                    case 6:
                        sum6++;
                        break;

                }

                // Lille Straight
                if (sum1 == 1 && sum2 == 1 && sum3 == 1 && sum4 == 1 && sum5 == 1)
                {
                    score = score + 15;
                    Console.WriteLine("Lille Straight");
                }

                // Store Straight
                if (sum2 == 1 && sum3 == 1 && sum4 == 1 && sum5 == 1 && sum6 == 1)
                {
                    score = score + 20;
                    Console.WriteLine("Store Straight");
                }

                // Yatzy
                if (sum1 == 5 || sum2 == 5 || sum3 == 5 || sum4 == 5 || sum5 == 5)
                {
                    score = score + 50;
                    Console.WriteLine("Yatzy");
                }

                //Hus
                if ((sum1 == 2 || sum2 == 2 || sum3 == 2 || sum4 == 2 || sum5 == 2) && (sum1 == 3 || sum2 == 3 || sum3 == 3 || sum4 == 3 || sum5 == 3))
                {
                    score = score + 30;
                    Console.WriteLine("Fuldt hus");
                }


                Console.WriteLine("Antal 1'ere: " + sum1);
                Console.WriteLine("Antal 2'ere : " + sum2);
                Console.WriteLine("Antal 3'ere : " + sum3);
                Console.WriteLine("Antal 4'ere : " + sum4);
                Console.WriteLine("Antal 5'ere : " + sum5);
                Console.WriteLine("Antal 6'ere : " + sum6);
                sum1 = 0;
                sum2 = 0;
                sum3 = 0;
                sum4 = 0;
                sum5 = 0;
                sum6 = 0;
                Console.ReadLine();
            }
            //Console.WriteLine("Score for denne runde er: " + score);
            //Console.WriteLine("Samlet score: " + sum + "\n");
            //Console.WriteLine("Antal ettere: " + sum1);
            //Console.WriteLine("Antal toere : " + sum2);
        }
    }
}
