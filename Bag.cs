/*using System;
namespace LukesSwinAdventure
{
    public class Bag : Item, IHaveInventory
    {
        Inventory _inventory;

        public Bag(string [] ids, string name, string desc) : base(ids, name, desc)
        {
            _inventory = new Inventory();
        }

        public override string FullDescription
        {
            get
            {
                return "In the " + Name + " you can see:\n" + _inventory.ItemList;
            }
        }

        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }


        public GameObject Locate(string id)
        {
            GameObject obj = null;

            if (AreYou(id))
            {
                obj = this;
            }
            else if (_inventory.HasItem(id))
            {
                obj = _inventory.Fetch(id);
            }

            return obj;

        }
    }
} */
