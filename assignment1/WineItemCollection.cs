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

        public WineItemCollection(int size)
        {
            _wineItemArray = new WineItem[size];
        }

        public void Add(string id, string description, string pack)
        {
            int searchIndex = SearchForEmptyIndex();
            if (searchIndex != -1)
            {
                _wineItemArray[searchIndex] = new WineItem(id, description, pack);
            }

        }

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
