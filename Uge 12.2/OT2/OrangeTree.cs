using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OT2
{
    public class OrangeTree
    {
        private int age;
        private int height;
        private bool treeAlive;
        private int numOranges;
        private int orangesEaten;

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                {
                    age = value;
                } else
                {
                    Console.WriteLine("Alder kan ikke være negativ.");
                    age = 0;
                }
            }
        }

        public int Height { get { return height; } set { height = value; } }
        public bool TreeAlive { get { return treeAlive; } set { treeAlive = value; } }
        public int NumOranges { get { return numOranges; } }
        public int OrangesEaten { get { return orangesEaten;  } }

        //public void SetAge(int age)
        //{
        //    this.age = age;
        //}

        //public int GetAge()
        //{
        //    return age;
        //}

        //public int SetHeight(int height)
        //{
        //    this.height = height;
        //    return height;
        //}
        //public int GetHeight()
        //{
        //    return height;
        //}

        //public bool SetTreeAlive(bool treeAlive)
        //{
        //    this.treeAlive = treeAlive;
        //    return treeAlive;
        //}

        //public bool GetTreeAlive()
        //{
        //    return treeAlive;
        //}

        //public int GetNumOranges()
        //{
        //    return numOranges;
        //}

        //public int GetOrangesEaten()
        //{
        //    return orangesEaten;

        //}

        public void OneYearPasses()
        {
            age = age + 1;
            if (age < 80)
            {
                height = height + 2;
                treeAlive = true;
                if (age > 1)
                {
                    numOranges = (age - 1) * 5;
                }
            }
            else
            {
                treeAlive = false;
                numOranges = 0;
            }


            //if (age > 1)
            //{
            //    numOranges = age * 5;
            //}


            Console.WriteLine(age);

        }

        public void EatOrange(int count)
        {
            //orangesEaten = numOranges - count;
            if (numOranges > count && age > 2)
            {
                this.orangesEaten = orangesEaten + count;
                this.numOranges = numOranges - count;
            }
        }
    }
}
