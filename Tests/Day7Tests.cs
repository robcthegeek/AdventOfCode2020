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