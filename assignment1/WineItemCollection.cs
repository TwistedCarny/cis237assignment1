// Westin Curtis - CIS 237 - 1/15/2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection
    {
        private WineItem[] _wineItemArray;

        // Constructor
        public WineItemCollection(int size)
        {
            _wineItemArray = new WineItem[size];
        }

        // Add WineItem to the wine item array
        public void Add(string id, string description, string pack)
        {
            int searchIndex = SearchForEmptyIndex(); // Search for an empty index to store the wine item in
            if (searchIndex != -1) // Check to make sure the search was successful
            {
                _wineItemArray[searchIndex] = new WineItem(id, description, pack); // Create new wine item
            }

        }

        // Search for a wine item with an ID matching the one that the user inputs
        public WineItem Search(string inputID)
        {
            foreach(WineItem item in _wineItemArray)
            {
                if(item != null)
                {
                    if (item.ID.ToUpper() == inputID.ToUpper())
                    {
                        return item;
                    }
                }
                
            }
            return null;
        }

        // Construct and return a string containing the information of every WineItem in the wine item array
        public string GetPrintString()
        {
            string output = "";

            foreach (WineItem wineItem in _wineItemArray)
            {
                if (wineItem != null)
                {
                    output += wineItem.ID + "," + wineItem.Description + "," + wineItem.Pack + Environment.NewLine;
                }

            }

            return output;
        }

        // Search for an empty index in the wine item array to store a new WineItem in
        private int SearchForEmptyIndex()
        {
            for (int i = 0; i < _wineItemArray.Length; i++)
            {
                if (_wineItemArray[i] == null)
                {
                    return i; // Found index with null wine item
                }
            }

            return -1; // Did not find index with null wine item
        }
    }
}
