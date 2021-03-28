using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorModel
    {
        public CalculatorModel()
        {


        }

        public object Calculate(int operand1, int operand2, char operation)
        {
            double result = 0;
            if (operation == '+')
            {
                result = operand1 + operand2;
            }
            else if (operation == '-')
            {
                result = operand1 - operand2;
            }
            else if (operation == '/')
            {
                result = operand1 / (double)operand2;
            }
            else
            {
                result = operand1 * operand2;
            }

            return result;
        }


    }
}
