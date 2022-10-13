using System;

namespace SortNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];
            for (int i = 0; i <= 2; i++)
            {
                int n = int.Parse(Console.ReadLine());
                array[i] = n * -1;
            }
            Array.Sort(array);
            for (int x = 0; x <= 2; x++)
            {
                Console.WriteLine(array[x] * -1);
            }

        }
    }

}
