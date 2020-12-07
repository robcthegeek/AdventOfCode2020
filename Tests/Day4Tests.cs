using Solutions;
using Xunit;

namespace Tests
{
    public class Day4Tests
    {
        [Fact]
        public void Part1_Example_Yields_Correct_Result()
        {
            var input = new[]
            {"ecl:gry pid:860033327 eyr:2020 hcl:#fffffd",
                "byr:1937 iyr:2017 cid:147 hgt:183cm",
                "",
                "iyr:2013 ecl:amb cid:350 eyr:2023 pid:028048884",
                "hcl:#cfa07d byr:1929",
                "",
                "hcl:#ae17e1 iyr:2013",
                "eyr:2024",
                "ecl:brn pid:760753108 byr:1931",
                "hgt:179cm",
                "",
                "hcl:#cfa07d eyr:2025 pid:166559648",
                "iyr:2011 ecl:brn hgt:59in",
                }.Joined();

            var result = Day4.Part1(input);

            Assert.Equal(2, result);
        }

        [Fact(Skip = "WIP")]
        public void Part2_Example_Yields_Correct_Result()
        {
            var input = new[]
            {
                "ecl:gry pid:860033327 eyr:2020 hcl:#fffffd",
                "byr:1937 iyr:2017 cid:147 hgt:183cm",
                "",
                "iyr:2013 ecl:amb cid:350 eyr:2023 pid:028048884",
                "hcl:#cfa07d byr:1929",
                "",
                "hcl:#ae17e1 iyr:2013",
                "eyr:2024",
                "ecl:brn pid:760753108 byr:1931",
                "hgt:179cm",
                "",
                "hcl:#cfa07d eyr:2025 pid:166559648",
                "iyr:2011 ecl:brn hgt:59in",
                }.Joined();

            var result = Day4.Part2(input);

            Assert.Equal(42, result);
        }

        [Fact]
        public void Solve_Part_1()
        {
            var input = Input.Day(4);

            var result = Day4.Part1(input);

            Assert.Equal(242, result);
        }

        [Fact(Skip = "WIP")]
        public void Solve_Part_2()
        {
            var input = Input.Day(4);

            var result = Day4.Part2(input);

            Assert.Equal(42, result);
        }
    }
}