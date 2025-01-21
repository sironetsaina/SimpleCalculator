using System;

public class Simplecalculator
{
    static void Main(string[] args)
    {
         Console.WriteLine("Welcome to the Simple Calculator!");
        
       while (true) 
        {
            Console.WriteLine("\nSelect an operation:");
            Console.WriteLine("1. Add (+)");
            Console.WriteLine("2. Subtract (-)");
            Console.WriteLine("3. Multiply (*)");
            Console.WriteLine("4. Divide (/)");
            Console.WriteLine("5. Exit"); 

            Console.Write("Enter the operation number: ");
            string? operationInput = Console.ReadLine();

            if (int.TryParse(operationInput, out int operation) && operation >= 1 && operation <= 5)
            {
                if (operation == 5)
                {
                    Console.WriteLine("Thank you for using the calculator. Goodbye!");
                    break; // Exit the program
                }

                Console.Write("Enter the first number: ");
                string? num1Input = Console.ReadLine();

                Console.Write("Enter the second number: ");
                string? num2Input = Console.ReadLine();

                if (double.TryParse(num1Input, out double num1) && double.TryParse(num2Input, out double num2))
                {
                    double result = 0;
                    switch (operation)
                    {
                      case 1:
                            result = num1 + num2;
                            Console.WriteLine($"Result: {num1} + {num2} = {result}");
                            break;
                        case 2:
                            result = num1 - num2;
                            Console.WriteLine($"Result: {num1} - {num2} = {result}");
                            break;
                        case 3:
                            result = num1 * num2;
                            Console.WriteLine($"Result: {num1} * {num2} = {result}");
                            break;
                        case 4:
                            if (num2 != 0)
                            {
                                result = num1 / num2;
                                Console.WriteLine($"Result: {num1} / {num2} = {result}");
                            }
                            else
                            {
                                Console.WriteLine("Error: Cannot divide by zero!");
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error: Invalid input for numbers. Please enter valid numbers.");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid operation. Please enter a number between 1 and 5.");
            }
        }
    }
}

