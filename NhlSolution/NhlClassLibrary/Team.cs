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
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(City), "Citty cannot be blank.");
                }
                _city = value.Trim();
            }
        }
        // Define auto-implemented properties for: Conference, Division
        public Conference Conference { get; set; }
        public Division Division { get; set; }
        // Greedy constructor
        public Team(string Name, Conference conference, Division division)
        {
            this.Name = Name;
            Conference = conference;
            Division = division;
            //_name = Name;
        }
    }
}
