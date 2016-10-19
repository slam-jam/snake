using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace snake
{
	
	class HLine : Figure
	{
		public HLine(int xLeft, int xRight, int y, char s)
		{ pList = new List<Point>();
			for (int x = xLeft; x <= xRight; x++ )
			 { Point p = new Point(x,y,s);
				pList.Add(p);
			 }
		}
	}
}
