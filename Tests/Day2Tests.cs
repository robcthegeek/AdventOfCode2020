using Solutions;
using Xunit;

namespace Tests
{
    public class Day2Tests
    {
        [Fact]
        public void Part1_Example_Yields_Correct_Result()
        {
            var input = new[]
            {
                "1-3 a: abcde",
                "1-3 b: cdefg",
                "2-9 c: ccccccccc"
                }.Joined();

            var result = Day2.Part1(input);

            Assert.Equal(2, result);
        }

        [Fact(Skip = "WIP")]
        public void Part2_Example_Yields_Correct_Result()
        {
            var input = new[]
            {
                "1-3 a: abcde",
                "1-3 b: cdefg",
                "2-9 c: ccccccccc",
                }.Joined();

            var result = Day2.Part2(input);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void Solve_Part_1()
        {
            var input = Input.Day(2);

            var result = Day2.Part1(input);

            Assert.Equal(645, result);
        }

        [Fact(Skip = "WIP")]
        public void Solve_Part_2()
        {
            var input = Input.Day(2);

            var result = Day2.Part2(input);

            Assert.Equal(276432018, result);
        }
    }
}