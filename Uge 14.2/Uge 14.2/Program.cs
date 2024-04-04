namespace Uge_14._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataHandler handler = new DataHandler("students2.txt");
            DataHandler handler2 = new DataHandler("students_sorted.txt");

            Student[] students = handler.LoadStudents();

            //Menu (Opgave 4.4)
            Console.WriteLine("Sortér lister efter: \n1. Navn\n2. Gruppenummer");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Vælg sortering: \n1. BubbleSort\n2. QuickSort");
                    int choice2 = int.Parse(Console.ReadLine());
                    switch(choice2)
                    {
                        case 1:
                            Console.Clear();
                            try
                            {
                                handler2.SaveStudents(SortingAlgorithms.BubbleSort(students, 84));
                                Console.WriteLine("Succes!");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Fejl!" + ex.Message);
                            }
                            break;
                        case 2:
                            Console.Clear();
                            try
                            {
                                handler2.SaveStudents(SortingAlgorithms.QuickSort(students, 0, 83));
                                Console.WriteLine("Succes!");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Fejl!" + ex.Message);
                            }
                            break;
                    }
                    break;
                case 2:
                    Console.Clear();
                    try
                    {
                        handler2.SaveStudents(SortingAlgorithms.SelectionSort(students, 84));
                        Console.WriteLine("Succes!");
                    }
                    catch (Exception ex) 
                    {
                        Console.WriteLine("Fejl!" + ex.Message);
                    }
                    break;
            }

            //Student[] selecstudents = SortingAlgorithms.SelectionSort(students, 84);

            //SortingAlgorithms.SelectionSort(students, 84);

            //for (int i = 0; i < selecstudents.Length; i++)
            //{
            //    if (selecstudents[i] == null)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(selecstudents[i].FullName + ", " + selecstudents[i].GroupNumber);
            //}

            //Student[] bubblestudents = SortingAlgorithms.SelectionSort(students, 84);

            //SortingAlgorithms.BubbleSort(students, 84);

            //for (int i = 0; i < bubblestudents.Length; i++)
            //{
            //    if (bubblestudents[i] == null)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(bubblestudents[i].FullName + ", " + bubblestudents[i].GroupNumber);
            //}

            //Student[] quickstudents = SortingAlgorithms.SelectionSort(students, 84);

            //SortingAlgorithms.QuickSort(quickstudents, 0, 83);

            //for (int i = 0; i < quickstudents.Length; i++)
            //{
            //    if (quickstudents[i] == null)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(quickstudents[i].FullName + ", " + quickstudents[i].GroupNumber);
            //}
        }
    }
}
