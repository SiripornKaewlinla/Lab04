using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class Class1
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public double Grade { get; set; }
        public Class1(string name, int year, double grade)
        {
            this.Name = name;
            this.Year = 2566 - year;
            this.Grade = grade;
        }
    }
}
