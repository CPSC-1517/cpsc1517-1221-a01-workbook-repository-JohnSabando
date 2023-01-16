using NhlClassLibrary;

namespace NhLSystemTestProject
{
    [TestClass]
    public class TeamTest
    {
        [TestMethod]
        [DataRow("Oilers","Edmonton","Rogers Place", Conference.Western, Division.Pacific)]
        [DataRow("Flames","Calgary","Scotiabank Saddledome", Conference.Western, Division.Pacific)]
        [DataRow("Canucks","Vancouver","Rogers Arena", Conference.Western, Division.Pacific)]
        [DataRow("Maple Leafs","Torronto", "Scotiabank Arena", Conference.Eastern, Division.Atlantic)]
        [DataRow("Senators","Ottowa","Candian Tire Centre", Conference.Eastern, Division.Central)]
        [DataRow("Canadiens","Montreal","Centre bell", Conference.Eastern, Division.Atlantic)]
        [DataRow("Jets","Winnipeg","Canada Life Centre", Conference.Western, Division.Central)]
        public void Name_ValidName_NameSet(string teamName, string city, string arena, Conference conference, Division division)
        {
            // Arrange
            // Act
            Team currentTeam = new Team(teamName, city, arena, conference, division);
            // Assert
            Assert.AreEqual(teamName, currentTeam.Name);
            Assert.AreEqual(conference, currentTeam.Conference);
            Assert.AreEqual(division, currentTeam.Division);
            Assert.AreEqual(city, currentTeam.City);
            Assert.AreEqual(arena, currentTeam.Arena);
        }

        [TestMethod]
        [DataRow("", "Name cannot be blank.", Conference.Western, Division.Pacific)]
        [DataRow("      ", "Name cannot be blank", Conference.Western, Division.Pacific)]
        public void Name_Invalid_ThrowsArgumentNullException(string teamName, string city, string arena, string exceptedErrorMessage, Conference conference, Division division)
        {
            // Arrange and Act
            try
            {
                Team currentTeam = new Team(teamName, city, arena, conference, division);
                Assert.Fail("An ArgumentNullException should have been thrown");
            }
            catch(ArgumentNullException ex)
            {
                StringAssert.Contains(ex.Message, exceptedErrorMessage);
            }
        }
    }
}