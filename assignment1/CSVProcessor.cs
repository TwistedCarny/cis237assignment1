// Westin Curtis - CIS 237 - 1/15/2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class CSVProcessor
    {
        // Static bool used to check if the list is loaded
        public static bool listLoaded = false;

        // Load data into an array from whatever file is set for the file path
        public void ProcessFile(string filePath, WineItemCollection wineItems)
        {
            StreamReader dataFile = null;

            try
            {
                dataFile = new StreamReader(filePath);

                int counter = 0;
                while (!dataFile.EndOfStream) // Loop through the data file and assign fields, then create a new WineItem
                {
                    string inputRecord = dataFile.ReadLine();

                    var inputFields = inputRecord.Split(',');

                    string id = inputFields[0];
                    string description = inputFields[1];
                    string pack = inputFields[2];

                    wineItems.Add(id, description, pack);

                    counter++;
                }

                listLoaded = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                if(dataFile != null)
                {
                    dataFile.Close();
                }
            }  
            
        }

    }
}
