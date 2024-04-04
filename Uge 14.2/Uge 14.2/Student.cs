﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Uge_14._2
{
    public class Student
    {
        public string FullName { get; set; }
        public int GroupNumber { get; set; }

        public Student(string fullName, int groupNumber)
        {
            FullName = fullName;
            GroupNumber = groupNumber;
        }

        public string MakeTitle()
        {
            string str = $"{FullName}, {GroupNumber}";
            return str;
        }
    }
}
