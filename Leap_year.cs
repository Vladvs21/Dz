using System;

namespace Calculator
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть рік");
            int year=Convert.ToInt32(Console.ReadLine());
            if (year%4==0 && year%100!=0 || year%400==0){Console.WriteLine("true");}
            else {Console.WriteLine("false");}
        }
    }
}
