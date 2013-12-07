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
		
		
		// Default Constructor to set the w and h to 10
		public Rectangle()
		{
			width = 10;
			height = 10;
		}
		
		// Constructor taking inputs.
		public Rectangle(int w , int h)
		{
			Width = w;
			Height = h;
		}
		
				
	}
	
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			Rectangle r1 = new Rectangle();
			r1.Width = -10;
			r1.Height = 5;
			
			
			Rectangle r2 = new Rectangle(10,15);
			Rectangle r3 = new Rectangle(-10,-3);
			
			Console.WriteLine("Area : {0}\nPerimeter : {1}",r1.Area(),r1.Perimeter());
			
			Console.WriteLine("Area : {0}\nPerimeter : {1}",r2.Area(),r2.Perimeter());
			
			Console.WriteLine("Area : {0}\nPerimeter : {1}",r3.Area(),r3.Perimeter());
			
			
			// Array of rectangles;
			
			Rectangle[] rect_array = new Rectangle[10];
			//note that the array was created but each rectangle's Constructor wasn't called yet 
			// so to we need to initialize each object separitly
			
			/* for(int i = 0 ; i < 10; i ++)
			{
				Console.WriteLine("Area : {0}\nPerimeter : {1}",rect_array[i].Area(),rect_array[i].Perimeter());
			}*/
			
			// note that accessing the objects without first initializing will result in the following Exception (Error)
			// System.NullReferenceException: Object reference not set to an instance of an object

						
			
			for (int i = 0 ; i < rect_array.Length ; i ++) // instead of rect_array.Length we can use 10
			{
				rect_array[i] = new Rectangle(); // calling the constructor of each object.
			}
			
			
			for(int i = 0 ; i < 10; i ++)
			{
				Console.WriteLine("Area : {0}\nPerimeter : {1}",rect_array[i].Area(),rect_array[i].Perimeter());
			}
			
			
		}
	}
}
