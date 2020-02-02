using System;

namespace Calculator
{
    class Program
    {
        enum Operator {Add=1, Subtract, Multiply, Divide}
        static void Main(string[] args)
        {                                
            Console.WriteLine("Welcome to the calculator!");
            Console.WriteLine("Pick an operator");
            Console.WriteLine("1. add (+) \n2. subtract (-) \n3. multiply (*) \n4. divide (/)");
            Operator choiceUser = (Operator)Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Enter the first number");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double number2 = Convert.ToDouble(Console.ReadLine());            
            Console.Clear();
            double ans = Calculator(number1, number2, choiceUser);

            while (true)
            {
                bool exit = false;
                bool valid = false;

                // Ask if the user wants to continue or not
                do
                {
                    Console.WriteLine("\nContinue with this value? [y/n]");
                    string input = Console.ReadLine();
                    if (input == "y")
                    {
                        valid = true;
                        exit = false;
                    }
                    else if (input == "n")
                    {
                        valid = true;
                        exit = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
                while (!valid);

                Console.Clear();
                // if you want to continue
                if (!exit)
                {
                    Console.WriteLine("Pick an operator");
                    Console.WriteLine("1. add (+) \n2. subtract (-) \n3. multiply (*) \n4. divide (/)");
                    choiceUser = (Operator)Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Enter a number");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    ans = Calculator(ans, number1, choiceUser);
                }
                else
                {
                    Environment.Exit(0); // Stop the program
                }
            }

        }

        // This method will return the result and will print the whole operation to
        // the console
        // Parameters consists of 2 numbers of datatype doubles and an operator with datatype 
        // Operator
        static double Calculator(double number1, double number2, Operator op)
        {
            double result = 0;
            Console.Write(number1);
            switch (op)
            {
                case Operator.Add:
                    Console.Write(" + ");
                    result = add(number1, number2);
                    break;
                case Operator.Subtract:
                    Console.Write(" - ");
                    result = subtract(number1, number2);
                    break;
                case Operator.Multiply:
                    Console.Write(" * ");
                    result = multiply(number1, number2);
                    break;
                case Operator.Divide:
                    Console.Write(" / ");
                    result = divide(number1, number2);
                    break;
                default:
                    break;
            }
            Console.Write(number2 + " = " + result);
            return result;           
        }
        
        static double add(double n1, double n2)
        {
            double sum = n1 + n2;
            return sum;
        }

        static double subtract(double n1, double n2)
        {
            double sum = n1 - n2;
            return sum;
        }

        static double multiply(double n1, double n2)
        {
            double product = n1 * n2;
            return product;
        }

        static double divide(double n1, double n2)
        {
            double quotient = n1 / n2;
            return quotient;
        }
    }
}
