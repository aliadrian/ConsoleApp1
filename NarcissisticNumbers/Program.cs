using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace NarcissisticNumbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(IsNarcissistic(11513221922401));
		}

		//Ex: 153, where l = 3(the number of digits in 153)
		//1^3 + 5^3 + 3^3 = 153

		public static bool IsNarcissistic(long n)
		{
			double sum = 0;

			foreach (var i in n.ToString())
			{
				// This three lines of code is the same as the one line below
				//string s = i.ToString();
				//z = Convert.ToDouble(s);
				//sum += Math.Pow(z, x);

				sum += Math.Pow(Convert.ToDouble(i.ToString()), n.ToString().Length);
			}

			if (n == sum)
				return true;
			else
				return false;
		}
	}
}