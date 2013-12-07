using System;

namespace MonkeyTrouble
{
    class Program
    {
        static void Main(string[] args)
        {
            string m1, m2;
            m1 = Console.ReadLine();
            m2 = Console.ReadLine();

            if (m1 == m2) Console.WriteLine("We are in trouble");
            else Console.WriteLine("We are safe");

            Console.ReadLine();
        }
    }
}
