using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace week2_assignments
{
    class restaurant_calculator
    {
        static void Main(string[] args)
        {
           //The best solution will be by using arrays , and/or objects .

            int friends_number = 4;
            string[] names = new string[friends_number];
            string[] meals = new string[friends_number];
            float[] cost = new float[friends_number];
            float tax, service, tips;

            for (int i = 0; i < friends_number; i++)
            {
                Console.Write("Friends Name : "); //those are optional but they make the program more user friendly.
                names[i] = Console.ReadLine();
                Console.Write("Order : ");
                meals[i] = Console.ReadLine();
                Console.Write("Cost : ");
                cost[i] = float.Parse(Console.ReadLine()); // note that i need to pare the strings to floats to use them.

            }

            //tax , service , and tips should be read once so they are outside the loop.
            Console.Write("Tax % : ");
            tax = float.Parse(Console.ReadLine());
            Console.Write("Service Costs : ");
            service = float.Parse(Console.ReadLine());
            Console.Write("Tips : ");
            tips = float.Parse(Console.ReadLine());

            // The second for loop is to print the data.
            // note that this is the logical order of operations , i could read tax , service and tips before the first loop
            // and only use one loop to read and write , but logical order is more user friendly.

            for (int i = 0; i < friends_number; i++)
            {
                Console.WriteLine("{0} orderd {1} , that costs {2}", names[i], meals[i], (cost[i] + (cost[i] * tax) + (service + tips) / friends_number));
            }


        }
    }
}
