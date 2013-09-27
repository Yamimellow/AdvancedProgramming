/*
	
	    _   __                __             
	   / | / /_  ______ ___  / /_  ___  _____
	  /  |/ / / / / __ `__ \/ __ \/ _ \/ ___/
	 / /|  / /_/ / / / / / / /_/ /  __/ /    
	/_/ |_/\__,_/_/ /_/ /_/_.___/\___/_/     
	                                         

           	   ______                     _            
           	  / ____/_  _____  __________(_)___  ____ _
           	 / / __/ / / / _ \/ ___/ ___/ / __ \/ __ `/
           	/ /_/ / /_/ /  __(__  |__  ) / / / / /_/ / 
           	\____/\__,_/\___/____/____/_/_/ /_/\__, /  
           	                                  /____/   

						   ______                   
						  / ____/___ _____ ___  ___ 
						 / / __/ __ `/ __ `__ \/ _ \
						/ /_/ / /_/ / / / / / /  __/
						\____/\__,_/_/ /_/ /_/\___/ 
						                            

- the computer choses a random number between 1 and 100 [ 100 is included ]
- then the user is asked to guess the number
- the user has 10 tries to guess the number.
- if the guess is correct the game stops.
- if the guess is smaller than the number , print : guess higher.
- if the guess is larger than the number , print : guess lower.
- if there is no more tries , end the game. and tell him the correct number.
*/



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

			Console.WriteLine("Game Over");
			Console.WriteLine("The correct number is " + number);
			
		}
	}
}
