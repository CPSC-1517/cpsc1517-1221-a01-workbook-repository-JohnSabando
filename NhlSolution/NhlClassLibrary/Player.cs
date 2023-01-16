using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhlClassLibrary
{
    public class Player
    {
        private int _playerNumber;
        private string _playerName;
        private int _gamesPlayed;
        private int _goals;
        private int _assits;
        private int _points;

        public int PlayerNumber
        {
            get
            {
                return _playerNumber;
            }
            set
            {
                if (value < 1 || value > 98)
                {
                    throw new ArgumentException("PlayerNumber cannot be less than 1 or greater than 98");
                }
                _playerNumber = value;
            }
        }
        public string PlayerName
        {
            get
            {
                return _playerName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(PlayerName), "Name cannot be blank");
                }
                _playerName = value;
            }
        }
        public Position Position { get; set; }
        public int GamesPlayed
        {
            get
            {
                return _gamesPlayed;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of Games cannot be less than 0");
                }
                value = _gamesPlayed;
            }
        }
        public int Goals
        {
            get
            {
                return _goals;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of goals cannot be less than 0");
                }
                value = _goals;
            }
        }
        public int Assits
        {
            get
            {
                return _assits;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Assits value cannot be less than 0");
                }
                _assits = value;
            }
        }
        public int Points
        {
            get
            {
                return _points;
            }
            set
            {
                _points = Goals + Assits;
            }
        }
        public Player(int playerNumber, string playerName, int gamesPlayed, int goals, int assits, int points, Position position)
        {
            PlayerNumber = playerNumber;
            PlayerName = playerName;
            GamesPlayed = gamesPlayed;
            Goals = goals;
            Assits = assits;
            Points = points;
            Position = position;
        }
    }
}
