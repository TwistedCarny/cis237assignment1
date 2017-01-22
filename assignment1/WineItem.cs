// Westin Curtis - CIS 237 - 1/15/2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem
    {
        private string _id;
        private string _description;
        private string _pack;

        public string ID
        {
            get { return _id; }
        }

        public string Description
        {
            get { return _description; }
        }

        public string Pack
        {
            get { return _pack; }
        }

        public WineItem(string id, string description, string pack)
        {
            _id = id;
            _description = description;
            _pack = pack;
        }
    }
}
