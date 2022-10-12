using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_IO_CS
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
            if(response == 'S')
            {
                Console.WriteLine("You have selected Student");
            }
            else if (response == 'I')
            {
                Console.WriteLine("You have selected Instructor");
            }
            else if (response == 'Q')
            {
                Console.WriteLine("Are you sure you want to quit?");
                Console.WriteLine("Y - Yes");
                Console.WriteLine("N - No");
                while(response != 'Y' || response != 'N')
                {
                    char localRes;
                    localRes = Convert.ToChar(Console.Read());
                    if (localRes == 'Y')
                    {
                        Console.WriteLine("Shutting down application");
                    }
                    else if (localRes == 'N')
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
