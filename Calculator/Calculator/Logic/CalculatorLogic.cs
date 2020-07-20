using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Logic
{
    class CalculatorLogic
    {
        public static bool CalcAddition = false;
        public static bool CalcSubtraction = false;
        public static bool CalcMultiply = false;
        public static bool CalcDivide = false;
        public static bool CalcModulus = false;
        public static bool CalcComplete = false;

        public static double ControlInteger;
        //Saves the first integer entered into the calculator
        public static double FirstInteger;
        //Saves the second integer entered into the calculator
        public static double SecondInteger;
        //Saves the result of the mathematical operation
        public static double FinalValue;

        //takes the first and second integers and applies the relevant mathematical opperation
        public static void Calculate()
        {
            if (CalculatorLogic.CalcAddition)
            {
                CalculatorLogic.FinalValue = CalculatorLogic.FirstInteger + CalculatorLogic.SecondInteger;
            }
            if (CalculatorLogic.CalcSubtraction)
            {
                CalculatorLogic.FinalValue = CalculatorLogic.FirstInteger - CalculatorLogic.SecondInteger;
            }
            if (CalculatorLogic.CalcMultiply)
            {
                CalculatorLogic.FinalValue = CalculatorLogic.FirstInteger * CalculatorLogic.SecondInteger;
            }
            if (CalculatorLogic.CalcDivide)
            {
                CalculatorLogic.FinalValue = CalculatorLogic.FirstInteger / CalculatorLogic.SecondInteger;
            }
            if (CalculatorLogic.CalcModulus)
            {
                CalculatorLogic.FinalValue = CalculatorLogic.FirstInteger % CalculatorLogic.SecondInteger;
            }
        }
    }
}
