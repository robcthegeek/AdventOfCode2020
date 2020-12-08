using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Solutions
{
    public static class Day7
    {
        public static int Part1(string input)
        {
            var queue = new Queue<string>();

            var rules = input
                .Split(Environment.NewLine)
                .Select(s => {
                    var r = new BagRule(s);
                    if (r.Quantities.Any(x => x.BagColor == "shiny gold"))
                        queue.Enqueue(r.BagColor);
                    return r;
                })
                .ToDictionary(rule => rule.BagColor);

            Console.Error.WriteLine($"{string.Join(", ", queue)}");

            var count = 0;
            while (queue.Count > 0)
            {
                // find anything that contains this bag, add to the queue.
                var current = queue.Dequeue();
                rules
                    .Where(rule => rule.Value.Quantities.Any(qty => qty.BagColor == current))
                    .Select(x => x.Key)
                    .ToList()
                    .ForEach(queue.Enqueue);

                count++;
            }

            // keep track of all those that ahve "shiny gold bags" - we'll need these later.

            // create list of bags that contain shiny gold bags

            // ... recurse until no more container bags

            return count;
        }

        public static int Part2(string input) => -1;

    }

    public record BagRule
    {
        private readonly Regex Rule = new Regex(@"^(?<color>[\w\d\s]+) bags contain (?<contents>[\d\w\s,]+)\.$");
        private readonly Regex Contents = new Regex(@"(?<qty>\d+)\s(?<col>[\w\s]+) bags?");

        public string BagColor { get; }
        public BagQuantity[] Quantities { get; }

        public BagRule(string rule)
        {
            var parsedRule = Rule.Match(rule);
            BagColor = parsedRule.Groups["color"].Value;

            var quantities = new List<BagQuantity>();
            var contentRules = Contents.Matches(rule);

            foreach (Match match in contentRules)
            {
                if (match.Groups["col"].Value == "no other bags") break;

                quantities.Add(new(
                    match.Groups["col"].Value,
                    int.Parse(match.Groups["qty"].Value)
                    ));
            }

            Quantities = quantities.ToArray();
        }
    }

    public record BagQuantity(string BagColor, int Count);
}