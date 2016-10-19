using System;

namespace snake
{
	class Program
	{
		public static void Main(string[] args)
		{
			int x = 33;
			int y = 7;
			char c = '&';
			
			Draw(x,y,c);
			Console.ReadKey();
			
		}
		static void Draw(int x, int y, char c)
		{
			Console.SetCursorPosition(x,y);
			Console.Write(c);
		}
	}
}