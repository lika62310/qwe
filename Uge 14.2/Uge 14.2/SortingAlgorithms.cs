using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge_14._2
{
    public class SortingAlgorithms
    {
        //Opgave 4.1
        public static Student[] SelectionSort(Student[] students, int n)
        {

            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (students[j].GroupNumber < students[min].GroupNumber)
                        min = j;
                }
                if (min != i)
                {
                    Student temp = students[min];
                    students[min] = students[i];
                    students[i] = temp;
                }

            }
            return students;
        }


        //Opgave 4.2
        public static Student[] BubbleSort(Student[] students, int n)
        {
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (students[j].FullName[0] > students[j + 1].FullName[0])
                    {
                        Student temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (swapped == false)
                    break;
            }
            return students;
        }

        //Opgave 4.3
        public static int Partition(Student[] students, int low, int high)
        {
            int pivot = students[high].FullName[0];
            int i = (low - 1);

            for (int j = low; j < high; j++)
            { 
                if (students[j].FullName[0] < pivot)
                {
                    i++;
                    Student temp1 = students[i];
                    students[i] = students[j];
                    students[j] = temp1;
                }
            }
            Student temp = students[i+1];
            students[i+1] = students[high];
            students[high] = temp;
            return (i + 1);
        }

        public static Student[] QuickSort(Student[] students, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(students, low, high);
                QuickSort(students, low, pi - 1);
                QuickSort(students, pi + 1, high);
            }
            return students;
        }


    }
}
