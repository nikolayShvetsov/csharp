using System;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                double firstValue, secondValue;

                string action;

                try
                {
                    Console.WriteLine("Введите первое число");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число");
                    secondValue = double.Parse(Console.ReadLine());
                } catch
                {
                    Console.WriteLine("Не могу преобразовать число");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Выберите действие '+' '-' '*' '/'");
                action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.WriteLine(firstValue + secondValue);
                        break;
                    case "-":
                        Console.WriteLine(firstValue - secondValue);
                        break;
                    case "*":
                        Console.WriteLine(firstValue * secondValue);
                        break;
                    case "/":
                        if(secondValue == 0)
                            Console.WriteLine(0);
                        else
                            Console.WriteLine(firstValue / secondValue);
                        break;
                    default:
                        Console.WriteLine("Не известное мне действие");
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}
