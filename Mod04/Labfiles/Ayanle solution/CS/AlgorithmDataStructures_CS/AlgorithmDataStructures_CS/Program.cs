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
            
            // Exercise 1, Mod04

            // create list of topics you want to learn
            string[] myCourseTopics = new string[] { "Computer Science", "Intro to A.I.", "Robotics", "Machine Learning" };

            // create a list of courses
            string[] courses = new string[] { "Computer Science", "Intro to A.I.", "Robotics", "Machine Learning", "Cooking", "Physical Health and Nutrition Science" };
            // loop thru myCourseTopics and check if it is in courses
            
            
            string[] userCourseList = new string[4];
            addCourseToList(userCourseList);
            displayEnrolledCourses(userCourseList);

            // Exercise 2, Mod04
            // Task 1
            // Create an array here called grdsArray with these values: 80, 90, 100, 95, 85
            float[] grdsArray = new float[] { 80, 90, 100, 95, 85 };

            // Call the addGrades method, passing it the grdsArray
            addGrades(grdsArray);

            // Create a new Stack object called myStack
            Stack myStack = new Stack();

            // Call the pushStack() method passing in the grades array for values

            pushStack(grdsArray, myStack);

            // The popStack method will display each popped item to the console window
            popStack(myStack);
            
            // Create a new SortedList object called myCourses
            // Call the populateList() method

            // display a course in the list by passing a key
            // Remove an item from the myCourses list using the key

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

            // After adding grades to the array, call the displayGrades method
            displayGrades(grdArray);

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
        
        static void pushStack(float[] grdArray,Stack myStack)
        {
            // Use a foreach loop to iterate over the array and push each item onto the stack
            foreach (float grade in grdArray)
            {
                myStack.Push(grade);
            }
        }

        static void popStack(Stack stack)
        {
            // Then call the popStack() method twice to remove the top two items from stack
            var stackItem = stack.Peek();
            Console.WriteLine("Peek at item to be popped from Stack: " + stackItem);
            stack.Pop();
            Console.WriteLine("Item removed from the stack: " + stackItem);
        }

        static void populateList(SortedList list)
        {

        }

        static void displayList(SortedList list, string key)
        {

        }

        static void removeListItem(SortedList list, string key)
        {

        }
    }
}
