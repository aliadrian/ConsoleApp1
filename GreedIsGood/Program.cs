using System;
using System.Linq;


namespace GreedIsGood
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Score());
		}

		public static int occurance(int[] arr, int x)
		{
			int count = 0;
			foreach (int num in arr)
			{
				if (x == num)
				{
					count++;
				}
			}
			return count;
		}
		//Three 1's => 1000 points
		//Three 6's =>  600 points
		//Three 5's =>  500 points
		//Three 4's =>  400 points
		//Three 3's =>  300 points
		//Three 2's =>  200 points
		//One   1   =>  100 points
		//One   5   =>   50 point
		public static int Score()
		{
			int[] dice = new int[] { 1, 1, 1, 1, 3 };
			int result = 0;

			foreach (int i in dice.Distinct())
			{
				int count = occurance(dice, i);
				Console.WriteLine(i + " Occurred For: " + count);

				if (i == 1 && count >= 3)
				{
					result += 1000;
				}
				if (i == 1 && count == 4)
				{
					result = 1100;
				}
				if (result == 1300)
				{
					result = 1000;
				}
				else if (i == 6 && count == 3)
				{
					result += 600;
				}
				else if (i == 5 && count == 3)
				{
					result += 500;
				}
				else if (i == 4 && count == 3)
				{
					result += 400;
				}
				else if (i == 3 && count >= 3)
				{
					result += 300;
				}
				else if (i == 3 && count > 2)
				{
					result += 100 * count;
				}
				else if (i == 2 && count == 3)
				{
					result += 200;
				}
				//else if (i == 1 && count >= 2)
				//{
				//	result += 100 * count;
				//}
				else if (i == 1 && count == 1)
				{
					result += 100;
				}
				else if (i == 5 && count >= 1)
				{
					result += 50 * count;
				}
			}
			return result;
		}
	}
}