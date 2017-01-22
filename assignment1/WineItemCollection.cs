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


        public WineItem[] WineItemArray
        {
            get { return _wineItemArray; }
        }

        public WineItemCollection(int size)
        {
            _wineItemArray = new WineItem[size];
        }

        public void Add(int index, string id, string description, string pack)
        {
            if(index < _wineItemArray.Length && _wineItemArray[index] == null)
            {
                _wineItemArray[index] = new WineItem(id, description, pack);
            }
            else
            {
                Array.Resize(ref _wineItemArray, _wineItemArray.Length + 1);
                index = _wineItemArray.Length-1;
                _wineItemArray[index] = new WineItem(id, description, pack);
            }
        }

        public int Search(string inputID)
        {
            for(int i = 0; i < _wineItemArray.Length; i++)
            {
                if(_wineItemArray[i] != null && _wineItemArray[i].ID.ToUpper() == inputID.ToUpper())
                {
                    return i; // Found matching item. Return matching index
                }
            }
            return -1; // Did not find matching item. Return -1;
        }
    }
}
