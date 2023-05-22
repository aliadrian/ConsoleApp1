using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace NumberFormat
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(NumberFormat(-100000));
		}

		public static string NumberFormat(int number)
		{
			return Regex.Replace(number.ToString(), "(\\d)(?=(\\d{3})+$)", "$1,");
		}
	}
}