using System;
namespace Program
{
    class Program18
    {
        decimal Principal,amt,tenuar,interest;
        public void RateOfInterest()
        {   
            
            Console.WriteLine("Enter Prinicipal: ");
            Principal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amt: ");
            amt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter tenuar: ");
            tenuar = Convert.ToInt32(Console.ReadLine());

        }
        public void calculate()
        {
            
            interest = Principal*amt*tenuar/100;


        }
        public void readinterest()
        {
            Console.WriteLine("Rate of interest is : "+interest);
            Console.ReadLine();
        }
    }
}