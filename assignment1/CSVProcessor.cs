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

        public void ProcessFile(string filePath, WineItemCollection wineItems)
        {
            StreamReader dataFile = File.OpenText(filePath);

            int index = 0;
            while (!dataFile.EndOfStream)
            {
                string inputRecord = dataFile.ReadLine();

                var inputFields = inputRecord.Split(',');

                string id = inputFields[0];
                string description = inputFields[1];
                string pack = inputFields[2];

                wineItems.Add(index, id, description, pack);

                index++;
            }
        }

    }
}
