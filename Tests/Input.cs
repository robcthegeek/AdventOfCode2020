using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Tests
{
    internal static class Input
    {
        public static string Day(int dayNumber) =>
            File.ReadAllText($"Input\\Day{dayNumber}.txt");

        public static IEnumerable<string> Lines(int dayNumber) =>
            Day(dayNumber).Split(Environment.NewLine);

        public static IEnumerable<int> Ints(int dayNumber) =>
            Day(dayNumber).Split(Environment.NewLine).Select(int.Parse);

        public static string Joined(this IEnumerable<string> values) => string.Join(Environment.NewLine, values);
    }
}