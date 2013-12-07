using System;

namespace RTS_Units
{
	
	class City
	{
		public int Long{get;set;}
		public int Lat {get;set;}
		public string Name {get;set;}
		
		public int Distance(City c)
		{
			return (Long - c.Long + Lat-c.Lat);
		}
	}
	
	class Circle
	{
		public float Radius{get;set;}
		
		public float Area()
		{
			return Radius * Radius * 3.14f;
		}
		
		public float Perimeter()
		{
			return 2 * 3.14f * Radius;
		}
	}
	
	class Numbers
	{
		public int digits_num(int n)
		{
			int count = 1;
			while (n/10 != 0)
			{
				count ++;
				n/=10;
			}
			return count;
		}
		
		public int nth_digit(int number,int n)
		{
			for(int i = 1 ; i < n; i++) 
			{
				number /= 10;
			}
			
			return number %10;
		}
	}
	
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			Numbers n = new Numbers();
			Console.WriteLine(n.digits_num(12345));
			Console.WriteLine(n.digits_num(589));
			Console.WriteLine(n.digits_num(3134));
			
			Console.WriteLine(n.nth_digit(12345,3));
			Console.WriteLine(n.nth_digit(64235,2));
			Console.WriteLine(n.nth_digit(9324324,7));
			Console.WriteLine(n.nth_digit(3435,7));
			
			
		}
	}
}
