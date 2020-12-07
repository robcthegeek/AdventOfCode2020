using System;
using System.Linq;

namespace Solutions
{
    public static class Day3
    {
        public static int Part1(string input)
        {
            var lines = input.Split(Environment.NewLine);
            var lineLen = lines[0].Length;

            return Enumerable.Range(0, lines.Length).Count(lineNum =>
            {
                var x = (lineNum * 3);
                x -= ((x / lineLen) * lineLen); // Shift if off edge of map
                return lines[lineNum][x] == '#';
            });
        }

        public static int Part2(string input)
        {
            return -1;
        }
    }
}