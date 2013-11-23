using System;


namespace Polymorphism
{

    class Program
    {
        static void Main(string[] args)
        {
            // The object Class .
            // contains 4 methods to override.
            object o = new object();
            Console.WriteLine( o.Equals( new object() ) ); 
            Console.WriteLine( o.GetHashCode() );
            Console.WriteLine( o.GetType() );
            Console.WriteLine( o.ToString() );
        }
    }