using System;
using System.Collections.Generic;

namespace snake
{
	
	public class VLine
	{
		List<Point> pList;
		
		public VLine(int x, int yUp, int yDown, char s)
		{ pList = new List<Point>();
			for (int y = yUp; y <= yDown; y++ )
			 { Point p = new Point(x,y,s);
				pList.Add(p);
			 }
		}
		
		public void Draw()
		{	
			foreach(Point p in pList)
				p.Draw();
		}
	}
}
