using System;

namespace MonkeyTrouble
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] fibs = new int[100]; // use of lists is better but we didn't study it.
            fibs[0] = 0;
            fibs[1] = 1;

            int sum = 0;
            int range = 4000000;

            for (int i = 2; fibs[i - 1] < range; i++)
            {
                fibs[i] = fibs[i - 1] + fibs[i - 2];
                if (fibs[i] % 2 == 0) sum += fibs[i];
            }



            // better solution , more effecient and elegent.
            int a=0, b=1;
            int fib = 1;
            //int sum = 0;
            sum = 0;

            while (fib < range)
            {
                if (a > b)
                {
                    b += a;
                    fib = b;
                }
                else
                {
                    a += b;
                    fib = a;
                }

                if (fib % 2 == 0)
                {
                    sum += fib;
                }
            }


            Console.WriteLine(sum);
            Console.ReadLine();



        }
    }
}
