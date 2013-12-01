using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLL_TEST
{
    public class MySequences
    {
        public int fibonacie(int x)// recursive function.
        {
            if (x == 1) return 0;
            else if (x == 2) return 1;
            else return fibonacie(x - 1) + fibonacie(x - 2);
        }

        public int evens(int x)
        {
            if (x == 1) return 2;
            else return 2 + evens(x - 1);
        }
    }


    abstract class Vehicle
    {
        public abstract int move();
    }
}
