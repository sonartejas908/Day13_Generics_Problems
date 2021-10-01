using System;

namespace Day13Assigment
{
    class Program
    {
        static void Main(string[] args)
        {
            //MaximumNumberCheck.MaximumIntegerNumber();
            // MaximumNumberCheck.MaxFloat();
            //Max_string.Max_stringCheck();
            int[] intArray = { 455, 654, 85, 852, 85 };
            Max_using_Generics<int> generics = new Max_using_Generics<int>(intArray);
            generics.PrintMaxValue();
            double[] doubleArray = { 45.2, 64.2, 63.4, 89.58, 65.84 };
            Max_using_Generics<double> genericDouble = new Max_using_Generics<double>(doubleArray);
            genericDouble.PrintMaxValue();
        }
    }
}
