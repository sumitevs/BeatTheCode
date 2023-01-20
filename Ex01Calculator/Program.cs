// Implementing a calculator in
// C# using switch statement.
using System;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        string value;
        do
        {
            int answer=0;

            Console.Write("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter symbol(/,+,-,*):");
            string symbol = Console.ReadLine();

            switch (symbol)
            {
                case "+":
                    answer = num1 + num2;
                    break;
                case "-":
                    answer = num1 - num2;
                    break;
                case "*":
                    answer = num1 * num2;
                    break;
                case "/":
                    answer = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
            Console.WriteLine("*************************************");
            Console.WriteLine($"Result = {answer}");
            Console.WriteLine("*************Thank you***************");

            Console.Write("Do you want to continue(y/n):");
            value = Console.ReadLine();
        }
        while (value == "y" || value == "Y");
    }
}


