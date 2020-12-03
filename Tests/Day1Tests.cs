using System;
using Solutions;
using Xunit;

namespace Tests
{
    public class Day1Tests
    {
        [Fact]
        public void Part1_Example_Yields_Correct_Result()
        {
            var input = new []
            {
                "1721",
                "979",
                "366",
                "299",
                "675",
                "1456",
            }.Joined();

            var result = Day1.Part1(input);

            Assert.Equal(514579, result);
        }

        [Fact]
        public void Part2_Example_Yields_Correct_Result()
        {
            var input = new[]
            {
                "1721",
                "979",
                "366",
                "299",
                "675",
                "1456",
            }.Joined();

            var result = Day1.Part2(input);

            Assert.Equal(241861950, result);
        }

        [Fact]
        public void Solve_Part_1()
        {
            var input = Input.Day(1);

            var result = Day1.Part1(input);

            Assert.Equal(1016131, result);
        }

        [Fact]
        public void Solve_Part_2()
        {
            var input = Input.Day(1);

            var result = Day1.Part2(input);

            Assert.Equal(276432018, result);
        }
    }
}
