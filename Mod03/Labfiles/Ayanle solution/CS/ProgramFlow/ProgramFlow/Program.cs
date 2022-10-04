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
        //Exercise 1:
        //Task 1:
        static void SetInstructorName(string name)
        {
            Console.WriteLine("Instructor name is set to " + name);
        }
        static void SetCourseTitle(string courseName)
        {
            Console.WriteLine("Course name is " + courseName);
        }

        //Task 3, Exercise 1:
        private static bool ValidateCourseTitle(string title)
        {
            if (title == "Intro to Existentialism!")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static void Main(string[] args)
        {
            string[] courses = new string[] { "Intro to Existentialism!", "Stoneage tools" };

            string courseName = "Intro to Existentialism!";
            //Task 2, Exercise 1:
            SetInstructorName("Ayanle");
            SetCourseTitle(courseName);
            var res = ValidateCourseTitle(courseName);
            if (res) { Console.WriteLine("Class is about meaning of life"); }

            //Exercise 2: ========================
            // Task 1, Exercise 2
            if (courseName.Length > 10)
            {
                Console.WriteLine("Long course name");
                Console.WriteLine("Course is " + courseName.Length + " strings long");
            }
            bool classInProgram = CourseInProgram(courses, courseName);
            Console.WriteLine("classInProgram is " + classInProgram);
            AssignmentIsDue("quiz");
            CalculateAverage();
            UserProvidedGrades();


        }
        static bool CourseInProgram(string[] classes, string course)
        {
            bool localVar = false;
            for (int i = 0; i < classes.Length; i++)
            {
                if (classes[i] == course)
                {
                    return localVar = true;
                }
                else
                {
                    return localVar = false;
                }
            }
            return localVar;

        }
        static void AssignmentIsDue(string assignmentType)
        {
            switch (assignmentType)
            {
                case "post":
                    Console.WriteLine("Post is due");
                    break;
                case "assignment":
                    Console.WriteLine("Assignment is due");
                    break;
                case "quiz":
                    Console.WriteLine("Quiz is due");
                    break;
                default:
                    Console.WriteLine("Nothing due");
                    break;
            }
        }
        static void CalculateAverage()
        {
            double[] grades = new double[] { 89, 98, 99, 90, 95 };
            double total = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                total += grades[i];
                // Console.WriteLine(total +=grades[i]);
            }
            Console.WriteLine("GPA is " + total / grades.Length);

        }
        static void UserProvidedGrades()
        {
            int count = 0;
            double myGrade = 0;
            while (count < 5)
            {
                count++;
                Console.WriteLine("Enter your grade");
                myGrade += double.Parse(Console.ReadLine());
            }
            Console.WriteLine("GPA so far is " + (myGrade / count));
            Console.ReadKey();

        }
    }
}
