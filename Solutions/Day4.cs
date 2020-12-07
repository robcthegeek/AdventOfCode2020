using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Solutions
{
    public static class Day4
    {
        private static readonly Regex Field = new Regex(@"(?<field>\w+):(?<value>[#\w\d]+)");

        private static IEnumerable<string> GetFields(string passport) =>
            Field.Matches(passport).Select(x => x.Groups["field"].Value);
        private static IEnumerable<(string field, string value)> GetFieldsWithValues(string passport) =>
            Field.Matches(passport).Select(x => (x.Groups["field"].Value, x.Groups["value"].Value));

        private static string[] RequiredFields = new[] {"byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid"};
        private static bool HasRequiredFields(string passport) => !RequiredFields.Except(GetFields(passport)).Any();

        public static int Part1(string input) =>
            input
                .Split($"{Environment.NewLine}{Environment.NewLine}", StringSplitOptions.RemoveEmptyEntries)
                .Count(HasRequiredFields);

        public static readonly Dictionary<string, Func<string, bool>> Validators =
            new Dictionary<string, Func<string, bool>>
            {
                {
                    "byr", s =>
                    {
                        var parsed = int.TryParse(s, out var year);
                        return parsed && year >= 1920 && year <= 2002;
                    }
                },
                {
                    "iyr", s => {
                        var parsed = int.TryParse(s, out var year);
                        return parsed && year >= 2010 && year <= 2020;
                    }
                },
                {
                    "eyr", s => {
                        var parsed = int.TryParse(s, out var year);
                        return s.Length == 4 && parsed && year >= 2020 && year <= 2030;
                    }
                },
                {
                    "hgt", s =>
                    {
                        var match = Regex.Match(s, @"(?<measure>\d+)(?<unit>cm|in)");
                        if (!match.Success) return false;

                        var measure = int.Parse(match.Groups["measure"].Value);

                        if (match.Groups["unit"].Value == "cm")
                            return measure >= 150 && measure <= 193;

                        if (match.Groups["unit"].Value == "in")
                            return measure >= 59 && measure <= 76;

                        return false;
                    }
                },
                {
                    "hcl", s => Regex.IsMatch(s, @"#[0-9a-f]{6}") 
                },
                {
                    "ecl", s => Regex.IsMatch(s, @"(amb|blu|brn|gry|grn|hzl|oth)")
                },
                {
                    "pid", s => Regex.IsMatch(s, @"^\d{9}$")
                }
            };

        static bool FieldsValid(string passport) =>
            GetFieldsWithValues(passport)
                .Where(x => Validators.ContainsKey(x.field))
                .All(fwv => Validators[fwv.field](fwv.value));

        public static int Part2(string input) => input
                .Split($"{Environment.NewLine}{Environment.NewLine}", StringSplitOptions.RemoveEmptyEntries)
                .Count(p => HasRequiredFields(p) && FieldsValid(p));
    }
}