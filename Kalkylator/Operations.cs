using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkylator
{
    public class Operations
    {

        public static double Addition(double operand1, double operand2)
        {
            return operand1 + operand2;
        }

        public static double Addition(double[] doublesArray)
        {
            double addSum = 0;
            for (int i = 0; i < doublesArray.Length; i++)
            {
                addSum += doublesArray[i];
            }
            return addSum;
        }

        public static double Subtraction(double operand1, double operand2)
        {
            return operand1 - operand2;
        }

        public static double Subtraction(double[] doublesArray)
        {
            double subSum = 0;
            for (int i = 0; i < doublesArray.Length; i++)
            {
                subSum += doublesArray[i];
            }
            return subSum;
        }

        public static double Multiplication(double operand1, double operand2)
        {
            return operand1 * operand2;
        }

        public static double Division(double operand1, double operand2)
        {
            return operand1 / operand2;
        }

    }
}
