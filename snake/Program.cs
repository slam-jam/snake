using System;

namespace snake
{
	class Program
	{
		public static void Main(string[] args)
		{
			Point p1 = new Point();
			p1.x = 7;
			p1.y = 3;
			p1.s = '$';
			p1.Draw();
			
			Point p2 = new Point();
			p2.x = 22;
			p2.y = 5;
			p2.s = '%';
			p2.Draw();
			
			Console.ReadKey();
			
		}
		
	}
}