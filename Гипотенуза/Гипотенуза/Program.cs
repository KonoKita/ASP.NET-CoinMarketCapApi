using System;

namespace Гипотенуза
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int ost = 0;
            ost = x % 2;
            int result = x + (2-ost);
            Console.WriteLine(result);
        }
    }
}
