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

        public string GetUserInput()
        {

            return Console.ReadLine();

        }


        private void PrintMenu()
        {
            Console.WriteLine("1 - Load Wine List");
            Console.WriteLine("2 - Display Items");
            Console.WriteLine("3 - Search For Item by ID");
            Console.WriteLine("4 - Add Item to List");
            Console.WriteLine("5 - Exit");
        }

        public void PrintInvalidSelectionMessage()
        {
            Console.WriteLine("That is not a valid entry.");
            Console.WriteLine("Please make a valid choice");

            Console.ReadLine(); // Wait for user input after displaying message.
        }

        public void Output(string output)
        {
            Console.WriteLine(output);
        }

        public void ClearScreen()
        {
            Console.Clear();
        }

    }
}
