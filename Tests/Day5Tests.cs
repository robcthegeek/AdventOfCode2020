using Solutions;
using Xunit;

namespace Tests
{
    public class Day5Tests
    {
        [Theory]
        [InlineData("FBFBBFFRLR", 44, 5, 357)]
        public void Examples_Return_Expected(string code, int row, int col, int id)
        {
            var pass = new BoardingPass(code);

            Assert.Equal(row, pass.Row);
            Assert.Equal(col, pass.Col);
            Assert.Equal(id, pass.ID);
        }

        [Fact]
        public void Solve_Part_1()
        {
            var input = Input.Day(5);

            var result = Day5.Part1(input);

            Assert.Equal(904, result);
        }

        [Fact(Skip = "WIP")]
        public void Solve_Part_2()
        {
            var input = Input.Day(5);

            var result = Day5.Part2(input);

            Assert.Equal(42, result);
        }
    }
}