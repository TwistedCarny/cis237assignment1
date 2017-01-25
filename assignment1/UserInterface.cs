// Westin Curtis - CIS 237 - 1/15/2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {
        // Show menu to user and get input from them to be used later
        public int GetUserInput(bool showMenu)
        {
            if (showMenu)
            {
                PrintMenu();
            }

            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch
            {
                PrintInvalidSelectionMessage();
                return -1;
            }
            
        }

        // Get user input
        public string GetUserInput()
        {

            return Console.ReadLine();

        }


        // Print menu options to the console
        private void PrintMenu()
        {
            Console.WriteLine("1 - Load Wine List");
            Console.WriteLine("2 - Display Items");
            Console.WriteLine("3 - Search For Item by ID");
            Console.WriteLine("4 - Add Item to List");
            Console.WriteLine("5 - Exit");
        }

        // Print a message stating that the user did not make a valid choice
        public void PrintInvalidSelectionMessage()
        {
            Console.WriteLine("That is not a valid entry.");
            Console.WriteLine("Please make a valid choice");

            Console.ReadLine(); // Wait for user input after displaying message.
        }

        // Simply output a string to the console
        public void Output(string output)
        {
            Console.WriteLine(output);
        }

        // Clear the console window
        public void ClearScreen()
        {
            Console.Clear();
        }

        // Wait for keypress from user
        public void WaitForKeyPress()
        {
            Console.ReadLine();
        }

        // Output message then wait for key press from the user
        public void WaitForKeyPress(string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }

    }
}
