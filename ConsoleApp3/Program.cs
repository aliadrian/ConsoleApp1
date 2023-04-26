namespace ConsoleApp3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(ToCamelCase("the-stealth-warrior"));
		}

		public static string ToCamelCase(string str)
		{
			string[] words = str.Split('_', '-');
			string camelCaseString = words[0].ToLower();
			for (int i = 1; i < words.Length; i++)
			{
				camelCaseString += char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
			}
			return camelCaseString;
		}
	}
}