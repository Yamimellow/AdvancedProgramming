using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace week3_assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            // we will define go higher as + and go lower as -

            string go_higher = "+";
            string go_lower = "-";
            string correct = "=";

            int upper_range = 100;
            int lower_range = 0;

            

            for (int i = 0; i < 10; i++)
            {
                int number = ((upper_range - lower_range) / 2) + lower_range; // this is the equation that will be used in searching.

                Console.Write("Is the number {0} : ",number);
                string result = Console.ReadLine();

                if (result == correct)
                {
                    Console.WriteLine("Human u underestimate my binary search skills, it took me {0} tries.", i);
                    break;
                }
                else if (result == go_higher)
                {
                    lower_range = number + 1;
                }
                else if (result == go_lower)
                {
                    upper_range = number - 1;
                }
                else
                {
                    Console.WriteLine("You cheated Human , this one doesn't count");
                    i--;
                }
            }
        }
    }
}
