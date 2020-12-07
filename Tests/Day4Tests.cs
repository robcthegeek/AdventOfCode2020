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

        [Fact]
        public void Part2__Invalid_Examples_Yields_Correct_Result()
        {
            var input = new[]
            {
                "eyr:1972 cid:100",
                "hcl:#18171d ecl:amb hgt:170 pid:186cm iyr:2018 byr:1926",
                "",
                "iyr:2019",
                "hcl:#602927 eyr:1967 hgt:170cm",
                "ecl:grn pid:012533040 byr:1946",
                "",
                "hcl:dab227 iyr:2012",
                "ecl:brn hgt:182cm pid:021572410 eyr:2020 byr:1992 cid:277",
                "",
                "hgt:59cm ecl:zzz",
                "eyr:2038 hcl:74454a iyr:2023",
                "pid:3556412378 byr:2007",
            }.Joined();
            
            Assert.Equal(0, Day4.Part2(input));
        }

        [Fact]
        public void Part2__Valid_Examples_Yields_Correct_Result()
        {
            var input = new[]
            {
                "pid:087499704 hgt:74in ecl:grn iyr:2012 eyr:2030 byr:1980",
                "hcl:#623a2f",
                "",
                "eyr:2029 ecl:blu cid:129 byr:1989",
                "iyr:2014 pid:896056539 hcl:#a97842 hgt:165cm",
                "",
                "hcl:#888785",
                "hgt:164cm byr:2001 iyr:2015 cid:88",
                "pid:545766238 ecl:hzl",
                "eyr:2022",
                "",
                "iyr:2010 hgt:158cm hcl:#b6652a ecl:blu byr:1944 eyr:2021 pid:093154719",
            }.Joined();

            Assert.Equal(4, Day4.Part2(input));
        }

        [Fact]
        public void Solve_Part_1()
        {
            var input = Input.Day(4);

            var result = Day4.Part1(input);

            Assert.Equal(242, result);
        }

        [Theory]
        [InlineData("byr", "2002", true)]
        [InlineData("byr", "2003", false)]
        [InlineData("hgt", "60in", true)]
        [InlineData("hgt", "190cm", true)]
        [InlineData("hgt", "190in", false)]
        [InlineData("hgt", "190", false)]
        [InlineData("hcl", "#123abc", true)]
        [InlineData("hcl", "#123abz", false)]
        [InlineData("hcl", "123abc", false)]
        [InlineData("ecl", "brn", true)]
        [InlineData("ecl", "wat", false)]
        [InlineData("pid", "000000001", true)]
        [InlineData("pid", "0123456789", false)]
        public void Example_Rules_Validate_Correctly(string field, string value, bool expected)
        {
            Assert.Equal(expected, Day4.Validators[field](value));
        }

        [Fact]
        public void Solve_Part_2()
        {
            var input = Input.Day(4);

            var result = Day4.Part2(input);

            Assert.Equal(186, result);
        }
    }
}