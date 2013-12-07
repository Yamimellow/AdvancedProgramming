using System;

namespace week_2
{
    class Program
    {
        static void Main(string[] args)
        {
                // If Conditions
			
			//operators & | ! < >  <= >= == 
			
			int x = 10;
			
			if (x < 100 ) {
				Console.WriteLine("less than 100");
			}
			else if (x < 1000 )
			{
				Console.WriteLine("less than 1000");
			}
			
			
			//removing the else changes the behaviour
			
			if (x < 100 ) {
				Console.WriteLine("less than 100");
			}
			if (x < 1000 )
			{
				Console.WriteLine("less than 1000");
			}
				
			
			
			//strings compare nativly
			// usage of else to anticipate any other outcome.
			
            string pass = "test_pass";

            if (pass == "password")
            {
                Console.WriteLine("correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
			
			
			
			
			
			// conditonal operators 
			
			//a Single char change changes alot and might save alot.
			
			if (Method1() & Method2())
			{
				Console.WriteLine("Both methods returned true.");
			}
			else
			{
				Console.WriteLine("At least one of the methods returned false.");
			}
			
			
			if (Method1() && Method2())
			{
				Console.WriteLine("Both methods returned true.");
			}
			else
			{
				Console.WriteLine("At least one of the methods returned false.");
			}
			
        }
		
		static bool Method1()
	    {
	        Console.WriteLine("Method1 called.");
	        return true;
	    }
	
	    // Method2 returns false. 
	    static bool Method2()
	    {
	        Console.WriteLine("Method2 called.");
	        return false;
	    }
		
		
		
		
		
    }
}

        