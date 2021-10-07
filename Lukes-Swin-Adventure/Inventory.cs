using System;
using System.Collections.Generic;

namespace LukesSwinAdventure
{
    public class Inventory
    {
        private List<Item> _items;

        public string ItemList
        {
            get
            {
                string List = null;

                foreach( Item i in _items)
                {
                     List += "    " + i.Shortdescription +"\n";
                }

                return List;
            }
        }

        public Inventory()
        {
            _items = new List<Item>();
        }

        public bool HasItem(string id)
        {
            bool item = false;

            foreach (Item i in _items)
            {
                if (i.AreYou(id))
                {
                    item = true;
                }
            }

            return item;
        }

        public void Put(Item itm)
        {
            _items.Add(itm); 
        }

        public Item Take(string id)
        {
            Item removedItem = null;

            foreach (Item i in _items )
            {
                if (i.AreYou(id))
                {
                    _items.Remove(i);
                    removedItem = i;
                }

            }

            return removedItem;
        }

        public Item Fetch(string id)
        {

            Item fetchedItem = null;

            foreach (Item i in _items)
            {
                if (i.AreYou(id))
                {
                    fetchedItem = i;
                }
            }

            return fetchedItem;
        }
    }
}
