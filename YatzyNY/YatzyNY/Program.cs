﻿
namespace YatzyNY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //terninger
            int terning1, terning2, terning3, terning4, terning5;
            int tern1, tern2, tern3, tern4, tern5;
            Random rnd = new Random();

            int score = 0;
            int total = 0;
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


                // Yatzy
                if (sum1 == 5 || sum2 == 5 || sum3 == 5 || sum4 == 5 || sum5 == 5)
                {
                    score = score + 50;
                    Console.WriteLine("Yatzy");
                }

                //Fuldt hus
                else if ((sum1 == 2 || sum2 == 2 || sum3 == 2 || sum4 == 2 || sum5 == 2 || sum6 == 2) && (sum1 == 3 || sum2 == 3 || sum3 == 3 || sum4 == 3 || sum5 == 3 || sum6 ==3))
                {
                    score = score + 35;
                    Console.WriteLine("Fuldt hus");
                }

                // Store Straight
                else if (sum2 == 1 && sum3 == 1 && sum4 == 1 && sum5 == 1 && sum6 == 1)
                {
                    score = score + 20;
                    Console.WriteLine("Store Straight");
                }

                // Lille Straight
                else if (sum1 == 1 && sum2 == 1 && sum3 == 1 && sum4 == 1 && sum5 == 1)
                {
                    score = score + 15;
                    Console.WriteLine("Lille Straight");
                }

                //ÆNDR POINT 

                //Fire ens
                else if (sum1 == 4 || sum2 == 4 || sum3 == 4 || sum4 == 4 || sum5 == 4 || sum6 == 4)
                {
                    Console.WriteLine("Fire ens");
                    score = score + 4;
                }

                //To par
                else if ((sum1 == 2 || sum2 == 2 || sum3 == 2 || sum4 == 2 || sum5 == 2 || sum6 == 2) && (sum1 == 2 || sum2 == 2 || sum3 == 2 || sum4 == 2 || sum5 == 2 || sum6 == 2))
                {
                    Console.WriteLine("To Par");
                    score = score + 3;
                }

                //Tre ens
                else if (sum1 == 3 || sum2 == 3 || sum3 == 3 || sum4 == 3 || sum5 == 3 || sum6 == 3)
                {
                    Console.WriteLine("Tre ens");
                    score = score + 5;
                }

                //Et par
                else if (sum1 == 2 || sum2 == 2 || sum3 == 2 || sum4 == 2 || sum5 == 2 || sum6 == 2)
                {
                    Console.WriteLine("Et par");
                    score = score + 2;
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
                total = total + score;
                Console.ReadLine();
                Console.WriteLine("Score for runden: " + score);
                Console.WriteLine("Samlet score: " + total);
                score = 0;
            }
            //Console.WriteLine("Score for denne runde er: " + score);
            //Console.WriteLine("Samlet score: " + sum + "\n");
            //Console.WriteLine("Antal ettere: " + sum1);
            //Console.WriteLine("Antal toere : " + sum2);
        }
    }
}
