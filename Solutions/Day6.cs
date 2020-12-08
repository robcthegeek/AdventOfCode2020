using System;
using System.Linq;

namespace Solutions
{
    public static class Day6
    {
        public static int Part1(string input) => input
                .Split($"{Environment.NewLine}{Environment.NewLine}", StringSplitOptions.RemoveEmptyEntries)
                .Sum(group => group
                        .Split(Environment.NewLine)
                        .SelectMany(s => s.ToCharArray().Distinct())
                        .GroupBy(q => q)
                        .Count()
                );

        public static int Part2(string input)
        {
            var count = input
                .Split($"{Environment.NewLine}{Environment.NewLine}", StringSplitOptions.RemoveEmptyEntries)
                .Sum(group =>
                {
                    var people = group.Split(Environment.NewLine);
                    return people
                        .SelectMany(s => s.ToCharArray().Distinct())
                        .GroupBy(q => q)
                        .Select(g => new { g.Key, Count = g.Count() })
                        .Where(g => g.Count == people.Length)
                        .Count();
                });

            return count;
        }
    }
}