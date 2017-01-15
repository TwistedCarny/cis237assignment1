// Westin Curtis - CIS 237 - 1/15/2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        private static bool isRunning = true;

        static void Main(string[] args)
        {
            UserInterface UI = new UserInterface();

            
            while (isRunning)
            {
                int userInput = UI.DisplayMenuOptions();
                switch (userInput)
                {
                    case 1:
                        // Do something
                        break;
                    case 2:
                        // Do something
                        break;
                    case 3:
                        // Do something
                        break;
                    case 4:
                        // Do something
                        break;
                    case 5:
                        // Do something
                        break;
                    default:
                        UI.DisplayInvalidSelectionMessage();
                        break;
                }
                UI.ClearScreen();
            }

        }
    }
}
