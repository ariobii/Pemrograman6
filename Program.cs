using System;

namespace sisapOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //new instance
            Time objekTime = new Time(1,2,3,4,5,6);

            //panggil method
            //objekTime.DisplayCurrentTime();

            /*
            objekTime.Year = 2019;
            objekTime.Month = 4;
            objekTime.Date = 9;
            */
           
            Console.WriteLine("Year : {0}", objekTime.Year.ToString());
            Console.WriteLine("Month : {0}", objekTime.Month.ToString());
            Console.WriteLine("Date : {0}", objekTime.Date.ToString());
            Console.WriteLine("Hour : {0}", objekTime.Hour);
            Console.WriteLine("Minute : {0}", objekTime.Minute);
            Console.WriteLine("Second : {0}", objekTime.Second);
            Console.ReadKey();
        }
    }
}
