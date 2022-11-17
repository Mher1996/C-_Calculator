using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class CalcOperations
    {
        public static double getFirstNumber()
        {
            double num1;
            Console.WriteLine( "Enter the first number ");
            num1 = Convert.ToDouble(Console.ReadLine());
            return num1;

        }
        public static double getSecondNumber()
        {
            double num2;
            Console.WriteLine("Enter the second number ");
            num2 = Convert.ToDouble(Console.ReadLine());
            return num2;

        }

        public static int getOperations()
        {
            Console.WriteLine("Enter the number of operation:");
            Console.WriteLine("\t : 1-Counting:");
            Console.WriteLine("\t : 2-Subtraction:");
            Console.WriteLine("\t : 3-Multiplication:");
            Console.WriteLine("\t : 4-Division:");
            Console.WriteLine("\t : 5-Square:");
            Console.WriteLine("\t : 6-Percentage:");
            int operation=Convert.ToInt32(Console.ReadLine());
            if (operation>0 && operation<7)
            {
                return operation;
            }
            Console.WriteLine("Invaild operation number : Try again");
           return getOperations();

        }

        public static double Calc(double firstNumber,double secondNumber,int operationNumber)
        {
            double result = 0;
            switch (operationNumber)
            {
                case 1:
                    result =firstNumber+secondNumber;
                    break;
                    case 2:
                        result =firstNumber-secondNumber;   
                    break ;
                    case 3:  
                        result =firstNumber*secondNumber;
                    break;
                case 4:
                    if (secondNumber!=0)
                    result =firstNumber/secondNumber;
                    else Console.WriteLine("You can not devide by 0"); ;
                    break;
                case 5:
                    result=firstNumber*firstNumber;
                    break;
                case 6:
                    result=(firstNumber*secondNumber)/100;
                    break;
                default:
                    Console.WriteLine("Try again ");
                    result=Calc(firstNumber,secondNumber,getOperations());
                    break;
            }
            return result;

        }

    


}
}
