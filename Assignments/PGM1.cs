using System;
namespace Program	
{		
	class Program1
	{
	
	
		Int32 num=0, sum=0;
		public void findsum()
		{
			for(Int32 i=1; i<=10; i++)
			{
				Console.WriteLine("Enter number : ");
				num = Convert.ToInt32(Console.ReadLine());
				sum+=num;
			}
		
				Console.WriteLine("Sum of 10 numbers is : "+sum);
		}
	}
}