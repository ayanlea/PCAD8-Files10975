```C#

using System;
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
                Console.WriteLine("You have selected Student");
            }
            else if (response == 'I' || response == 'i')
            {
                Console.WriteLine("You have selected Instructor");
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
    }
}


```

