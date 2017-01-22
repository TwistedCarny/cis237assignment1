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
    }
}
