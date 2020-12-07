using Solutions;
using Xunit;

namespace Tests
{
    public class Day3Tests
    {
        [Fact]
        public void Part1_Example_Yields_Correct_Result()
        {
            var input = new[]
            {
                "..##.......",
                "#...#...#..",
                ".#....#..#.",
                "..#.#...#.#",
                ".#...##..#.",
                "..#.##.....",
                ".#.#.#....#",
                ".#........#",
                "#.##...#...",
                "#...##....#",
                ".#..#...#.#",
                }.Joined();

            var result = Day3.Part1(input);

            Assert.Equal(7, result);
        }

        [Fact(Skip="WIP")]
        public void Part2_Example_Yields_Correct_Result()
        {
            var input = new[]
            {
                "..##.......",
                "#...#...#..",
                ".#....#..#.",
                "..#.#...#.#",
                ".#...##..#.",
                "..#.##.....",
                ".#.#.#....#",
                ".#........#",
                "#.##...#...",
                "#...##....#",
                ".#..#...#.#",
                }.Joined();

            var result = Day3.Part2(input);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void Solve_Part_1()
        {
            var input = Input.Day(3);

            var result = Day3.Part1(input);

            Assert.Equal(193, result);
        }

        [Fact(Skip = "WIP")]
        public void Solve_Part_2()
        {
            var input = Input.Day(3);

            var result = Day3.Part2(input);

            Assert.Equal(42, result);
        }
    }
}