using System;

namespace Calculator
{
    class Program
    {
      static void Main(string[] args)
        {
            do {
            Console.WriteLine("Введіть перше число");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть друге число");
            int num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть дію");
            char act=Convert.ToChar(Console.ReadLine());
            switch (act)
            {
                case '+':
                  Console.WriteLine("Result: {0}", num1+num2);
                  break;
                case '*':
                  Console.WriteLine("Result: {0}", num1*num2);
                  break;
                case '-':
                  Console.WriteLine("Result: {0}", num1-num2);
                  break;
                case '%':
                  Console.WriteLine("Result: {0}", num1%num2);
                  break;
                case '/':
                  if (num2!=0)
                  {Console.WriteLine("Result: {0}", num1/num2);}
                  else {Console.WriteLine("Error");}
                  break;
            } 
            }while (true);
        }
    }
}
