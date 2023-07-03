using UC7.BL.Models;
using Xunit;

namespace UC7.Tests
{
    public class PlayerAnalyzerTests : IClassFixture<TestsFixturePlayerAnalyzer>
    {
        private TestsFixturePlayerAnalyzer _setupData;
        private PlayerAnalyzer _playerAnalyzer;

        public PlayerAnalyzerTests(TestsFixturePlayerAnalyzer setupData)
        {
            _setupData = setupData;
            _playerAnalyzer = new PlayerAnalyzer();
        }

        [Fact]
        public void CalculateScore_TakesSingleNormalPlayerList_ReturnsScore()
        {
            Assert.Equal(_setupData.NormalPlayerScore, _playerAnalyzer.CalculateScore(GetPopulatedSinglePlayerList(_setupData.NormalPlayer)));
        }

        [Fact]
        public void CalculateScore_TakesSingleJuniorPlayerList_ReturnsScore()
        {
            Assert.Equal(_setupData.JuniorPlayerScore, _playerAnalyzer.CalculateScore(GetPopulatedSinglePlayerList(_setupData.JuniorPlayer)));
        }

        [Fact]
        public void CalculateScore_TakesSingleSeniorPlayerList_ReturnsScore()
        {
            Assert.Equal(_setupData.SeniorPlayerScore, _playerAnalyzer.CalculateScore(GetPopulatedSinglePlayerList(_setupData.SeniorPlayer)));
        }

        [Fact]
        public void CalculateScore_TakesPlayerList_ReturnsScoreSum()
        {
            List<Player> players = new List<Player>() { _setupData.NormalPlayer, _setupData.JuniorPlayer, _setupData.SeniorPlayer };

            double totalScore = _setupData.NormalPlayerScore + _setupData.JuniorPlayerScore + _setupData.SeniorPlayerScore;

            Assert.Equal(totalScore, _playerAnalyzer.CalculateScore(players));
        }

        [Fact]
        public void CalculateScore_TakesSinglePlayerWithSkillsNullList_ThrowsError()
        {
            Assert.Throws<ArgumentNullException>(() => _playerAnalyzer.CalculateScore(GetPopulatedSinglePlayerList(_setupData.NoskillPlayer)));
        }

        [Fact]
        public void CalculateScore_TakesEmptyPlayerList_ReturnsZero()
        {
            Assert.Equal(0, _playerAnalyzer.CalculateScore(new List<Player>()));
        }

        private List<Player> GetPopulatedSinglePlayerList(Player player)
        {
            return new List<Player>() { player };
        }
    }
}