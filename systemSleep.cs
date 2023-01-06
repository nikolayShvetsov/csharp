using System;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последнее число");
            int limit = int.Parse(Console.ReadLine());

            for (int i = limit; i > 0; i--)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(300);
            }

            Console.ReadLine();
            
        }
    }
}
