using UC7.BL;

namespace UC7.Tests
{
    public class TestsFixture : IDisposable
    {
        public Student StudentOver21PerfectScore;
        public Student StudentLessThan21PerfectScore;
        public Student StudentWithPassingScore;
        public Student StudentWithFailingScore;

        public TestsFixture()
        {
            StudentOver21PerfectScore = new Student()
            {
                Age = 22,
                Grade = 94,
                Name = "Darth Vader"
            };

            StudentLessThan21PerfectScore = new Student()
            {
                Age = 19,
                Grade = 94,
                Name = "Darth Revan"
            };

            StudentWithPassingScore = new Student()
            {
                Age = 19,
                Grade = 76,
                Name = "Anakin Skywalker"
            };

            StudentWithFailingScore = new Student()
            {
                Age = 19,
                Grade = 56,
                Name = "Count Dooku"
            };
        }

        public void Dispose()
        {
            // Do "global" teardown here; Only called once.
        }
    }
}
