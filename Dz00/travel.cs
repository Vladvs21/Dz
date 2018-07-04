using System;

namespace Calculator
{
    class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть погоду");
            string weather=Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введіть відстань");
            int lenght=Convert.ToInt32(Console.ReadLine());
            if (weather=="Sunny")
            {if (lenght<10){Console.WriteLine("Vehicle: none");}
             else if (lenght<40){Console.WriteLine("Vehicle: bike");}
                  else if (lenght<400){Console.WriteLine("Vehicle: car");}
                       else if (lenght<900){Console.WriteLine("Vehicle: train");}
                            else Console.WriteLine("Vehicle: airplane");}
            else if (weather=="Rainy")
                 {if (lenght<10){Console.WriteLine("Vehicle: car");Console.WriteLine("Ride carefully");}
                  else if (lenght<40){{Console.WriteLine("Vehicle: car");Console.WriteLine("Ride carefully");}
            }
        }
    }
}
}
