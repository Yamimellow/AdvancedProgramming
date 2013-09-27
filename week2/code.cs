using System;

namespace HelloWorld
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
			
			
			
			//switch cases
			
			char caseSwitch = 'A';
			switch (caseSwitch)
			{
			    case 'A':
			        Console.WriteLine("Case 1");
			        break;
			    case 'B':
			        Console.WriteLine("Very good");
			        break;
				case 'C':
					Console.WriteLine("Good");
					break;    
				default:
			        Console.WriteLine("Default case");
			        break;
			}
			
			
			
			


            //For Loops
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            int z = 10;

			
			
            //While Loops
            while (z > 0)
            {
                z--;
                Console.WriteLine(z);
            };


            //Do While
            do
            {
                z++;
                Console.WriteLine(z);
            } while (z < 10);

			
			
			
			//basic arrays

            int[] int_array  = {1,2,3,4};
            int[] int_array2 = new int[100];



            //Args
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
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

        