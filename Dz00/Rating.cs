using System;

namespace Calculator
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть свій бал");
            int mark=Convert.ToInt32(Console.ReadLine());
            if (mark>=90){Console.WriteLine("A");}
            else if (mark>=75){Console.WriteLine("B");}
                 else if (mark>=65){Console.WriteLine("C");}
                      else if (mark>=60){Console.WriteLine("D");}
                           else {Console.WriteLine("E");};
        }
    }
}
