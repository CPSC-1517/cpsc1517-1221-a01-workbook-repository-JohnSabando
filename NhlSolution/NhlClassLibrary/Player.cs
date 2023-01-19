using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NhlClassLibrary
{
    public class Player
    {
        const int MinPlayerNo = 1;
        const int MaxPlayerNo = 98;

        private int _playerNumber;
        private string _playerName;
        private int _gamesPlayed;
        private int _goals;
        private int _assists;
        private int _points;

        public int PlayerNumber
        {

            get => _playerNumber;
            private set
            {
                if (value < MinPlayerNo || value > MaxPlayerNo)
                {
                    throw new ArgumentException($"PlayerNumber must be between {MinPlayerNo} and {MaxPlayerNo}");
                    //throw new ArgumentNullException(nameof(PlayerNumber),$"PlayerNumber must be between {MinPlayerNo} and {MaxPlayerNo}");
                }
                _playerNumber = value;
            }
        }
        public string PlayerName
        {
            get => _playerName;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(PlayerName), "Name cannot be blank");
                }
                _playerName = value.Trim();
            }
        }
        public Position Position { get; private set; }
        public int GamesPlayed
        {
            get => _gamesPlayed;
            protected set
            {
                if (!Utilities.IsPositiveOrZero(value))
                {
                    throw new ArgumentException("Number of Games cannot be less than 0");
                }
                value = _gamesPlayed;
            }
        }
        public int Goals
        {
            get => _goals;
            private set
            {
                if (!Utilities.IsPositiveOrZero(value))
                {
                    throw new ArgumentException("Number of goals cannot be less than 0");
                }
            }
        }
        public int Assists
        {
            get => _assists;
            set
            {
                if (!Utilities.IsPositiveOrZero(value))
                {
                    throw new ArgumentException("Assits value cannot be less than 0");
                }
            }
        }
        public int Points
        {
            get
            {
                return Goals + Assists;
            }
        }
        public Player(int playerNumber, string playerName, Position position)
        {
            PlayerNumber = playerNumber;
            PlayerName = playerName;
            Position = position;
        }
        public Player(int playerNo, string name, Position position, int gamesPlayed, int goals, int assists)
        {
            PlayerNumber = playerNo;
            PlayerName = name;
            Position = position;
            GamesPlayed = gamesPlayed;
            Goals = goals;
            Assists = assists;
        }
        public void AddPlayer(Player newPlayer, List<Player> lisftOfPlayers)
        {

        }
        public void ListPlayer(List<Player> listOfPlayers)
        {

        }
        public void AddGamesPlayed()
        {
            GamesPlayed += 1;
        }
        public void AddGoals()
        {
            Goals += 1;
        }
        public void AddAssits()
        {
            Assists += 1;
        }
    }
}
