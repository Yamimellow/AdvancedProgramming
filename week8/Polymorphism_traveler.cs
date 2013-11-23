using System;


namespace Polymorphism
{

    abstract class Vehicle
    {
        abstract public double time_to_arrive(double distance);cd
    }


    class Car : Vehicle
    {
        public override double time_to_arrive(double distance)
        {
            return distance / 100;   // in hours  
        }
    }

    class Bus : Vehicle
    {
        public override double time_to_arrive(double distance)
        {
            return distance / 60;   // in hours  
        }
    }

    class Bicycle : Vehicle
    {
        public override double time_to_arrive(double distance)
        {
            return distance / 10;   // in hours  
        }
    }




    class Traveler
    {
        public double distance { get ;set ;}
        public Vehicle transportation { get ; set ;}
        public Traveler(double d, Vehicle t)
        {
            distance = d;
            transportation = t;
        }

        public double ETA() //estimated time of arrival.
        {
            return transportation.time_to_arrive(distance);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Distance : ");
            double distance = double.Parse(Console.ReadLine());
            
            Console.Write("Type of Vehicle : ");
            string choice = Console.ReadLine();
            Vehicle v;

            if (choice == "car")
            {
                v = new Car();
            }
            else if (choice == "bus")
            {
                v = new Bus();
            }
            else if (choice == "bicycle")
            {
                v = new Bicycle();
            }
            else
            {
                Console.WriteLine("Inccorrect Choice");
                return;
            }


            Traveler t = new Traveler(distance, v);
            Console.WriteLine("time taken to travel {0} km. by {1} = {2} hour(s).", distance, choice, t.ETA());
            Console.ReadLine();

        }
    }
}
