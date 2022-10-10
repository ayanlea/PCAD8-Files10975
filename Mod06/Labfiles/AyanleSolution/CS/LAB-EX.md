## Lab for Module 6


```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructLab_CS
{
    public struct Course
    {
        public string Title;
        public int CreditHours;
        public string academicProgram;
        public string Instructor;

        public Course(string title,int creditHours, string academicProgram,string teacher)
        {
            this.Title = title;
            this.CreditHours = creditHours;
            this.academicProgram = academicProgram;
            this.Instructor = teacher;


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
             oTitle –CS201oCredit Hours –6oProgram – Computer ScienceoInstructor –Mrs. Jones
             */
            Course course1 = new Course("CS101",6,"Computer Science","Mr. Smith");
            Course course2 = new Course("CS201",6,"Computer Science","Mrs. Jones");

            Console.WriteLine($"Course 1: {course1.Title}");
            Console.WriteLine($"Course 2: {course2.Title}");
            Console.ReadKey();
        }
    }
}


```