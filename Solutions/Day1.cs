using System;
using System.Linq;

namespace Solutions
{
    public static class Day1
    {
        public static int Solve(string input)
        {
            var ints = input
                .Split(Environment.NewLine)
                .Select(int.Parse)
                .ToArray();
            
            foreach (var a in ints)
                foreach (var b in ints)
                    if (a + b == 2020) return a * b;

            throw new Exception("Couldn't find it!");
        }
    }
}
