//Congrats You Broke The Code.
//Please tell me your name to get full marks ( No Kidding i swear ).
//you will have to prove and show me how you broke it.



using System;

namespace shuffle_cards
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Problem solving is about optimization.
			//but don't start to optimize untill u need to.
			
			//here are 3 possible ways to calculate the same answer.
			//the complecation increases when we try to optimize more and more.
			
			int sum = 0;
			int i= 0;
			int r = 9705;
			
			for (i=0;i < r;i++)
			{
				if(i%5 == 0 || i%3 == 0) 
				{
					sum += i;
					//Console.WriteLine(i);
				}
			}
			
			Console.WriteLine("Iterations {0}",i);
			Console.WriteLine("Improvment {0} %", 100f/r * (r-i));
			Console.WriteLine(sum);
			Console.WriteLine("------");
			
			sum = 0;
			for(i =1; i*3 < r ; i++)
			{				
				sum += i*3;
				//Console.WriteLine(i*3);
			}
			
			int j=0;
			
			for(j =1; j*5< r  ; j++)
			{
				if(j*5 %3 !=0)
				sum += j*5;
				//Console.WriteLine(j*5);
			}
			
			
			Console.WriteLine("Iterations {0}",i+j);
			Console.WriteLine("Improvment {0} %", 100f/r * (r-(i+j)));
			Console.WriteLine(sum);
			Console.WriteLine("------");
			
			
			sum = 0;
			for(i = 1 ; i*5 < r || i*3 < r;i++)
			{
				if(i*3 > r && i*5 > r) break;
				
				if(i*3 <r) 
				{
					if(i*3 %5 !=0)
					{
					
						sum += i*3;
						//Console.WriteLine(i*3);
					}
				}
				if(i*5 <r) {
					
						sum += i*5;
						//Console.WriteLine(i*5);
					
				}
				
			}
			Console.WriteLine("Iterations {0}",i);
			Console.WriteLine("Improvment {0} %", 100f/r * (r-i));
			Console.WriteLine(sum);
			Console.WriteLine("------");
		}
	}
}
