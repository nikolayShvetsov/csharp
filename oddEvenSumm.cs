using System;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true) {

                Console.Clear();

                uint oddNumberCount = 0;
                uint evenNumberCount = 0;

                try
                {
                    Console.WriteLine("Введите начальное число");
                    int CurrentValue = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите последнее число");
                    int limit = int.Parse(Console.ReadLine());

                    if (CurrentValue > limit)
                    {
                        Console.WriteLine("Начальное число не может быть больше последнего!");
                        Console.ReadLine();
                        continue;
                    }
                    else if (CurrentValue == limit)
                    {
                        Console.WriteLine("Начальное число не может быть равно последнему!");
                        Console.ReadLine();
                        continue;
                    }

                    while (CurrentValue <= limit)
                    {
                        if (CurrentValue % 2 == 0)
                        {
                            evenNumberCount++;
                        }
                        else
                        {
                            oddNumberCount++;
                        }

                        CurrentValue++;
                    }
                }
                catch 
                {
                    Console.WriteLine("Не могу преобразовать число");
                    Console.ReadLine();
                    continue;
                }
                

                Console.WriteLine("Количество четных чисел в диапозоне - " + evenNumberCount);
                Console.WriteLine("Количество нечетных чисел в диапозоне - " + oddNumberCount);


                Console.ReadLine();
            }
            
        }
    }
}
