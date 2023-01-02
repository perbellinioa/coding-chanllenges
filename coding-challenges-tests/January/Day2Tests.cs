using coding_chanllenges.January;
using Xunit;
using Xunit.Abstractions;

namespace coding_challenges_tests.January
{
	public class Day2Tests
	{
        private Day2 day2 = new Day2();
        private readonly ITestOutputHelper output;

        public Day2Tests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void StringEmptyEncoding()
        {
            var res = day2.RunLengthEncoding("");
            Assert.Empty(res);
        }

        [Fact]
        public void EasyEncoding()
        {
            var res = day2.RunLengthEncoding("a");
            Assert.Collection(res,
                item => Assert.Equal(('a', 1), item));
        }

        [Fact]
        public void Easy2Encoding()
        {
            var res = day2.RunLengthEncoding("abc");
            Assert.Collection(res,
                item => Assert.Equal(('a', 1), item),
                item => Assert.Equal(('b', 1), item),
                item => Assert.Equal(('c', 1), item));
        }

        [Fact]
        public void Easy3Encoding()
        {
            var res = day2.RunLengthEncoding("aaa");
            Assert.Collection(res,
                item => Assert.Equal(('a', 3), item));
        }

        [Fact]
        public void MediumEncoding()
        {
            var res = day2.RunLengthEncoding("abbbcaadddeee");
            Assert.Collection(res,
                item => Assert.Equal(('a', 1), item),
                item => Assert.Equal(('b', 3), item),
                item => Assert.Equal(('c', 1), item),
                item => Assert.Equal(('a', 2), item),
                item => Assert.Equal(('d', 3), item),
                item => Assert.Equal(('e', 3), item));
        }

        [Fact]
        public void LongEncoding()
        {
            var res = day2.RunLengthEncoding("aaaabbbcaadddddeeeeeeee");
            Assert.Collection(res,
                item => Assert.Equal(('a', 4), item),
                item => Assert.Equal(('b', 3), item),
                item => Assert.Equal(('c', 1), item),
                item => Assert.Equal(('a', 2), item),
                item => Assert.Equal(('d', 5), item),
                item => Assert.Equal(('e', 8), item));
        }

    }
}

