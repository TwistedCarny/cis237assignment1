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
        private WineItem[] _wineItems;

        public WineItem[] WineItems
        {
            get { return _wineItems; }
        }

        public WineItemCollection(int size)
        {
            _wineItems = new WineItem[size];
        }

        public void Add(int index, string id, string description, string pack)
        {
            if(index < _wineItems.Length && _wineItems[index] == null)
            {
                _wineItems[index] = new WineItem(id, description, pack);
            }
            else
            {
                Array.Resize(ref _wineItems, _wineItems.Length + 1);
                index = _wineItems.Length-1;
                _wineItems[index] = new WineItem(id, description, pack);
            }
        }
    }
}
