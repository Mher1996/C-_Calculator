// See https://aka.ms/new-console-template for more information

namespace Calculator
{
    class Console_calculator
    {
        static void Main(string[] args)
        {
            double firstNumber = CalcOperations.getFirstNumber();
            double secondNumber = CalcOperations.getSecondNumber();
            int operationNumber = CalcOperations.getOperations();
            double result = CalcOperations.Calc(firstNumber, secondNumber, operationNumber);
            Console.WriteLine("Yor result is : "+result);
            

        }
     

    }
}






