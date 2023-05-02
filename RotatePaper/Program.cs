namespace RotatePaper
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(RotatePaper("56789"));
		}

		//public static void Check()
		//{
		//	RotatePaper()
		//}

		public static bool RotatePaper(string number)
		{
			for (int j = 0; j < number.Length; j++)
			{
				if (number.Contains("1") || number.Contains("3") || number.Contains("4") || number.Contains("5") || number.Contains("7"))
				{
					return false;
				}
				else
				{
					return true;
				}
			}

			return true;
		}
	}
}