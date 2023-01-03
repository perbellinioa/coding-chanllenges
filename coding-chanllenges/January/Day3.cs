using System;
namespace coding_chanllenges.January
{
	public class Day3
	{
		private static string sign = "+-*/";

        public int ReversePolishNotation(List<string> list)
		{
			if ( list.Count == 0 )
			{
				return 0;
			}

			if ( !Validate(list) )
			{
				throw new ArgumentException(nameof(list), $"Not a valid reverse polish notation: {string.Join(',', list)}");
			}

			var stack = new Stack<int>();
			foreach (string str in list)
			{
				if (sign.Contains(str))
				{
					var tmp = str switch
					{
						"+" => Add(stack.Pop(), stack.Pop()),
						"-" => Substract(stack.Pop(), stack.Pop()),
						"*" => Multiply(stack.Pop(), stack.Pop()),
						"/" => Divide(stack.Pop(), stack.Pop()),
						_ => throw new ArgumentOutOfRangeException(nameof(str), $"Not expected direction value: {str}"),
					};
					stack.Push(tmp);
					continue;
				}
				stack.Push(int.Parse(str));
			}
			return stack.Pop();
		}

		private static bool Validate(List<string> list)
		{
			if ( list.Count >= 3 && list.Count % 2 == 1)
			{
				var countNumber = 0;
				var countSign = 0;
				foreach(string str in list)
				{
					if ( sign.Contains(str) )
					{
						countSign += 1;
						continue;
					}
					else if (int.TryParse(str, out _))
					{
                        countNumber += 1;
						continue;
                    }
					else
					{
						return false;
					}
				}
				return countNumber == countSign + 1;
			}
			return false;
		}

		private static int Add(int a, int b)
		{
			return b + a;
		}

        private static int Substract(int a, int b)
        {
            return b - a;
        }

        private static int Multiply(int a, int b)
        {
            return b * a;
        }

        private static int Divide(int a, int b)
        {
            return b / a;
        }
    }
}

