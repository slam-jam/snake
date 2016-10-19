using System;
using System.Collections.Generic;

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
			
			HLine line = new HLine(5,10,8,'+');
			line.Draw();
			
				
			Console.ReadKey();
		}
		
	}
}