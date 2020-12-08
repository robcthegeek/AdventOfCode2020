using Solutions;
using Xunit;

namespace Tests
{
    public class Day7Tests
    {
        [Fact]
        public void Can_Parse_Bag_Rule()
        {
            var rule = new BagRule("light red bags contain 1 bright white bag, 2 muted yellow bags.");

            Assert.Equal("light red", rule.BagColor);
            Assert.Contains(new ("bright white", 1), rule.Quantities);
            Assert.Contains(new ("muted yellow", 2), rule.Quantities);
        }

        [Fact]
        public void Can_Parse_Empty_Bag_Rule()
        {
            var rule = new BagRule("bright turquoise bags contain no other bags.");

            Assert.Equal("bright turquoise", rule.BagColor);
            Assert.Empty(rule.Quantities);
        }

        [Fact]
        public void Example_Returns_Correct_Result()
        {
            var input = new[]
            {
                "light red bags contain 1 bright white bag, 2 muted yellow bags.",
                "dark orange bags contain 3 bright white bags, 4 muted yellow bags.",
                "bright white bags contain 1 shiny gold bag.",
                "muted yellow bags contain 2 shiny gold bags, 9 faded blue bags.",
                "shiny gold bags contain 1 dark olive bag, 2 vibrant plum bags.",
                "dark olive bags contain 3 faded blue bags, 4 dotted black bags.",
                "vibrant plum bags contain 5 faded blue bags, 6 dotted black bags.",
                "faded blue bags contain no other bags.",
                "dotted black bags contain no other bags."
            }.Joined();

            var result = Day7.Part1(input);

            Assert.Equal(4, result);
        }

        [Fact(Skip = "WIP")]
        public void Solve_Part_1()
        {
            var input = Input.Day(7);

            var result = Day7.Part1(input);

            Assert.Equal(42, result);
        }

        [Fact(Skip = "WIP")]
        public void Solve_Part_2()
        {
            var input = Input.Day(7);

            var result = Day7.Part2(input);

            Assert.Equal(42, result);
        }
    }
}