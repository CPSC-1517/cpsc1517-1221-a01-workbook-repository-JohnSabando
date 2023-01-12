using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhlClassLibrary
{
    public class Team
    {
        // Define fully implemented properties with a backing field for Name, City, Arena, Conference, Division
        private string _name;
        private string _city;
        private string _arena;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                //Validate new value is not blank and contains only letters a-z
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(Name), "Name cannot be blank.");
                }
                _name = value.Trim();
            }
        }
        // Define auto-implemented properties for: Conference, Division

        // Greedy constructor
        public Team(string Name)
        {
            this.Name = Name;
            //_name = Name;
        }
    }
}
