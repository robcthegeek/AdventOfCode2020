using System;
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

        [Fact]
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

            var result = Day3.Part2(input, new []
            {
                (1, 1),
                (3, 1),
                (5, 1),
                (7, 1),
                (1, 2)
            });

            Assert.Equal(336UL, result);
        }

        [Fact]
        public void Solve_Part_1()
        {
            var input = Input.Day(3);

            var result = Day3.Part1(input);

            Assert.Equal(193, result);
        }

        [Fact]
        public void Solve_Part_2()
        {
            var input = Input.Day(3);

            var result = Day3.Part2(input, new[]
            {
                (1, 1),
                (3, 1),
                (5, 1),
                (7, 1),
                (1, 2)
            });

            Assert.Equal(1355323200UL, result);
        }
    }
}