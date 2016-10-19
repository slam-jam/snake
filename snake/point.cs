﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
	class Point
	{
		public int x;
		public int y;
		public char s;
		
		public Point()
		{ 
		}
		
		public Point(int _x, int _y, char _s)
		{ x = _x;
		  y = _y;
		  s = _s;
		}
		
		public Point(Point p)
		{ x = p.x;
		  y = p.y;
		  s = p.s;
		}
		
		public void Move(int offset, Direction direction)
		{
			if (direction == Direction.RIGHT)
				{ x = x+offset;	}
			else if (direction == Direction.LEFT)
				{ x = x-offset;	}
			else if (direction == Direction.UP)
				{ y = y-offset;	}
			else if (direction == Direction.DOWN)
				{ y = y+offset;	}
		}
		
		public void Draw()
		{
			Console.SetCursorPosition(x,y);
			Console.Write(s);
		}
		
		public override string ToString()
		{
			return x + ", " + y + ", " + s;
		}
			
	}
}
