
using System;

class Calculatorl
{
    static void Main()
    {
        Console.Write("enter 1st number:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("enter 2nd number:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("enter operator:");
        string? op = Console.ReadLine();

        double result = 0;
        bool valid_op = true;

        if (op != null)
        {
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        valid_op = false;
                        Console.Write("division by zero is not allowed");
                    }
                    break;
                default:
                    valid_op = false;
                    Console.Write("invalid operator");
                    break;
            }
        }
        else
        {
            valid_op = false;
            Console.Write("operator cannot be null");
        }

        if (valid_op)
        {
            Console.WriteLine("result:" + result);
        }
        Console.WriteLine("press any key to exit");
        Console.ReadKey();
    }
}
