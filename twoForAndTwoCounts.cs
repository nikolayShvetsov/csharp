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
            
            for (int i = 0, k = 6; i < 3 && k < 12; i++, k++) {
                Console.WriteLine("i: " + i);
                Console.WriteLine("k: " + k);
            }

            Console.ReadLine();
            
        }
    }
}
