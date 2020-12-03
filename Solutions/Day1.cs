using System;
using System.Linq;

namespace Solutions
{
    public static class Day1
    {
        public static int Part1(string input)
        {
            var ints = input
                .Split(Environment.NewLine)
                .Select(int.Parse)
                .ToArray();
            
            foreach (var a in ints.Where(a => a <= 2020))
                foreach (var b in ints)
                    if (a + b == 2020) return a * b;

            throw new Exception("Couldn't find it!");
        }

        public static int Part2(string input)
        {
            var ints = input
                .Split(Environment.NewLine)
                .Select(int.Parse)
                .ToArray();

            foreach (var a in ints.Where(a => a <= 2020))
                foreach (var b in ints.Where(b => a + b <= 2020))
                    foreach (var c in ints)
                        if (a + b + c == 2020) return a * b * c;

            throw new Exception("Couldn't find it!");
        }
    }
}
