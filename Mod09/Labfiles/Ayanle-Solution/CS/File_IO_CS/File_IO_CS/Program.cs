﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_IO_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuPrompt();

            char response;

            response = Convert.ToChar(Console.Read());

            if (response != null)
            {
                UserSelection(response);
            }
        }
        private static void MenuPrompt()
        {
            Console.WriteLine("Do you want to create a:");

            Console.WriteLine("S - Student");
            Console.WriteLine("I - Instructor");
            Console.WriteLine("Q - Quit");
        }
        private static void UserSelection(char response)
        {
            if (response == 'S' || response == 's')
            {
                StudentForm();
            }
            else if (response == 'I' || response == 'i')
            {
                InstructorForm();
            }
            else if (response == 'Q' || response == 'q')
            {
                Console.WriteLine("Are you sure you want to quit?");
                Console.WriteLine("Y - Yes");
                Console.WriteLine("N - No");
                bool looper = true;
                while (looper)
                {
                    char localRes;
                    localRes = Convert.ToChar(Console.Read());
                    if (localRes == 'Y' || localRes == 'y')
                    {
                        Console.WriteLine("Shutting down application");
                        looper = false;
                    }
                    else if (localRes == 'N' || localRes == 'n')
                    {
                        Console.WriteLine("Resuming application");
                        Console.WriteLine();
                        MenuPrompt();
                    }
                }
            }
        }

        private static void StudentForm()
        {

            Console.WriteLine("You have selected Student and now we need some info to register you");

            string first; 
            string last; 
            string gender; 
            int age;

            Console.WriteLine("What is your first name");
            Console.ReadLine();
            first = Convert.ToString(Console.ReadLine());


            Console.WriteLine("What is your last name");
            last = Convert.ToString(Console.ReadLine());

            Console.WriteLine("What is your gender"); 
            gender = Convert.ToString(Console.ReadLine());


            Console.WriteLine("What is your age");
            age = Convert.ToInt16(Console.ReadLine());


            Student newStudent = new Student(first, last, gender, age);
            Console.WriteLine();
            Console.WriteLine("You have entered the following:");
            Console.WriteLine($"Name: {newStudent.FirstName} {newStudent.LastName}");
            Console.WriteLine($"Age & Gender: {newStudent.Age} {newStudent.Gender}");

            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\ayanl\\Downloads\\StudentData.txt");
                string textData = "You have entered the following:";
                textData += $"Name: {newStudent.FirstName} {newStudent.LastName} \n";
                textData += $"Age & Gender: {newStudent.Age} {newStudent.Gender}";
                sw.WriteLine(textData);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
        private static void InstructorForm()
        {

            Console.WriteLine("You have selected Instructor and now we need some info to register you");

            string first;
            string last;
            string gender;
            int age;

            Console.WriteLine("What is your first name");
            Console.ReadLine();
            first = Convert.ToString(Console.ReadLine());


            Console.WriteLine("What is your last name");
            last = Convert.ToString(Console.ReadLine());

            Console.WriteLine("What is your gender");
            gender = Convert.ToString(Console.ReadLine());


            Console.WriteLine("What is your age");
            age = Convert.ToInt16(Console.ReadLine());


            Instructor newInstructor = new Instructor(first, last, gender, age);
            Console.WriteLine();
            Console.WriteLine("You have entered the following:");
            Console.WriteLine($"Name: {newInstructor.FirstName} {newInstructor.LastName}");
            Console.WriteLine($"Age & Gender: {newInstructor.Age} {newInstructor.Gender}");

            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\ayanl\\Downloads\\newInstructorData.txt");
                string textData = "You have entered the following:";
                textData += $"Name: {newInstructor.FirstName} {newInstructor.LastName} \n";
                textData += $"Age & Gender: {newInstructor.Age} {newInstructor.Gender}";
                sw.WriteLine(textData);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    
    }
}
