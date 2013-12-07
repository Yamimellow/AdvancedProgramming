using System;

namespace MonkeyTrouble
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 2; i < n; i++)
            {
                bool prime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }

                if (prime) sum += i;
            }

            Console.WriteLine("Sum of Primes {0}", sum);
            Console.ReadLine();
            
        }
    }
}
