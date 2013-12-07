using System;

namespace week_2
{
    class Program
    {
        static void Main(string[] args)
        {
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
		
    }
}

        