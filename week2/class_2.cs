using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
                // If Conditions
			
			//operators & | ! < >  <= >= == 
			
            string pass = "test_pass";

            if (pass == "password")
            {
                Console.WriteLine("correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }


            //Array of 4 elements

            int[] int_array  = {1,2,3,4};
            int[] int_array2 = new int[100];



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



            //Args
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
			
        }
    }
}

        