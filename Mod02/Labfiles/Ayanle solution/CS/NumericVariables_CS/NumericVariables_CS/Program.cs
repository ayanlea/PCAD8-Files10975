using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericVariables_CS
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Course ID, should be an int. Will help with DB table indexing
            int courseId = 101;

            // Course length in weeks. Should be an int because there are 52 weeks per year and each week is an int value
            int courseLength = 22;

            //GPA. Should be a 'double' datatype since GPA is often represented in single decimal point
            double courseGPA = 3.5d;

            // Course Title, should be a 'string' datatype, which is going to be used by people to identify this course
            string courseName = "Intro to existentialism";

            // Course Description,  should be a 'string' datatype, which is going to be used by people to identify this course
            string courseDescription = "What is the point of it all?";

            // Instructor Name,  should be a 'string' datatype, which is going to be used by people to identify teacher
            string courseInstructor = "Joe Schmo";

            // Does it exist, should be boolean as value can either be true or false
            bool courseExists = true;

            // Passing grade, should be a 'char' since a grade is a single character like A, B or C
            char courseGrade = 'A';

            // Course enrollment, should be boolean since you're either enrolled or not.
            bool courseEnrollment = true;


            string message = $"Ayanle is enrolled in {courseName}";

            // output in console all the variables declared above
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
