using System;
using System.Collections;
using System.Collections.Generic;
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

        public static ulong Part2(string input, IEnumerable<(int slopeX, int slopeY)> slopes) => slopes
                .Select(slope => CountTrees(input, slope.slopeX, slope.slopeY))
                .Aggregate(1UL, (x, y) => x * y);

        private static uint CountTrees(string map, int slopeX, int slopeY)
        {
            var lines = map.Split(Environment.NewLine);
            var lineLen = lines[0].Length;
            uint count = 0;
            for (var y = slopeY; y < lines.Length; y+=slopeY)
            {
                var x = ((y/slopeY) * slopeX);
                x -= ((x / lineLen) * lineLen); // Shift if off edge of map
                if (lines[y][x] == '#') count++;
            }

            return count;
        }
    }
}