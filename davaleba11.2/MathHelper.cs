using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11_1
{
    static class MathHelper
    {
        private static int _a;
        private static int _b;
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new InvalidOperationException("Division by zero is not allowed.");
            }

            return (double)a / b;
        }
    }
}
