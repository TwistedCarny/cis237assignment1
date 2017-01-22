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
        private static UserInterface ui;

        static void Main(string[] args)
        {
            ui = new UserInterface();
            CSVProcessor csvProcessor = new CSVProcessor();
            WineItemCollection wineItems = new WineItemCollection(4000);
            
            while (isRunning)
            {
                int userInput = ui.GetUserInput(true);
                switch (userInput)
                {
                    case 1: //TODO: Seperate into it's own method
                        if (!CSVProcessor.listLoaded)
                        {
                            csvProcessor.ProcessFile(Environment.CurrentDirectory + "/WineList.csv", wineItems);
                        }
                        else
                        {
                            ui.Output("The WineItem list has already been loaded.");
                        }

                        break;
                    case 2: //TODO: Seperate into it's own method
                        if (CSVProcessor.listLoaded)
                        {
                            foreach (WineItem wineItem in wineItems.WineItemArray)
                            {
                                if (wineItem != null)
                                {
                                    Console.WriteLine(wineItem.ToString());
                                }

                            }
                        }
                        else
                        {
                            ui.Output("List is empty");
                        }
                        
                        break;
                    case 3:
                        SearchMenuOption(wineItems);
                        break;
                    case 4:
                        // Do something
                        break;
                    case 5:
                        isRunning = false;
                        break;
                    default:
                        ui.PrintInvalidSelectionMessage();
                        break;
                }
                //ui.ClearScreen();
            }

        }

        public static void SearchMenuOption(WineItemCollection wineItemCollection)
        {
            if (CSVProcessor.listLoaded)
            {
                ui.ClearScreen();
                ui.Output("Enter ID to search for.");
                string userInput = ui.GetUserInput();
                int index = wineItemCollection.Search(userInput);
                if (index != -1)
                {
                    ui.Output("Found matching item.");
                    ui.Output(wineItemCollection.WineItemArray[index].ToString());
                }
                else
                {
                    ui.Output("Could not find an item with a matching ID");
                }
            }
            else
            {
                ui.Output("The WineItem list has not been loaded. Please load the list and try again.");
            }
            
        }
    }
}
