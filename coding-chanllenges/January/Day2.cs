using System;
namespace coding_chanllenges.January
{
	public class Day2
	{
		// Run-Length encoding data compression method
		public List<(char, int)> RunLengthEncoding(string str)
		{
            if ( str.Length < 1)
			{
				return new List<(char, int)>();
            }
			else if ( str.Length == 1)
			{
                return new List<(char, int)> { (str[0], 1) };
            }
			else
			{
				return Encode(str.Substring(1), new List<(char, int)>(), str[0], 1);
			}
			
		}

		private static List<(char, int)> Encode(string str, List<(char, int)> l, char prev, int count)
		{
			if (str.Length == 1)
			{
				if (str[0] == prev)
				{
					l.Add((prev, count + 1));
				} else
				{
					l.Add((prev, count));
					l.Add((str[0], 1));
				}
            }
			else
			{
				if (str[0] == prev)
				{
					Encode(str.Substring(1), l, prev, count + 1);
				}
				else
				{
                    l.Add((prev, count));
                    Encode(str.Substring(1), l, str[0], 1);
                }
			}
			return l;
		}

    }
}

