using System;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            for (; i < 3; i++) {
                Console.WriteLine("for_1: " + i);
            }

            for (; i < 6; i++) {
                Console.WriteLine("for_2: " + i);
            }

            Console.ReadLine();
            
        }
    }
}
