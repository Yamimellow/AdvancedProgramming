using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            // variables very similar to 

            int var_int = 1;
            float var_float = 1.0f;


            long var_long = 1000000000;
            double var_double = 3.14159265359;

            // strings are not arrays 
            string var_strings = "Welcome to Advanced Programming";


			
			Console.WriteLine(var_int);
			Console.WriteLine(var_strings);
			
			
			//reading input : 
			string number_in_form_of_string = Console.ReadLine();
			// the *function* only reads strings 
			// so it needs to be parsed ( translated  ) into numbers 
			// we use a parse *function* to do this.
			
			Console.WriteLine(number_in_form_of_string + 10);
			// the addition is not working correctly 
			
			int number_in_form_of_integer = int.Parse(number_in_form_of_string);
			Console.WriteLine(number_in_form_of_integer + 10);
			//the addition works this time
			
        }
    }
}
