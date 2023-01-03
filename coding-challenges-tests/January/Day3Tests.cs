using System;
using coding_chanllenges.January;

namespace coding_challenges_tests.January
{
	public class Day3Tests
	{
        Day3 day3 = new Day3();

        [Fact]
        public void StringEmpty()
        {
            var res = day3.ReversePolishNotation(new List<string>());
            Assert.Equal(0, res);
        }

        [Fact]
        public void StringInvalideRPN()
        {
            Action testCode = () => day3.ReversePolishNotation(new List<string> { "12" } );
            var exp = Assert.Throws<ArgumentException>(testCode);
            Assert.Equal("list (Parameter 'Not a valid reverse polish notation: 12')", exp.Message);
        }

        [Fact]
        public void StringInvalideValueRPN()
        {
            Action testCode = () => day3.ReversePolishNotation(new List<string> { "12", "3", "a" });
            var exp = Assert.Throws<ArgumentException>(testCode);
            Assert.Equal("list (Parameter 'Not a valid reverse polish notation: 12,3,a')", exp.Message);
        }

        [Fact]
        public void EasyAddRPN()
        {
            var res = day3.ReversePolishNotation(new List<string> { "2", "3", "+" });
            Assert.Equal(5, res);
        }

        [Fact]
        public void EasySubstractRPN()
        {
            var res = day3.ReversePolishNotation(new List<string> { "2", "3", "-" });
            Assert.Equal(-1, res);
        }

        [Fact]
        public void EasyMultiplyRPN()
        {
            var res = day3.ReversePolishNotation(new List<string> { "2", "3", "*" });
            Assert.Equal(6, res);
        }

        [Fact]
        public void EasyDivideRPN()
        {
            var res = day3.ReversePolishNotation(new List<string> { "6", "3", "/" });
            Assert.Equal(2, res);
        }

        [Fact]
        public void MediumMultipleOperationRPN()
        {
            var res = day3.ReversePolishNotation(new List<string> { "2", "1", "+", "3", "*" });
            Assert.Equal(9, res);
        }

        [Fact]
        public void LongMultipleOperationRPN()
        {
            var res = day3.ReversePolishNotation(new List<string> { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" });
            Assert.Equal(22, res);
        }
    }
}

