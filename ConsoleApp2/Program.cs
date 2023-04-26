using System.Text.RegularExpressions;

namespace ConsoleApp2
{
	public class WeightSort
	{
		static void Main(string[] args)
		{
			Console.WriteLine(SumOfIntegersInString("The Great Depression lasted from 1929 to 1939."));
		}
		public static int SumOfIntegersInString(string s)
		{
			int sum = 0;
			string currentNumber = "";

			foreach (char c in s)
			{
				if (Char.IsDigit(c))
				{
					currentNumber += c;
				}
				else
				{
					if (currentNumber != "")
					{
						sum += int.Parse(currentNumber);
						currentNumber = "";
					}
				}
			}

			if (currentNumber != "")
			{
				sum += int.Parse(currentNumber);
			}

			return sum;
		}
	}
}