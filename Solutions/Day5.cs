using System;
using System.Linq;

namespace Solutions
{
    public static class Day5
    {
        public static int Part1(string input) => input.Split(Environment.NewLine)
            .Select(x => new BoardingPass(x).ID)
            .Max();

        public static int Part2(string input)
        {
            var allIds = input.Split(Environment.NewLine)
                .Select(x => new BoardingPass(x).ID)
                .ToArray();

            var missing = Enumerable.Range(allIds.Min(), allIds.Max())
                .Except(allIds)
                .OrderBy(x => x);

            foreach (var seat in missing)
            {
                if (allIds.Contains(seat - 1) && allIds.Contains(seat + 1))
                    return seat;
            }

            return -1;
        }
    }

    public record BoardingPass
    {
        public int Row { get; private set; }
        public int Col { get; private set; }
        public int ID { get; private set; }

        static readonly (Range code, Range seats, char upper) Rows = (0..7, new Range(0, 127), 'F');
        static readonly (Range code, Range seats, char upper) Cols = (^3..^0, new Range(0, 7), 'L');

        public BoardingPass(string code)
        {
            var chars = code.ToCharArray();

            Row = Find(Rows, chars);
            Col = Find(Cols, chars);
            ID = Row * 8 + Col;
        }

        private int Find((Range code, Range seats, char upper) search, char[] chars) => chars[search.code]
            .Aggregate(search.seats, (curr, chop) => Chop(curr, chop, search.upper))
            .Start.Value;

        private Range Chop(Range current, char half, char upper)
        {
            var mid = (current.End.Value - current.Start.Value) / 2;

            return half == upper
                ? new Range(current.Start.Value, current.Start.Value + mid)
                : new Range(current.Start.Value + mid + 1, current.End.Value);
        }
    }
}