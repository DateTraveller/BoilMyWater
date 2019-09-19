using System;

namespace BoilMyWater
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = null;
            Nullable<int> a1 = null;
            Console.WriteLine("Hello World!");
            Console.WriteLine(a.GetValueOrDefault());
        }
    }
}
