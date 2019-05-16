using System;
namespace Program
{
    class Program2
    {


        public void finddays_if(int day)
        {

            if (day <= 7)
            {
                Console.WriteLine("inside of if ");
                if (day == 1)
                {
                    Console.WriteLine("Its Monday");
                }

                else if (day == 2)
                {
                    Console.WriteLine("Its Tuesday");

                }
                else if (day == 3)
                {
                    Console.WriteLine("Its Wednessday");
                }
                else if (day == 4)
                {
                    Console.WriteLine("Its Thursday");
                }
                else if (day == 5)
                {
                    Console.WriteLine("Its Friday");
                }
                else if (day == 6)
                {
                    Console.WriteLine("Its Saturday");
                }
                else if (day == 7)
                {
                    Console.WriteLine("Its Sunday");
                }

                else
                    Console.WriteLine("Invalid number");
            }
        }

        public void finddays_switch(int day)
        {

            switch (day)
            {
                case 1:
                    Console.WriteLine("Its Monday");
                    break;
                case 2:
                    Console.WriteLine("Its Tuesday");
                    break;
                case 3:
                    Console.WriteLine("It's Wednesday");
                    break;
                case 4:
                    Console.WriteLine("It's Thursday");
                    break;
                case 5:
                    Console.WriteLine("It's Friday");
                    break;
                case 6:
                    Console.WriteLine("It's Saturday");
                    break;
                case 7:
                    Console.WriteLine("It's Sunday");
                    break;
            }
        }//switch
    }
}