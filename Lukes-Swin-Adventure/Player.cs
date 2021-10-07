/*using System;

namespace LukesSwinAdventure
{
    public class Player : GameObject, IHaveInventory
    {
        private Inventory _inventory;

        public override string FullDescription
        {
            get
            {
                return "You are " + Name + " the " + FullDescription + "!\n" + "You are carrying\n" + Inventory.ItemList;  
            }
        }

        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }

        public Player(string name, string desc) : base( new string[] {"me", "inventory"}, name, desc)
        {
            _inventory = new Inventory();      
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
