using Solutions;
using Xunit;

namespace Tests
{
    public class DayXTests
    {
        [Fact(Skip = "WIP")]
        public void Solve_Part_1()
        {
            var input = Input.Day(0);

            var result = DayX.Part1(input);

            Assert.Equal(42, result);
        }

        [Fact(Skip = "WIP")]
        public void Solve_Part_2()
        {
            var input = Input.Day(0);

            var result = DayX.Part2(input);

            Assert.Equal(42, result);
        }
    }
}