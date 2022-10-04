using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 2:
            SetInstructorName("Ayanle");
            SetCourseTitle("Intro to Existentialism!");
            ValidateCourseTitle("Intro to Existentialism!");
            Console.ReadKey();
        }

        //Task 1:
        static void SetInstructorName(string name)
        {
            Console.WriteLine("Instructor name is set to " + name);
        }
        static void SetCourseTitle(string courseName)
        {
            Console.WriteLine("Course name is " + courseName);
        }

        //Task 3:
        private static bool ValidateCourseTitle(string title)
        {
            if(title == "Intro to Existentialism!")
            {
                return true;
            }
            else { 
                return false; 
            }

        }
        static void CalculateAverage()
        {
            double[] grades = new double[] { 89, 98, 99, 90, 95 };
            

        }
    }
}
