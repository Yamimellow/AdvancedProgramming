using System;

namespace Shape
{
	
	class Circle
	{
		protected float radius;
		protected int lineSize;
		
		public string Color{ get;set;}
		public float Radius{
			get{ return radius;}
			set{ if(value < 0) 
				{
					value = value * -1;
				}
				radius = value;
			}
		}
		
		
		public int LineSize{
			get{ return lineSize;}
			set{ if(value < 0) 
				{
					value = value * -1;
				}
				lineSize = value;
			}
		}
		
		public Circle()
		{
			radius = 10;
		}
		
		public Circle(float r)
		{
			Radius = r;
		}
		
		
		public float Area() 
		{
			return radius * radius * 3.14f;
		}
	}
	
	class Cylinder : Circle
	{
		float hight;
		public float Hight{
			get{ return hight;}
			set{ if(value < 0) 
				{
					value = value * -1;
				}
				hight = value;
			}
		}
		
		public float Volume()
		{
			return Area() * hight;
		}
	}
	
	
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			Cylinder c = new Cylinder();
			
			c.Radius = float.Parse(Console.ReadLine());
			c.Hight  = float.Parse(Console.ReadLine()); 
			
			Console.WriteLine("Area : {0}\nVolume : {1}",c.Area(),c.Volume());
		}
	}
}
