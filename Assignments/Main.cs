using System;
namespace Program
{
    class mainclass
    {
        public static void Main()
        {
              Program1 pgm1 = new Program1();
              pgm1.findsum();
              Console.ReadLine();
            Int32 day;
            Console.Write("Enter number of day : ");
            day = Convert.ToInt32(Console.ReadLine());
            Program2 pgm2 = new Program2();
            pgm2.finddays_if(day);
            pgm2.finddays_switch(day);
            Console.ReadLine();
              Program3 pgm3 = new Program3();
              pgm3.pattern();
              Console.ReadLine();
              Program4 pgm4 = new Program4();
              pgm4.fibonacci();
              Console.ReadLine();
              Program5 pgm5 = new Program5();
              pgm5.convertarray();
              Console.ReadLine();
            Program6 pgm6 = new Program6();
            pgm6.stringarray();
             Console.ReadLine();
             Program7 pgm7 = new Program7();
             pgm7.reversearray();
             Console.ReadLine();
           Program8 pgm8 = new Program8();
            pgm8.max_min_array();
            Console.ReadLine();
            Program9 pgm9 = new Program9();
            pgm9.Join_Split_Trim();
            Console.ReadLine();
        	 Program10 pgm10 = new Program10();
            pgm10.Remove_special_character();
            Console.ReadLine();
          Program11 pgm11 = new Program11();
            pgm11.Reverse_String();
            Console.ReadLine();
             Program12 pgm12 = new Program12();
            pgm12.Merge_String();
            Console.ReadLine();
            Program13 pgm13 = new Program13();
            string str1=pgm13.strTitleCase();
            string str2=pgm13.strCamelCaseFunc();
            Console.WriteLine(str1);
            Console.WriteLine(str2);

          Program14 pgm14 = new Program14();
            pgm14.NumOfWorlds();
            Console.ReadLine();
            Program15 pgm15 = new Program15();
            pgm15.CountWords();
            Console.ReadLine();
             Program16 pgm16 = new Program16();
            pgm16.second_max();
            Console.ReadLine();
            Program17 pgm17 = new Program17();
            pgm17.delegatepgm();
            Console.ReadLine();
           Program18 pgm18 = new Program18();
            pgm18.RateOfInterest();
            pgm18.calculate();
            pgm18.readinterest();
            Console.ReadLine();




        }
    }
}