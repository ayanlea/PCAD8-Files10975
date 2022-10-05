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

            

            // Create an array here called grdsArray with these values: 80, 90, 100, 95, 85
            float[] grdsArray = new float[] { 80, 90, 100, 95, 85 };

            // Call the addGrades method, passing it the grdsArray
            addGrades(grdsArray);
            
            // After adding grades to the array, call the displayGrades method
            displayGrades(grdsArray);


            // Create a new Stack object called myStack
            Stack myStack = new Stack();

            // Call the pushStack() method passing in the grades array for values

            pushStack(grdsArray, myStack);

            // Thinking through the process of viewing and choosing courses, write the pseudocode steps that you would complete for reviewing and choosing courses.

            



            // The popStack method will display each popped item to the console window
            // Then call the popStack() method twice to remove the top two items from stack
            Console.WriteLine("Peek at item to be popped from Stack", myStack.Peek());
            myStack.Pop();
            Console.WriteLine("Peek at item to be popped from Stack", myStack.Peek());
            myStack.Pop();
            
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
            Console.WriteLine("Item removed from the stack: ");

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
