using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    public static class Calculator
    {
        public static float Add(float num1, float num2)
        {
            return num1 + num2;
        }

        public static float Substract(float num1, float num2)
        {
            float result;
            if (num1 == num2)
                Console.WriteLine(num1);
            else
                Console.WriteLine(num1 - num2);

            result = num1 - num2;
            return result;
        }

        public static float Divide(float num1, float num2)
        {
            float result;
            if (num1 == 0)
            {
                Console.WriteLine(0);
            }
            else if (num2 == 0)
            {
                Console.WriteLine("Errore");
            }
            else
            {
                Console.WriteLine(num1 / num2);
            }
            result = num1 / num2;
            return result;
        }

        public static float Multiply(float num1, float num2)
        {
            float result;
            Console.WriteLine(num1 * num2);
            result = num1 * num2;
            return result;
        }
    }
}
