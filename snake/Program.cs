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
			
			List<int> numList = new List<int>();
			numList.Add(8);
			numList.Add(34);
			numList.Add(55);
			
			int x = numList [0];
			int y = numList [1];
			int z = numList [2];
			
			foreach(int i in numList)
				Console.WriteLine(i);
			
			numList.RemoveAt(1);
			
			foreach(int i in numList)
				Console.WriteLine(i);
						
			List<Point> pList = new List<Point>();
			pList.Add(p1);
			pList.Add(p2);
			
				
			Console.ReadKey();
		}
		
	}
}