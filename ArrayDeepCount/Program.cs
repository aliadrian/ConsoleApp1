using System.Linq;
using System.Reflection;

namespace ArrayDeepCount
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(DeepCount(new object[] { 1, 2, 3 }));
		}

		public static int DeepCount(object a)
		{
			int count = 0;

			foreach (Object item in a.GetType().GetProperties())
			{
				var Key = item.GetType().Name;

				Console.WriteLine($"{Key}");
			}

			for (int i = 0; i < a.GetType().GetProperties().Length; i++)
				//{
				//	Console.WriteLine(count[i]);
				//         }

				Console.WriteLine(count);


			return 0;
		}
	}
}