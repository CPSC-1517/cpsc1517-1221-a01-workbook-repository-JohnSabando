using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhLSystemTestProject
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        [DataRow(97, "Connor McDavid", Position.C)]
        [DataRow(93, "Ryan Nugent-Hopkins", Position.C)]
        [DataRow(91, "Evander Kane", Position.LW)]
        public void Constructor_ValidData_ShouldPass(int playerNumber, string playerName, Position playerPosition)
        {
            // Arrange, Act
            Player currentPlayer = new Player(playerNumber, playerName, playerPosition);
            //Assert
            Assert.AreEqual(playerNumber, currentPlayer.PlayerNumber);
            Assert.AreEqual(playerName, currentPlayer.PlayerName);
            Assert.AreEqual(playerPosition, currentPlayer.Position);

        }

        [TestMethod]
        [DataRow(0, "Connor McDavid", Position.C)]
        [DataRow(99, "Connor McDavid", Position.C)]
        [DataRow(-1, "Connor McDavid", Position.C)]
        [DataRow(100, "Connor McDavid", Position.C)]
        public void PlayerNumber_InvalidValue_ThrowsArgumentException(int playerNumber, string playerName, Position playerPosition)
        {
            try
            {
                // Arrange and Act
                Player currentPlayer = new Player(playerNumber, playerName, playerPosition);
                Assert.Fail("An ArgumentException should have been thrown");
            }
            catch(ArgumentException ex)
            {
                StringAssert.Contains(ex.Message, "PlayerNumber must be between 1 and 98");
                Assert.AreEqual(ex.Message, "PlayerNumber must be between 1 and 98");
            }
            catch(Exception ex)
            {
                Assert.Fail("Incorrect exception type thrown");
            }
        }

        [TestMethod]
        [DataRow(97, " ", Position.C)]
        [DataRow(93, null, Position.LW)]
        [DataRow(91, "ABC", Position.LW)]
        public void playerName_InvalidValue_ThrowsArgumentException(int playerNumber, string playerName, Position playerPosition)
        {
            try
            {
                // Arrange and Act
                Player currentPlayer = new Player(playerNumber, playerName, playerPosition);
                Assert.Fail("An ArgumentException should have been thrown");
            }
            catch(ArgumentException ex)
            {
                //StringAssert.Contains(ex.Message, "Name cannot be blank");
                Assert.AreEqual(ex.Message, "Name cannot be blank");
            }
            catch(Exception ex)
            {
                Assert.Fail("Incorrect exception type thrown");
            }
        }

        // Write test methods for property validation for GamesPlayed, Goals, Assits, Points
        [TestMethod]
        [DataRow(97,"Connor McDavid",Position.C,1,1,1)]
        [DataRow(93, "Ryan Nugent-Hopkins", Position.C,0,0,0)]
        public void gamesPlayed_InvalidValue_ThrowsArgumentException(int playerNumber, string playerName, Position playerPosition, int gamesPlayed, int goals, int assists)
        {
            try
            {
                // Arrange and Act
                Player currentPlayer = new Player(playerNumber, playerName, playerPosition, gamesPlayed, goals, assists);
                Assert.Fail("An ArgumentException should have been thrown");
            }
            catch (ArgumentException ex)
            {
                //StringAssert.Contains(ex.Message, "Name cannot be blank");
                Assert.AreEqual(ex.Message, "Invalid value, must be greater than 0");
            }
            catch (Exception ex)
            {
                Assert.Fail("Incorrect exception type thrown");
            }
        }
        //Write test methods for AddGamesPlayed(), AddGoals(), AddAssits()
    }
}
