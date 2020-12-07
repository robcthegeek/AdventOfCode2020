using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Solutions
{
    public static class Day4
    {
        private static readonly Regex Field = new Regex(@"(?<field>\w+):");
        private static IEnumerable<string> GetFields(string passport) => Field.Matches(passport).Select(x => x.Groups["field"].Value);
        private static string[] RequiredFields = new[] {"byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid"};
        private static bool IsValid(string passport) => !RequiredFields.Except(GetFields(passport)).Any();

        public static int Part1(string input) =>
            input
                .Split($"{Environment.NewLine}{Environment.NewLine}", StringSplitOptions.RemoveEmptyEntries)
                .Count(IsValid);

        public static int Part2(string input) => -1;
    }
}