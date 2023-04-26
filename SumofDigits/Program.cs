using System.Security.Cryptography.X509Certificates;
using System;
using System.Numerics;
using System.Linq;
using System.Text.RegularExpressions;

namespace SumofDigits
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(DigitalRoot(999999999999));
		}

		public static int DigitalRoot(long n)
		{
			string s = n.ToString();
			int sum = 0;
			foreach (char c in s)
			{
				int x = c - '0';
				sum += x;
			}

			sum.ToString();

			int newSum;
			if (sum.ToString().Length >= 2)
			{
				newSum = DigitalRoot(sum);
			}
			else
			{
				return sum;
			}

			return newSum;
		}
	}
}