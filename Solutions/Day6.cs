using System;
using System.Linq;
using System.Collections.Generic;

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

        public static int Part2(string input) => -1;

    }
}