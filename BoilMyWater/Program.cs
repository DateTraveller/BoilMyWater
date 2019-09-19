using BoilMyWater._1_2.简介和基础;
using System;

namespace BoilMyWater
{
    public class Program
    {
        static void Main(string[] args)
        {
            MethodFortheFirst();
            Console.WriteLine("Hello World!");
        }

        private static void MethodFortheFirst()
        {
            UnitConverter uc = new UnitConverter(10);
            Console.WriteLine(uc.Convert(2));
        }
    }
}
