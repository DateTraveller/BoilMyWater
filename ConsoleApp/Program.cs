using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 6, 5, 3, 1, 8, 7, 2, 4 };
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length - 1-i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            foreach (var item in arr)
            {
                Console.Write(item.ToString());
            }
            Console.WriteLine("Hello World!");
        }
    }
}
