using coding_chanllenges.January;
using System;

namespace coding_challenges_tests.January
{
	public class Day1Tests
	{
        Day1 day1 = new Day1(); 

        [Fact]
        public void EasyBraketsBalanced()
        {
            var res = day1.IsBraketsSentenceBalanced("{}");
            Assert.True(res);
        }

        [Fact]
        public void EasyBraketsNotBalanced()
        {
            var res = day1.IsBraketsSentenceBalanced("}{");
            Assert.False(res);
        }

        [Fact]
        public void MediumBraketsBalanced()
        {
            var res = day1.IsBraketsSentenceBalanced("{{{}}{}}");
            Assert.True(res);
        }

        [Fact]
        public void MediumBraketsNotBalanced()
        {
            var res = day1.IsBraketsSentenceBalanced("{{{}}}}{");
            Assert.False(res);
        }

        [Fact]
        public void LongBraketsBalanced()
        {
            var res = day1.IsBraketsSentenceBalanced("{{{}}{}}{{}{{}}}");
            Assert.True(res);
        }

        [Fact]
        public void LongBraketsNotBalanced()
        {
            var res = day1.IsBraketsSentenceBalanced("{{{}}}}{}{}{}{}");
            Assert.False(res);
        }
    }
}

