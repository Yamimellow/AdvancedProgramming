using System;
namespace Methods
{
    class car
{
	public string Color{ get; set;}
	protected int hoursePower;

    public int X{ get ; set;}
    public int Y{get;set;}


	public int HoursePower{
	get
	{
		return hoursePower;
	}
	set
	{
		if(value < 0)
		{
		value = value * -1;
		}
		hoursePower = value;
	}
	}

}





    class Program
    {
        static void Main(string[] args)
        {
            car c = new car();
            c.hoursePower = 5;

        }
    }
}
