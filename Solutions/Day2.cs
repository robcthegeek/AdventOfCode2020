using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Solutions
{
    public static class Day2
    {
        private static readonly Regex Pattern = new Regex(@"^(?<p1>\d+)-(?<p2>\d+)\s(?<char>[a-z]):\s(?<pass>\w+)$");
        private static (int p1, int p2, char @char, string pass) Parse(string s)
        {
            var m = Pattern.Match(s);
            return (
                int.Parse(m.Groups["p1"].Value),
                int.Parse(m.Groups["p2"].Value),
                m.Groups["char"].Value[0],
                m.Groups["pass"].Value
            );
        }

        public static int Part1(string input)
        {
            bool IsValid(string s)
            {
                var (min, max, @char, pass) = Parse(s);
                var count = pass.ToCharArray().Count(x => x == @char);
                return count >= min && count <= max;
            }

            return input
                .Split(Environment.NewLine)
                .Count(IsValid);
        }

        public static int Part2(string input)
        {
            bool IsValid(string s)
            {
                var (idx1, idx2, @char, pass) = Parse(s);
                var chars = pass.ToCharArray();
                var values = new[] {chars[idx1 - 1], chars[idx2 - 1]}; // Toboggan Corporate Don't Do Index Zero!
                return values.Count(c => c == @char) == 1;
            }

            return input
                .Split(Environment.NewLine)
                .Count(IsValid);
        }
    }
}