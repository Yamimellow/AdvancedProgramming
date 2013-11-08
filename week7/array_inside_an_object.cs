using System;

namespace Shape
{
	
	class Course
	{
		public string[] students;
		
		
		// initializing the array with a default value.
		// note that not initializing the array will result in the following exception (error)
		// System.NullReferenceException: Object reference not set to an instance of an object
		public Course()
		{
			students = new string[5];
		}
		
		//Initializing the array with a custom value through the constructor
		public Course(int students_number)
		{
			students = new string[students_number];
		}

	}
	
	
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			Course c1 = new Course();
			Course c2 = new Course(10);
			
			
			for( int i = 0 ; i < c1.students.Length ; i ++)
			{	
				c1.students[i] = Console.ReadLine();
			}
			
			
			for( int i = 0 ; i < c2.students.Length ; i ++)
			{	
				c2.students[i] = Console.ReadLine();
			}
			
			
		}
	}
}
