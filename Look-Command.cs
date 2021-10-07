/*using System;
namespace LukesSwinAdventure
{
    public class Look_Command : Command
    {
        public Look_Command()
        {
        }

        public override string Execute (Player p, string[] text)
        {

            if(text[1] != "look")
            {
                return "Error in look input";
            }
            else if(text.GetLength(1) != 3 || text.GetLength(1) != 5)
            {
                return "I don’t know how to look like that";
            }
            else if(text[2] != "at")
            {
                return "What do you want to look at?";
            }
            else if (text.GetLength(1) == 3)
            {
                 Container = p;
            }
            else if (text.GetLength(1) == 5 && text[4] == "in")
            {
                GameObject obj = p.Locate(text[5]);

                string containerId = obj.FirstID;

                IHaveInventory Container = FetchContainer(p, containerId);

                if (Container == null)
                {
                    return "I cannot find the " + text[5];
                }
            }


        }

        private IHaveInventory FetchContainer(Player p, string containerId)
        {
            Item containerItem = p.Inventory.Fetch(containerId);

            if (containerItem = Bag)

            IHaveInventory containerItem

            

            
        }

        private string LookAtIn (string thingId, IHaveInventory container)
        {

        }
    }
}
*/