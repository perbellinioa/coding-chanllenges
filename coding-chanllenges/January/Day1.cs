using System;
namespace coding_chanllenges.January
{
	public class Day1
	{
		// Is brakets sentence balanced?
		public bool IsBraketsSentenceBalanced(string str)
		{
			if (str.Trim().Length < 1)
			{
				return true;
			}
			var sum = 0;
			foreach (char c in str)
			{
				if (sum < 0)
				{
					return false;
				}
				if(c == '{')
				{
					sum += 1;
				}
				else
				{
					sum -= 1;
				}

			}
			return sum == 0;
		}
	}
}

