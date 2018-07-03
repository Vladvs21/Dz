using System;

namespace Calculator
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть першу сторону");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть другу сторону");
            int num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть третю сторону");
            int num3=Convert.ToInt32(Console.ReadLine());
            if (num1>num2 && num1>num3)
            {Console.WriteLine("Max: {0}", num1);}
            else if (num2>num1 && num2>num3)
                    {Console.WriteLine("Max: {0}", num2);} 
                 else if (num3>num2 && num3>num1)
                      {Console.WriteLine("Max: {0}", num3);}
        }
    }
}
