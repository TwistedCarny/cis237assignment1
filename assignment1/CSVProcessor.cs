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

        public static bool listLoaded = false;

        public void ProcessFile(string filePath, WineItemCollection wineItems)
        {
            StreamReader dataFile = null;

            try
            {
                dataFile = new StreamReader(filePath);

                int index = 0;
                while (!dataFile.EndOfStream)
                {
                    string inputRecord = dataFile.ReadLine();

                    var inputFields = inputRecord.Split(',');

                    string id = inputFields[0];
                    string description = inputFields[1];
                    string pack = inputFields[2];

                    wineItems.Add(id, description, pack);

                    index++;
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
