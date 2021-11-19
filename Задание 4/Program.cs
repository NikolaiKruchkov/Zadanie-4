using System;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N>0, затем нажмите Enter");
            int N = Convert.ToInt32(Console.ReadLine());
            int Q = 0;
            for (int i = 1; i < (2 * N + 1); i += 2)
            {
                Q = Q + i;
                Console.WriteLine(Q);
            }
            Console.WriteLine("Квалрат числа N равен {0}",Q);


        }
    }
}
