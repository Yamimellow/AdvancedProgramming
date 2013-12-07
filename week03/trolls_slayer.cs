/*
	
	  ______           ____    
	 /_  __/________  / / /____
	  / / / ___/ __ \/ / / ___/
	 / / / /  / /_/ / / (__  ) 
	/_/ /_/   \____/_/_/____/  
                        	   _____ __                     
                        	  / ___// /___ ___  _____  _____
                        	  \__ \/ / __ `/ / / / _ \/ ___/
                        	 ___/ / / /_/ / /_/ /  __/ /    
                        	/____/_/\__,_/\__, /\___/_/     
                        	             /____/             						                            

- set the players health and chance of dodge . ** hard coded **
- the player starts fighting trolls.
- each troll he kills attacks back.
- the ammout of damadge taken is random from (1 to 50)
- then the dodging chance is calculated ( random from 1 to 100)
- if the dodging chance <= ctd , then the attack is dodged and the player doesn't lose health.
- else the player loses health acording to the amount of damadge taken.
- the fight ends when the Hero Dies :( 
- print how many trolls killed.
- print a trophy status if the player kills high number of trolls 

5 =  great  , 10 = excellent , 15 , legendary , 20  magnificient.
*/



using System;


namespace trolls_slayer
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			Random r = new Random();			
			
			int health = 100;
			
			int ctd = 25; // chance to dodge the attack;
			
			int trolls_killed = 0;
			
			
			while ( health > 0) 
			{
				trolls_killed ++;
				
				int damadge_taken = r.Next(1,51);
				int dodge = r.Next(1,101);
				
				if( dodge > ctd ) {
					health -= damadge_taken;
				}
			}
			
			Console.WriteLine("Farewell Great Hero");
			Console.WriteLine("You have killed " + trolls_killed + " trolls.");
			
			if (trolls_killed > 20 ) 
			{
				Console.WriteLine("You are a Magnificent");
			}
			else if (trolls_killed > 15) 
			{
				Console.WriteLine("You are a legendary");
			}
			else if (trolls_killed > 10)
			{
				Console.WriteLine("You are a Excellent");
			}	
			else if (trolls_killed > 5)
			{
				Console.WriteLine("You are a Great");
			}
					
	
			
		}
	}
}
