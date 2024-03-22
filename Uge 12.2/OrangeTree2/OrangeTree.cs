using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeTreeSim
{
    public class OrangeTree
    {
        private int age;
        private int height;
        private bool treeAlive;
        private int numOranges;
        private int orangesEaten;

        public void SetAge(int age)
        { 
            this.age = age;
        }

        public int GetAge()
        {
            return age;
        }

        public int SetHeight(int height) 
        {
            this.height = height;
            return height;
        }
        public int GetHeight() 
        {
            return height;
        }

        public bool SetTreeAlive(bool treeAlive)
        {
            this.treeAlive = treeAlive;
            return treeAlive;
        }

        public bool GetTreeAlive()
        {
            return treeAlive;
        }

        public int GetNumOranges()
        {
            return numOranges;
        }

        public int GetOrangesEaten()
        {
            return orangesEaten;

        }

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
