using System;

namespace FindTheMissingLetter
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write(FindMissingLetter(new[] { 'a', 'b', 'c', 'd', 'f' }));
		}
		public static char FindMissingLetter(char[] array)
		{
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] - array[i - 1] != 1)
					return (char)((int)array[i] - 1);
			}

			throw new Exception("No return value");
		}
	}
}