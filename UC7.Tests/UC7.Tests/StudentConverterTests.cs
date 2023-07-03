using UC7.BL;
using UC7.BL.Models;
using Xunit;

namespace UC7.Tests
{
    public class StudentConverterTests : IClassFixture<TestsFixtureStudentConverter>
    {
        private TestsFixtureStudentConverter _setupData;
        private StudentConverter _studentConverter;

        public StudentConverterTests(TestsFixtureStudentConverter setupData)
        {
            _setupData = setupData;
            _studentConverter = new StudentConverter();
        }

        [Fact]
        public void ConvertStudents_TakesSinglePerfectScoreStudentAged21PlusList_ReturnsHonorRollTrue()
        {
            Assert.True(_studentConverter.ConvertStudents(GetPopulatedSingleStudentList(_setupData.StudentOver21PerfectScore)).First().HonorRoll);
        }

        [Fact]
        public void ConvertStudents_TakesSinglePerfectScoreStudentAgedLessThan21List_ReturnsExceptionalTrue()
        {
            Assert.True(_studentConverter.ConvertStudents(GetPopulatedSingleStudentList(_setupData.StudentLessThan21PerfectScore)).First().Exceptional);
        }

        [Fact]
        public void ConvertStudents_TakesSinglePassingScoreStudentList_ReturnsPassedTrue()
        {
            Assert.True(_studentConverter.ConvertStudents(GetPopulatedSingleStudentList(_setupData.StudentWithPassingScore)).First().Passed);
        }

        [Fact]
        public void ConvertStudents_TakesSingleFailingScoreStudentList_ReturnsPassedTrue()
        {
            Assert.False(_studentConverter.ConvertStudents(GetPopulatedSingleStudentList(_setupData.StudentWithFailingScore)).First().Passed);
        }

        [Fact]
        public void ConvertStudents_TakesEmptyList_ReturnsEmptyList()
        {
            Assert.Empty(_studentConverter.ConvertStudents(new List<Student>()));
        }

        [Fact]
        public void ConvertStudents_TakesNull_ThrowsError()
        {
            Assert.Throws<ArgumentNullException>(() => _studentConverter.ConvertStudents(null));
        }

        private List<Student> GetPopulatedSingleStudentList(Student student)
        {
            return new List<Student>() { student };
        }
    }
}