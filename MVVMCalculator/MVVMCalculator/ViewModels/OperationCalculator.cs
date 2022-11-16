using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMCalculator.ViewModels
{
    public static class OperationCalculator
    {
        public static double Calcular(double value1, double value2, string mathOperator)
        {
            double result = 0;

            if (mathOperator == "÷")
            {
                result = val1 / val2;
            }
            else if (mathOperator == "x")
            {
                result = val1 * val2;
            }
            else if (mathOperator == "+")
            {
                result = val1 + val2;
            }
            else if (mathOperator == "-")
            { 
                result = val2 - val1;
            }
            else
            {
                Console.WriteLine("Volver a ingresar");
            }

            return result;
        }
    }
}
