﻿namespace Øvelse_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("123");
            var p = new Academy("UCL");
            var s1 = new Student(p, "Jens");
            var s2 = new Student(p, "Niels");
            var s3 = new Student(p, "Susan");
            p.Attach(s1);
            p.Attach(s2);
            p.Attach(s3);
            p.Message = "Så er der julefrokost!";
            p.Detach(s2);
            p.Message = "Så er der fredagsbar!";
            Console.ReadLine();
        }
    }
}
