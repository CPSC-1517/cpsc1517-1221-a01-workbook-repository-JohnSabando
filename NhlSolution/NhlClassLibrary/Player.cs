using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private int _assits;
        private int _points;

        public int PlayerNumber
        {

            get => _playerNumber;
            private set
            {
                if (value < MinPlayerNo || value > MaxPlayerNo)
                {
                    throw new ArgumentException($"PlayerNumber cannot be less than {MinPlayerNo} or greater than {MaxPlayerNo}");
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
            private set
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
        public int Assits
        {
            get => _assits;
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
                return Goals + Assits;
            }
        }
        public Player(int playerNumber, string playerName, Position position)
        {
            PlayerNumber = playerNumber;
            PlayerName = playerName;
            Position = position;
        }
        public Player(int playerNumber, string playerName, int gamesPlayed, int goals, int assists)
        {
            PlayerNumber = playerNumber;
            PlayerName = playerName;
            GamesPlayed = gamesPlayed;
            Goals = goals;
            Assits = assists;
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
            Assits += 1;
        }
    }
}
