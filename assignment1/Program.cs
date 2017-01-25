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
            
            while (isRunning) // Main loop
            {
                int userInput = ui.GetUserInput(true); // Print menu and get user input
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
                ui.ClearScreen();
            }

        }

        // Method that gets called when the "Load List Menu Option" is called.
        public static void LoadListMenuOption(CSVProcessor csvProcessor, WineItemCollection wineItems)
        {
            ui.ClearScreen();
            if (!CSVProcessor.listLoaded)
            {
                csvProcessor.ProcessFile("WineList.csv", wineItems);
                ui.WaitForKeyPress("List loaded successfully... Press enter to continue...");
            }
            else
            {
                ui.Output("The WineItem list has already been loaded.");
            }
        }

        // Method that gets called when the "Display List Menu Option" is called.
        public static void DisplayListMenuOption(WineItemCollection wineItems)
        {
            if (CSVProcessor.listLoaded)
            {
                ui.Output(wineItems.GetPrintString());
                ui.WaitForKeyPress("Press enter to continue...");
            }
            else
            {
                ui.WaitForKeyPress("List has not been initialized. Please load list before displaying it. Press enter to continue...");
            }
        }

        // Method that gets executed when the Search Menu Option is selected. Searches through the WineItemCollection for a matching WineItem.
        public static void SearchMenuOption(WineItemCollection wineItemCollection)
        {
            if (CSVProcessor.listLoaded)
            {
                ui.ClearScreen();
                ui.Output("Enter ID to search for.");
                string userInput = ui.GetUserInput();
                WineItem wineItem = wineItemCollection.Search(userInput); // Get wine item from the list to be used for output.
                if (wineItem != null)
                {
                    ui.Output("Found matching item.");
                    ui.Output(wineItem.ToString());

                    ui.WaitForKeyPress("Press enter to continue...");
                }
                else
                {
                    ui.Output("Could not find an item with a matching ID");

                    ui.WaitForKeyPress("Press enter to continue...");
                }
            }
            else
            {
                ui.Output("The WineItem list has not been loaded. Please load the list and try again.");
            }
            
        }

        // Method that gets called when the Add Item Menu Option is selected. Handles adding a WineItem to the WineItemCollection.
        public static void AddItemMenuOption(WineItemCollection wineItems)
        {
            if (CSVProcessor.listLoaded)
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

                ui.WaitForKeyPress("Wine Item added to collection... Press enter to continue...");
            }
            else
            {
                ui.WaitForKeyPress("WineItemCollection has not been initialized. Please initialize list before trying to add a WineItem." +
                    " Press enter to continue...");
            }
            
        }
    }
}
