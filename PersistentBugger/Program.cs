namespace PersistentBugger
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Persistence(25));
		}

		public static int Persistence(long n)
		{
			int counter = 0;
			while (n.ToString().Length > 1)
			{
				long r = 1;
				foreach (char c in n.ToString())
				{
					int x = c - '0';
					r *= x;
				}
				n = r;
				counter++;
			}
			return counter;
		}
	}
}