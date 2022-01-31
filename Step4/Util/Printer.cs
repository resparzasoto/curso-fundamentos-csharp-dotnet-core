using static System.Console;

namespace CoreSchool.Util
{
	public class Printer
	{
		public static void DrawLine(int length = 10)
		{
			WriteLine("".PadLeft(length, '='));
		}

		public static void WriteTitle(string title)
		{
			int size = title.Length + 4;

			DrawLine(size);
			WriteLine($"| {title} |");
			DrawLine(size);
		}

		public static void Beep(int hz = 2000, int time = 500, int count = 1)
		{
			while (count-- > 0)
			{
				Console.Beep(hz, time);
			}
		}
	}
}