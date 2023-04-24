using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Book //if we use internal this class will only be accessible to this project, but if I want to access it in different project then internal should not be used
    {   
        //creates constructor class for the book class
        public Book(string name) {
            grades = new List<double>();
            this.name = name; //this refer to an object that is currently being operated on
            Console.WriteLine(name);
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
            Console.WriteLine(grade);
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach(var number in grades)
            {
                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine("average "+ result);
            Console.WriteLine(lowGrade);
            Console.WriteLine(highGrade);
        }

        //defining a property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private List<double> grades;
        private string name;
        //public gives access to code outside book class, private is only available to code inside book class
        
    }
   
}
