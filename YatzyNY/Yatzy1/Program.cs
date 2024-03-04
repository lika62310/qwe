namespace Yatzy1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //terninger
            int terning1, terning2, terning3, terning4, terning5;
            Random rnd = new Random();


            // Scoreboard
            int ones = 0;
            int twos = 0;
            int threes = 0;
            int fours = 0;
            int fives = 0;
            int sixes = 0;
            int onepair = 0;
            int twopairs = 0;
            int threekind = 0;
            int fourkind = 0;
            int smstraight = 0;
            int lrstraight = 0;
            int chance = 0;
            int yahtzee = 0;
            int fullhouse = 0;

            int score = 0;
            int lowertotal = 0;
            int total = 0;
            int sum = 0;
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int sum4 = 0;
            int sum5 = 0;
            int sum6 = 0;

            Console.Write("(1) 1'ere: " + ones + "\n(2) 2'ere: " + twos + "\n(3) 3'ere: " + threes + "\n(4) 4'ere " + fours + "\n(5) 5'ere: " + fives + "\n(6) 6'ere: " + sixes + "\n(7) Et par: " + onepair + "\n(8) To par: " + twopairs + "\n(9) Tre ens: " + threekind + "\n(10) Fire ens: " + fourkind + "\n(11) Lille straight: " + smstraight + "\n(12) Store straight: " + lrstraight + "\n(13) Chancen: " + chance + "\n(14) Yatzy: " + yahtzee + "\n(15) Fuldt hus: " + fullhouse + "\n");

            //runder
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Runde " + (i + 1));

                terning1 = rnd.Next(1, 7);
                terning2 = rnd.Next(1, 7);
                terning3 = rnd.Next(1, 7);
                terning4 = rnd.Next(1, 7);
                terning5 = rnd.Next(1, 7);


                Console.WriteLine("[" + terning1 + ", " + terning2 + ", " + terning3 + ", " + terning4 + ", " + terning5 + "]");

                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Vælg de terninger, du vil slå igen:");
                    string behold = Console.ReadLine();
                    if (behold.Length < 1) break;
                    for (int k = 0; k < behold.Length; k++)
                    {
                        switch (behold[k])
                        {
                            case '1':
                                terning1 = rnd.Next(1, 7);
                                break;
                            case '2':
                                terning2 = rnd.Next(1, 7);
                                break;
                            case '3':
                                terning3 = rnd.Next(1, 7);
                                break;
                            case '4':
                                terning4 = rnd.Next(1, 7);
                                break;
                            case '5':
                                terning5 = rnd.Next(1, 7);
                                break;
                        }
                    }
                    Console.WriteLine("[" + terning1 + ", " + terning2 + ", " + terning3 + ", " + terning4 + ", " + terning5 + "]");
                }

                //Console.WriteLine("[" + terning1 + ", " + terning2 + ", " + terning3 + ", " + terning4 + ", " + terning5 + "]");

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

                //Find mulige kombinationer

                // Yatzy
                if (sum1 == 5 || sum2 == 5 || sum3 == 5 || sum4 == 5 || sum5 == 5)
                {
                    Console.WriteLine("Ýatzy!");
                }

                //Fuldt hus
                if ((sum1 == 2 || sum2 == 2 || sum3 == 2 || sum4 == 2 || sum5 == 2 || sum6 == 2) && (sum1 == 3 || sum2 == 3 || sum3 == 3 || sum4 == 3 || sum5 == 3 || sum6 == 3))
                {
                    Console.WriteLine("Fuldt hus");
                }

                // Store Straight
                if (sum2 == 1 && sum3 == 1 && sum4 == 1 && sum5 == 1 && sum6 == 1)
                {
                    Console.WriteLine("Store Straight");
                }

                // Lille Straight
                if (sum1 == 1 && sum2 == 1 && sum3 == 1 && sum4 == 1 && sum5 == 1)
                {
                    Console.WriteLine("Lille Straight");
                }

                //Fire ens
                if (sum1 >= 4 || sum2 >= 4 || sum3 >= 4 || sum4 >= 4 || sum5 >= 4 || sum6 >= 4)
                {
                    Console.WriteLine("Fire ens");
                }

                //To par
                if ((sum1 == 2 || sum2 == 2 || sum3 == 2 || sum4 == 2 || sum5 == 2 || sum6 == 2) && (sum1 == 2 || sum2 == 2 || sum3 == 2 || sum4 == 2 || sum5 == 2 || sum6 == 2))
                {
                    Console.WriteLine("To Par");

                }

                //Tre ens
                if (sum1 == 3 || sum2 == 3 || sum3 == 3 || sum4 == 3 || sum5 == 3 || sum6 == 3)
                {
                    Console.WriteLine("Tre ens");
                }

                //Et par
                if (sum1 == 2 || sum2 == 2 || sum3 == 2 || sum4 == 2 || sum5 == 2 || sum6 == 2)
                {
                    Console.WriteLine("Et par");
                }




                Console.WriteLine("Antal 1'ere: " + sum1);
                Console.WriteLine("Antal 2'ere : " + sum2);
                Console.WriteLine("Antal 3'ere : " + sum3);
                Console.WriteLine("Antal 4'ere : " + sum4);
                Console.WriteLine("Antal 5'ere : " + sum5);
                Console.WriteLine("Antal 6'ere : " + sum6);
                Console.WriteLine("Vælg kombination: ");
                int kombi = int.Parse(Console.ReadLine());
                switch (kombi)
                {
                    case 1:
                        score = score + (1 * sum1);
                        ones++;
                        lowertotal = lowertotal + score;
                        break;
                    case 2:
                        score = score + (2 * sum2);
                        twos++;
                        lowertotal = lowertotal + score;
                        break;
                    case 3:
                        score = score + (3 * sum3);
                        threes++;
                        lowertotal = lowertotal + score;
                        break;
                    case 4:
                        score = score + (4 * sum4);
                        fours++;
                        lowertotal = lowertotal + score;
                        break;
                    case 5:
                        score = score + (5 * sum5);
                        fives++;
                        lowertotal = lowertotal + score;
                        break;
                    case 6:
                        score = score + (6 * sum6);
                        sixes++;
                        lowertotal = lowertotal + score;
                        break;
                    case 7:
                        onepair++;
                        if (sum6 >= 2)
                        {
                            score = score + (6 * 2);
                        }
                        else if (sum5 >= 2)
                        {
                            score = score + (5 * 2);
                        }
                        else if (sum4 >= 2)
                        {
                            score = score + (4 * 2);
                        }
                        else if (sum3 >= 2)
                        {
                            score = score + (3 * 2);
                        }
                        else if (sum2 >= 2)
                        {
                            score = score + (2 * 2);
                        }
                        else if (sum1 >= 2)
                        {
                            score = score + (1 * 2);
                        }
                        break;
                    case 8:
                        twopairs++;
                        score = score + (sum2 * 2 + sum3 * 2);
                        break;
                    case 9:
                        threekind++;
                        if (sum6 >= 3)
                        {
                            score = score + (6 * 3);
                        }
                        else if (sum5 >= 3)
                        {
                            score = score + (5 * 3);
                        }
                        else if (sum4 >= 3)
                        {
                            score = score + (4 * 3);
                        }
                        else if (sum3 >= 3)
                        {
                            score = score + (3 * 3);
                        }
                        else if (sum2 >= 3)
                        {
                            score = score + (2 * 3);
                        }
                        else if (sum1 >= 3)
                        {
                            score = score + (1 * 3);
                        }
                        break;
                    case 10:
                        fourkind++;
                        if (sum6 >= 4)
                        {
                            score = score + (6 * 4);
                        }
                        if (sum5 >= 4)
                        {
                            score = score + (5 * 4);
                        }
                        if (sum4 >= 4)
                        {
                            score = score + (4 * 4);
                        }
                        if (sum3 >= 4)
                        {
                            score = score + (3 * 4);
                        }
                        if (sum2 >= 4)
                        {
                            score = score + (2 * 4);
                        }
                        if (sum1 >= 4)
                        {
                            score = score + (1 * 4);
                        }
                        break;
                    case 11:
                        score = score + 15;
                        smstraight++;
                        break;
                    case 12:
                        score = score + 20;
                        lrstraight++;
                        break;
                    case 13:
                        score = score + terning1 + terning2 + terning3 + terning4 + terning5;
                        chance++;
                        break;
                    case 14:
                        yahtzee++;
                        Console.WriteLine("Yatzy");
                        break;
                    case 15:
                        score = score + 35;
                        fullhouse++;
                        break;
                }
                sum1 = 0;
                sum2 = 0;
                sum3 = 0;
                sum4 = 0;
                sum5 = 0;
                sum6 = 0;
                total = total + score;

                //printScoreboard();
                Console.WriteLine();
                Console.Write("(1) 1'ere: " + ones + "\n(2) 2'ere: " + twos + "\n(3) 3'ere: " + threes + "\n(4) 4'ere " + fours + "\n(5) 5'ere: " + fives + "\n(6) 6'ere: " + sixes + "\n(7) Et par: " + onepair + "\n(8) To par: " + twopairs + "\n(9) Tre ens: " + threekind + "\n(10) Fire ens: " + fourkind + "\n(11) Lille straight: " + smstraight + "\n(12) Store straight: " + lrstraight + "\n(13) Chancen: " + chance + "\n(14) Yatzy: " + yahtzee + "\n(15) Fuldt hus: " + fullhouse + "\n");
                Console.WriteLine("Score for runden: " + score);
                Console.WriteLine("Samlet score: " + total);
                Console.ReadLine();
                score = 0;
            }

            //Console.WriteLine("Score for denne runde er: " + score);
            //Console.WriteLine("Samlet score: " + sum + "\n");
            //Console.WriteLine("Antal ettere: " + sum1);
            //Console.WriteLine("Antal toere : " + sum2);
            //Console.WriteLine("Score for runden: " + score);
            //Console.WriteLine("Samlet score: " + total);

        }
    }
}
