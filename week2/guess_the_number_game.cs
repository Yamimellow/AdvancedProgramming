using System;


namespace guess_the_number
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			Random r = new Random();			
			int number = r.Next(1,101);
			
			//Console.WriteLine(number); a line for debugging.
			
			Console.WriteLine("Try to guess the number between 1 to 100");
			
			int guess = 0;
			int tries = 10; // number of tries untill game over
			
			
			do
			{
			// reading users guess  , and parsing it to integer.	
				guess = int.Parse(Console.ReadLine());
				
				if ( number == guess ) 
				{
					Console.WriteLine("Good Guess");		
					return;
				}
				else if ( guess > number )
				{
					Console.WriteLine("Think Lower");
				}
				else
				{
						Console.WriteLine("Think Higher");
				}
			// decrementing the tries.
				tries--;
			}
			while(tries > 0);
			
			
			
		}
	}
}
