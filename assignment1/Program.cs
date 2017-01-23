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
                    case 1:
                        LoadListMenuOption(csvProcessor, wineItems);
                        break;
                    case 2:
                        DisplayListMenuOption(wineItems);      
                        break;
                    case 3:
                        SearchMenuOption(wineItems);
                        break;
                    case 4:
                        AddItemMenuOption(wineItems);
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

        public static void LoadListMenuOption(CSVProcessor csvProcessor, WineItemCollection wineItems)
        {
            if (!CSVProcessor.listLoaded)
            {
                csvProcessor.ProcessFile("WineList.csv", wineItems);
            }
            else
            {
                ui.Output("The WineItem list has already been loaded.");
            }
        }

        public static void DisplayListMenuOption(WineItemCollection wineItems)
        {
            if (CSVProcessor.listLoaded)
            {
                ui.Output(wineItems.GetPrintString());
            }
            else
            {
                ui.Output("List is empty");
            }
        }

        public static void SearchMenuOption(WineItemCollection wineItemCollection)
        {
            if (CSVProcessor.listLoaded)
            {
                ui.ClearScreen();
                ui.Output("Enter ID to search for.");
                string userInput = ui.GetUserInput();
                WineItem wineItem = wineItemCollection.Search(userInput);
                if (wineItem != null)
                {
                    ui.Output("Found matching item.");
                    ui.Output(wineItem.ToString());
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

        public static void AddItemMenuOption(WineItemCollection wineItems)
        {
            string id;
            string description;
            string pack;
            ui.ClearScreen();

            ui.Output("Enter Wine Item ID:");
            id = ui.GetUserInput();

            ui.Output("Enter Wine Item Description:");
            description = ui.GetUserInput();

            ui.Output("Enter Wine Item Pack:");
            pack = ui.GetUserInput();

            wineItems.Add(id, description, pack);
        }
    }
}
