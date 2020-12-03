using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Solutions
{
    public static class Day2
    {
        private static readonly Regex Pattern = new Regex(@"^(?<min>\d+)-(?<max>\d+)\s(?<char>[a-z]):\s(?<pass>\w+)$");
        private static (int min, int max, char @char, string pass) Parse(string s)
        {
            var m = Pattern.Match(s);
            return (
                int.Parse(m.Groups["min"].Value),
                int.Parse(m.Groups["max"].Value),
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
            return -1;
        }
    }
}