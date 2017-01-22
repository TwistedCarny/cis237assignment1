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
        public int GetUserInput()
        {
            Console.WriteLine("1 - Load Wine List");
            Console.WriteLine("2 - Display Items");
            Console.WriteLine("3 - Search For Item by ID");
            Console.WriteLine("4 - Add Item to List");
            Console.WriteLine("5 - Exit");

            return int.Parse(Console.ReadLine());
        }

        public void PrintInvalidSelectionMessage()
        {
            Console.WriteLine("Invalid selection. Please select a menu item from 1-5.");

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
