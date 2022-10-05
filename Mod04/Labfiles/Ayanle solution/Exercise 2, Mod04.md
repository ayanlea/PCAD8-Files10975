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
    }
}


```