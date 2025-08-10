using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Assignment_Session_7
{
    public static class Maths
    {
        public static int operationCount = 0;

       public static double Add(double x, double y)
        {
            operationCount++;
            return x + y;
        }
        public static double Subtract(double x, double y)
        {
            operationCount++;

            return x - y;
        }
        public static double Multiply(double x, double y)
        {
            operationCount++;
            return x * y;
        }
        public static double Divide(double x, double y)
        {
            operationCount++;
            if (y == 0)
            {
                Console.WriteLine(" Cannot Divide by Zero");
                return -1;
            }
            else
                return x / y;
        }
        public static double Power(double baseNumber, double number)
        {
            operationCount++;
            return Math.Pow(baseNumber, number);
        }
        public static double Average(double[] arr)
        {
            operationCount++;

            if (arr == null)
            {
                Console.WriteLine(" Array Is Null ");
                return -1;
            }
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];                // Sum المجموع كل هيتخزن في ال
            }
            return sum / arr.Length;         // مجموعهم علي عددهم
        }

        public static void ShowOperationCount()
        {
            Console.WriteLine($" Total Operation performed -> {operationCount}");
        }
            


    }
}
