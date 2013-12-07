using System;

namespace HealthyFruits
{
	
	class Fruit
	{
		public string Type {get ;set;}
		public int cal_per_gram {get ; set;}
		double weight;
		
		public double Weight{ // weight is non negative.
			get { return weight;}
			set { if(value < 0 ) value *= -1 ; 
				weight = value;
			}
			
		}
		
		public Fruit(string t,double w) // using constructor to pass the arguments is much faster than using properites
		{
			Type = t;
			Weight = w;
			
			// setting cal per gram according to the fruit type.
			if(t == "banana") cal_per_gram = 5;
			else if ( t=="apple") cal_per_gram = 10;
			else if ( t == "grapes") cal_per_gram = 20;
			else if ( t == "orange") cal_per_gram = 7;
			else if ( t == "strawberry") cal_per_gram = 25;
			 
		}
		
		public double TotalCal()
		{ 
			return weight*cal_per_gram;
		}
	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			Fruit[] fruits = new Fruit[5]; // creating a fruit array is much faster
		
			for ( int i = 0 ; i < 5;i++)
			{
				Console.Write("Fruit Type : ");
				string t = Console.ReadLine();
				Console.Write("Fruit Wegiht : ");
				double w = double.Parse(Console.ReadLine());
				
				fruits[i] = new Fruit(t , w);
			}
			
			double sum = 0 ;
			for ( int i = 0 ; i < 5 ; i ++ ) 
			{
				Console.WriteLine("{0} : {1}", fruits[i].Type , fruits[i].TotalCal());
				sum += fruits[i].TotalCal();
			}
			Console.WriteLine("Total Calories : {0}", sum);
		}
	}
}
