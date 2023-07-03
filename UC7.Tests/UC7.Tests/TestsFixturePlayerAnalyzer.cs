using UC7.BL.Models;

namespace UC7.Tests
{
    public class TestsFixturePlayerAnalyzer
    {
        public Player NormalPlayer;
        public Player JuniorPlayer;
        public Player SeniorPlayer;
        public Player NoskillPlayer;

        public double NormalPlayerScore = 250;
        public double JuniorPlayerScore = 67.5;
        public double SeniorPlayerScore = 2520;

        public TestsFixturePlayerAnalyzer()
        {
            NormalPlayer = new Player
            {
                Age = 25,
                Experience = 5,
                Name = "Revan",
                Skills = new List<int>() {2, 2, 2}
            };

            JuniorPlayer = new Player()
            {
                Age = 15,
                Experience = 3,
                Name = "Revan Jr.",
                Skills= new List<int>() { 3, 3, 3 }
            };

            SeniorPlayer = new Player()
            {
                Age = 35,
                Experience = 15,
                Name = "Revan Sr.",
                Skills = new List<int>() { 4, 4, 4 }
            };

            NoskillPlayer = new Player()
            {
                Age = 27,
                Experience = 12,
                Name = "Revan Noskill",
                Skills = null
            };
        }
    }
}
