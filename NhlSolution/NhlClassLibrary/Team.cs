using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NhlClassLibrary
{
    public class Team
    { //test
        // Define fully implemented properties with a backing field for Name, City, Arena, Conference, Division
        private string _name;
        private string _city;
        private string _arena;
        public List<Player> players { get; private set; }// = new List<Player>();
        public void AddPlayer(Player newPlayer)
        {
            if (newPlayer == null)
            {
                throw new ArgumentNullException(nameof(AddPlayer), "Player cannot be null");
            }
            foreach(var existingPlayer in players)
            {
                if (newPlayer.PlayerNumber==existingPlayer.PlayerNumber)
                {
                    throw new ArgumentException($"PlayerNumber {newPlayer.PlayerNumber} is already in the team");
                }
            }
            if (players.Count == 23)
            {
                throw new ArgumentException("Team is full. Cannot add anymore players");
            }
            players.Add(newPlayer);
        }
        
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
                //Validate new value only contains letters a-z
                string lettersOnlyPattern = @"^[a-zA-Z]{1,} $";
                if (Regex.IsMatch(value, lettersOnlyPattern))
                {
                    throw new ArgumentException("Name can only contain letters.");
                }
                _name = value.Trim(); // remove leading "    hello" and trailing "hello      " white spaces
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
                // Verify that new value is not blank
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(City), "Citty cannot be blank.");
                }
                // Verify that new value contains 3 or more chaacters
                if (value.Trim().Length < 3)
                {
                    throw new ArgumentException("City must contain 3 or more characters");
                }

                _city = value.Trim();
            }
        }
        public string Arena
        {
            get
            {
                return _arena;
            }
            set
            {
                // Validate that new value is not blank
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(Arena), "Arena value cannot be blank");
                }
                _arena = value.Trim();
            }
            
        }
        // Define auto-implemented properties for: Conference, Division
        public Conference Conference { get; set; }
        public Division Division { get; set; }
        // Greedy constructor
        public Team(string Name, string city, string arena, Conference conference, Division division)
        {
            this.Name = Name;
            City = city;
            Arena = arena;
            Conference = conference;
            Division = division;
            //_name = Name;
        }

        public override string ToString()
        {
            return $"Name: {Name}, City: {City}, Arena: {Arena}, Conference: {Conference}, Division: {Division}";
        }
    }
}
