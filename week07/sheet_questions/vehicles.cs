using System;

namespace Vehicles
{

    class Vehicle
    {
        protected int topSpeed; // use of protected because it will be inhereted after that.
        protected int pass_cap;
        protected string color;
        protected float price;
		
        public int TopSpeed { get { return topSpeed; } set { topSpeed = value; } }        
        public int PassengerCap { get { return pass_cap; } set { pass_cap = value; } }
        public float Price { get { return price; } set { price = value; } }
        public string Color { get { return color; } set { color = value; } }
		
		
		
    }

    class Car : Vehicle
    {
        public string DriveType { get; set; } // front wheel , back wheel
        public string CarType { get; set; } // SUV , SEDAN , Hatchback , MPV

        public float tax_paid()
        {
            return price * 0.2f;
        }

    }


    class Boat : Vehicle
    {
        public string WaterType { get; set; } // saltwater , fresh water
        public string BoatCatigory { get; set; } // yachet , COntainer , Cruze , Tanker
        public string UniqueSailingID { get; set; } // whatever the hell this is !


    }
    class Program
    {

        static void Main(string[] args)
        {
			
			int cars_count = 3;
			int boats_count = 1;
            Car[] cars = new Car[cars_count];
            Boat[] Boats = new Boat[boats_count];

            for (int i = 0; i < cars_count; i++)
            {
				Console.WriteLine("Car # {0}",i+1);
                cars[i] = new Car(); // initializng each object in the array is very important.
				
				// common properties in vheicles.
				Console.Write("Top Spead : ");
				cars[i].TopSpeed = int.Parse(Console.ReadLine());
				
				Console.Write("Passenger Capacity : ");
				cars[i].PassengerCap = int.Parse(Console.ReadLine());
				
				Console.Write("Price : ");
				cars[i].Price = float.Parse(Console.ReadLine());
				
				Console.Write("Color : ");
				cars[i].Color = Console.ReadLine();
				
				// Car Specific Properties.
				Console.Write("Car Type: ");
                cars[i].CarType = Console.ReadLine();
				
				Console.Write("Drive Type : ");
				cars[i].DriveType = Console.ReadLine();
			
            }

            for (int i = 0; i < boats_count; i++)
            {
				Console.WriteLine("Boat # {0}",i+1);
                Boats[i] = new Boat();
                // common properties in vheicles.
				Console.Write("Top Spead : ");
				Boats[i].TopSpeed = int.Parse(Console.ReadLine());
				
				Console.Write("Passenger Capacity : ");
				Boats[i].PassengerCap = int.Parse(Console.ReadLine());
				
				Console.Write("Price : ");
				Boats[i].Price = float.Parse(Console.ReadLine());
				
				Console.Write("Color : ");
				Boats[i].Color = Console.ReadLine();
				
				
				// Boat specific properties
				
				Console.Write("Water Type: ");
                Boats[i].WaterType = Console.ReadLine();
				
				Console.Write("Boat Catigory: ");
                Boats[i].BoatCatigory = Console.ReadLine();
				
				Console.Write("Unique ID : ");
                Boats[i].UniqueSailingID = Console.ReadLine();
				
            }
			
			
			float min_price = -1f;
			int car_index = -1;
			
			for(int i = 0 ; i < cars.Length ;i ++)
			{
				if(cars[i].CarType == "MPV")
				{
					if (cars[i].PassengerCap == 6)
					{
						if(cars[i].Color == "red")
						{
							if(min_price!= -1f)
							{
								if(min_price > cars[i].Price) 
								{
									min_price = cars[i].Price;
									car_index = i;
								}
							}
							else{
								min_price = cars[i].Price;
								car_index = i;
							}
						}
					}
				}
			}
			
			if(car_index != -1)
			Console.WriteLine("The price of the cheapst red 6 passenger MPV : {0}" ,cars[car_index].Price);

         
        }
    }
}
