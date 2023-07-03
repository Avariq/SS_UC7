using UC7.BL;
using Xunit;

namespace UC7.Tests
{
    public class StudentConverterTests : IClassFixture<TestsFixture>
    {
        TestsFixture SetupData;
        StudentConverter StudentConverter = new StudentConverter();

        public StudentConverterTests(TestsFixture setupData)
        {
            SetupData = setupData;
        }

        [Fact]
        public void ConvertStudents_TakesSinglePerfectScoreStudentAged21PlusList_ReturnsHonorRollTrue()
        {
            Assert.True(StudentConverter.ConvertStudents(GetPopulatedSingleStudentList(SetupData.StudentOver21PerfectScore)).First().HonorRoll);
        }

        [Fact]
        public void ConvertStudents_TakesSinglePerfectScoreStudentAgedLessThan21List_ReturnsExceptionalTrue()
        {
            Assert.True(StudentConverter.ConvertStudents(GetPopulatedSingleStudentList(SetupData.StudentLessThan21PerfectScore)).First().Exceptional);
        }

        [Fact]
        public void ConvertStudents_TakesSinglePassingScoreStudentList_ReturnsPassedTrue()
        {
            Assert.True(StudentConverter.ConvertStudents(GetPopulatedSingleStudentList(SetupData.StudentWithPassingScore)).First().Passed);
        }

        [Fact]
        public void ConvertStudents_TakesSingleFailingScoreStudentList_ReturnsPassedTrue()
        {
            Assert.False(StudentConverter.ConvertStudents(GetPopulatedSingleStudentList(SetupData.StudentWithFailingScore)).First().Passed);
        }

        [Fact]
        public void ConvertStudents_TakesEmptyList_ReturnsEmptyList()
        {
            Assert.Empty(StudentConverter.ConvertStudents(new List<Student>()));
        }

        [Fact]
        public void ConvertStudents_TakesNull_ThrowsError()
        {
            Assert.Throws<ArgumentNullException>(() => StudentConverter.ConvertStudents(null));
        }

        private List<Student> GetPopulatedSingleStudentList(Student student)
        {
            return new List<Student>() { student };
        }
    }
}