using Solutions;
using Xunit;

namespace Tests
{
    public class Day6Tests
    {
        [Fact]
        public void Example_Returns_Expected_Result()
        {
            var input = new[] {
                "abc",
                "",
                "a",
                "b",
                "c",
                "",
                "ab",
                "ac",
                "",
                "a",
                "a",
                "a",
                "a",
                "",
                "b"
            }.Joined();

            var result = Day6.Part1(input);

            Assert.Equal(11, result);
        }

        [Fact]
        public void Solve_Part_1()
        {
            var input = Input.Day(6);

            var result = Day6.Part1(input);

            Assert.Equal(6662, result);
        }

        [Fact(Skip = "WIP")]
        public void Solve_Part_2()
        {
            var input = Input.Day(6);

            var result = Day6.Part2(input);

            Assert.Equal(42, result);
        }
    }
}