using System;
using System.Collections.Generic;

namespace snake
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.SetBufferSize(80,25);
			
			// отрисовка рамки
			HLine upLine = new HLine(0,78,0,'+');
			HLine downLine = new HLine(0,78,24,'+');
			VLine leftLine = new VLine(0,24,0,'+');
			VLine rightLine = new VLine(0,24,78,'+');
			
			
			
			upLine.Draw();
			downLine.Draw();
			leftLine.Draw();
			rightLine.Draw();
			
			
				
			// отрисовка точек
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