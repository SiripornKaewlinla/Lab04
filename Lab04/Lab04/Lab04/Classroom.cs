using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class Classroom
    {
        public List<Class1> class1List = new List<Class1>();
        public List<int> YearList = new List<int>();
        public List<double> GradeList = new List<double>();
        public List<string> NameList = new List<string>();

        public void addclass1(Class1 class1)
        {
            class1List.Add(class1);
            YearList.Add(class1.Year);

        }
        public string Showclass1()
        {
            string results = "";
            foreach (var class1 in class1List)
            {
                results += class1.Name + "\n";
            }
            return results;
        }
        public int ShowAllAge()
        {

            return YearList.Sum();
        }

        public void SetGrade()
        {
            foreach (var class1 in class1List)
            {
                GradeList.Add(class1.Grade);
                NameList.Add(class1.Name);
            }
        }
        public double ShowMaxGrade()
        {
            return GradeList.Max();
        }
        public double ShowMinGrade()
        {
            return GradeList.Min();
        }

        public string ShowMaxGradeName()
        {
            return NameList[GradeList.IndexOf(GradeList.Max())];
        }
        public string ShowMinGradeName()
        {
            return NameList[GradeList.IndexOf(GradeList.Min())];
        }
    }
}
