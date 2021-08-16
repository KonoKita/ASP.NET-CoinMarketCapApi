using System;

namespace CombSort
{
    class Program
    {

        public static int[] combSort(int[] input)
        {
            double gap = input.Length;          // переменная по которой будет изменяться расстояние проверяемых элементов 
            bool swaps = true;                  //это для конструкции
            while (gap > 1 || swaps)
            {
                gap /= 1.247330950103979;       // каждый цикл 
                if (gap < 1) { gap = 1; }
                int i = 0;
                swaps = false;
                while (i + gap < input.Length)
                {
                    int igap = i + (int)gap;
                    if (input[i] > input[igap])
                    {
                        int swap = input[i];
                        input[i] = input[igap];
                        input[igap] = swap;
                        swaps = true;
                    }
                    i++;
                }
            }
            return input;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write count of elements of massive...");
            int x = Convert.ToInt32(Console.ReadLine());
            int i;
            int[] A = new int[x];
            i = 0;
            Console.WriteLine("Write elements of massive separated by enters...");
            do
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
                i = i + 1;
            }
            while (i < x);
            Console.WriteLine(string.Join(",", combSort(A)));
            Console.ReadLine();

        }
    }
}
