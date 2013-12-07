using System;

namespace quiz
{
	
	class Course
{
	public string[] students;
	public float [] grades;

	int number;

	public string Name{get;set;}
	public string ID{get;set;}
	public int TimeSlot{get;set;}
	public string Day{get;set;}


	public Course(int n)
	{
		students = new string[n];
		grades = new float[n];
		number = n;

	}

	public void ReadStudents()
	{
		for (int i = 0 ; i <number;i++)
		{
		students[i] = Console.ReadLine();
		grades[i] = float.Parse(Console.ReadLine());
		}
	}


	public int max_student()
	{
		int max = 0;

		for(int i = 1;i<number ;i++)
		{
			if(grades[max] < grades[i])
			{
				max = i;
			}
		}

		return max;

	}


	public int min_student()
	{
		int min = 0;

		for(int i = 1;i<number ;i++)
		{
			if(grades[min] > grades[i])
			{
				min = i;
			}
		}

		return min;

	}












}
	
	class MainClass
	{
		
		
		
		
		
		public static void Main(string[] args)
		{
			
		
			Course c1 = new Course(5);
			c1.Name = "Course 1";
			c1.ID = "CC1234";
			c1.TimeSlot = 3;
			c1.Day = "Sunday";
			
			
			Course c2 = new Course(5);
			c2.Name = "Course 2";
			c2.ID = "CC4567";
			c2.TimeSlot = 5;
			c2.Day = "Monday";
			
			c1.ReadStudents();
			c2.ReadStudents();
			
			Console.WriteLine(c1.max_student());
			Console.WriteLine(c1.min_student());
			Console.WriteLine(c2.max_student());
			Console.WriteLine(c2.min_student());
			
			
		}
	}

}