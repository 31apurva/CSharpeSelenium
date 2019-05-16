using System;
namespace Program
{
    class Program17
    {
        public delegate void Print(int val);
        public void delegatepgm()
        {
            Print printDel = new Print(Printnumber);
            printDel(1000);

        }
        public void Printnumber(int num)
        {

            Console.WriteLine("Delegate Number is : " + num);

        }


    }

}