using System;

namespace snake
{
	class Program
	{
		static void Main(string[] args)
		{
			Point p1 = new Point(27,3,'*');
			p1.Draw();
			
			Point p2 = new Point(19,13,'^');
			p2.Draw();
			
			Console.ReadKey();
		}
		
	}
}