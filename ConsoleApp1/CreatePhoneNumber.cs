using System;

namespace CreatePhoneNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
			Console.WriteLine(CreatePhoneNumber(numbers));
		}

		static string CreatePhoneNumber(int[] numbers)
		{
			var a = numbers[0];
			var b = numbers[1];
			var c = numbers[2];
			var d = numbers[3];
			var f = numbers[4];
			var g = numbers[5];
			var h = numbers[6];
			var i = numbers[7];
			var j = numbers[8];
			var k = numbers[9];

			string phoneNumber = $"({a}{b}{c}) {d}{f}{g}-{h}{i}{j}{k}";

			return phoneNumber;
		}
	}
}
