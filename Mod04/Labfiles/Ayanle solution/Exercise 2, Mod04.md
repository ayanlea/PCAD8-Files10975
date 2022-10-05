## create list of topics you want to learn

## get list of courses offered
## for each course in list of courses, check if it contains any of the topics you want to learn
## if it does, add it to a list of courses you want to take


```C#
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDataStructures_CS
{
    class Program
    {
        static void Main(string[] args)
        {

            // create list of topics you want to learn
            string[] myCourseTopics = new string[] { "Computer Science", "Intro to A.I.", "Robotics", "Machine Learning" };

            // create a list of courses
            string[] courses = new string[] { "Computer Science", "Intro to A.I.", "Robotics", "Machine Learning", "Cooking", "Physical Health and Nutrition Science" };
            // loop thru myCourseTopics and check if it is in courses
                        
            string[] userCourseList = new string[4];
            addCourseToList(userCourseList);
            displayEnrolledCourses(userCourseList);

			Task 2:
			// Create a grades array with these values: 80, 90, 100, 95, 85
            float[] grdsArray = new float[] { 80, 90, 100, 95, 85 };

            // Call the addGrades method, passing it the grdsArray
            addGrades(grdsArray);
            
            // After adding grades to the array, call the displayGrades method
            displayGrades(grdsArray);

        }
        static void addCourseToList(string[] userCourseList)
        {
            int count = 0;
            string course = Console.ReadLine();
            while (count < 4 && course != null)
            {
                userCourseList[count] = course;
                
            }

        }
        static void displayEnrolledCourses(string[] courses)
        {

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine("You are now enrolled in " + courses[i]);
            }
        }
        static void addGrades(float[] grdArray)
        {
            double total = 0;
            double average = 0;
            for (int i = 0; i < grdArray.Length; i++)
            {
                total += grdArray[i];
            }
            average = total / grdArray.Length;
            Console.WriteLine("The average grade is {0}", average);

        }

        static void displayGrades(float[] grdArray)
        {
            // print out the grades to the console window
            // Use the foreach construct to iterate over the array
            foreach (float grade in grdArray)
            {
                Console.WriteLine("Grade: " + grade);
            }

        }

    }
}


```