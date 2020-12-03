using System;
using Solutions;
using Xunit;

namespace Tests
{
    public class Day1Tests
    {
        [Fact]
        public void Example_Yields_Correct_Result()
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

            var result = Day1.Solve(input);

            Assert.Equal(514579, result);
        }

        [Fact]
        public void Solve_Part_1()
        {
            var input = Input.Day(1);

            var result = Day1.Solve(input);

            Assert.Equal(1016131, result);
        }
    }
}
