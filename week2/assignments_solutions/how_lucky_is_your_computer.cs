using System;

namespace week2_assignments
{
    class how_lucky_is_your_computer
    {
        static void Main(string[] args)
        {
            Random r = new Random(); // this is the random object , that will generate the random numbers

            float x = 0; // the variable that will be used in the calculation.

            for (int i = 0; i < 100; i++)
            {
                x += r.Next(1, 101); //the Next method of r is the one that returns the random number
            }

            Console.WriteLine(x / 100); // note that since x is float , dividing by int(100) won't be incorrect. 
        }
    }
}
