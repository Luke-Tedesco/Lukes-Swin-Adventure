using System;
using System.Collections.Generic;

namespace LukesSwinAdventure
{
    public class Identifiable_obj
    {
        private List<string> _identifiers;

        public string FirstID
        {
            get
            {
                return _identifiers[0];

            }
        }

        public Identifiable_obj(string[] idents)
        {
            _identifiers = new List<string>();

            foreach (string s in idents)
            {
                _identifiers.Add(s);
            }

        }

        public bool AreYou(string id)
        {
            bool You = false;

            foreach (string s in _identifiers)
            {
                if (id.Equals(s, StringComparison.OrdinalIgnoreCase))
                {
                    You = true;
                }
            }
            return You;

        }

        public void AddIdentifier(string id)
        {
            _identifiers.Add(id);
        }
    }
}
