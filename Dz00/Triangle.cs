using System;

namespace Calculator
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть першу сторону");
            int side1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть другу сторону");
            int side2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть третю сторону");
            int side3=Convert.ToInt32(Console.ReadLine());
            int Max=0;
            if (side1>side2 && side1>side3)
            {Max=side1;}
            else if (side2>side1 && side2>side3)
                    {Max=side2;}
                 else if (side3>side2 && side3>side1)
                      {Max=side3;}
            int Sum=side1+side2+side3;
            if (Sum>Max) {Console.WriteLine("true");}
            else {Console.WriteLine("false");}
        }
    }
}
