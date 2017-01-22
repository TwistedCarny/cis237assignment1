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
            UserInterface ui = new UserInterface();
            CSVProcessor csvProcessor = new CSVProcessor();
            WineItemCollection wineItems = new WineItemCollection(4000);
            
            while (isRunning)
            {
                int userInput = ui.GetUserInput();
                switch (userInput)
                {
                    case 1:
                        csvProcessor.ProcessFile(Environment.CurrentDirectory + "/WineList.csv", wineItems);
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
                        ui.PrintInvalidSelectionMessage();
                        break;
                }
                //ui.ClearScreen();
            }

        }
    }
}
