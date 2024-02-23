namespace _1._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "4-5+9";
            int sum = 0;
            int i = 0;
            string s = "";
            char op = '+';

            while (i < str.Length)
            {
                if (str[i] == '+' || str[i] == '-')
                {
                    if (op == '+')
                    {
                        sum = sum + int.Parse(s);
                        s = "";
                    }
                    else if (op == '-')
                    {
                        sum = sum - int.Parse(s);
                        s = "";
                    }
                    op = str[i];

                }
                else
                {
                    s = s + str[i];
                }
                i++;
            }

            if (op == '-')
            {
                sum = sum - int.Parse(s);
                s = "";
            }
            else if (op == '+')
            {
                sum = sum + int.Parse(s);
                s = "";
            }
            Console.WriteLine(str);
            Console.WriteLine(sum);
        }
    }
}
