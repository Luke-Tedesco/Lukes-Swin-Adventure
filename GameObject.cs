using System;
namespace LukesSwinAdventure
{
    public abstract class GameObject : Identifiable_obj
    {
        private string description;
        private string _name;


        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string Shortdescription
        {
            get
            {
                return _name + " (" + FirstID + ")";
            }
        }

        public virtual string FullDescription
        {
            get
            {
                return description;
            }
        }

        public GameObject(string[] ids, string name, string desc) : base(ids)
        {
            description = desc;
            _name = name;

        }
    }
}
