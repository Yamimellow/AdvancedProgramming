using System;

namespace Shape
{
	
	class Rectangle
	{
		int width,height;
		
		public int Width{ 
			get{ return width;}
			set {
				if (value < 0 ) 
				{
					value = value * -1;
				}
				width = value;
			}
		}
		
		
		public int Height{ 
			get{ return height;}
			set {
				if (value < 0 ) 
				{
					value = value * -1;
				}
				height = value;
			}
		}
		
		public int Area()
		{
			return width * height;
		}
		
		
		public int Perimeter()
		{
			return width + width + height + height;
		}
				
	}
	
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			Rectangle r1 = new Rectangle();
			r1.Width = -10;
			r1.Height = 5;
			
			
			Console.WriteLine("Area : {0}\nPerimeter : {1}",r1.Area(),r1.Perimeter());
			
		}
	}
}
