using System;
namespace Kalkylator
{
    class Program
    {

        public static void FirstNumber()
        {
            Console.Write("Input the first number for the operation, please:");
            double operand1 = Convert.ToDouble(Console.ReadLine());

            ChooseOperator(operand1);
        }
        public static void ChooseOperator(double operand1)
        {
            Console.Write("Input an operator please (+,-,*,/):");
            ConsoleKeyInfo operatorChoice = Console.ReadKey();

            switch (operatorChoice.KeyChar)
            {

                case '+':
                    SecondNumber(operand1, operatorChoice);
                    break;
                case '-':
                    SecondNumber(operand1, operatorChoice);
                    break;
                case '*':
                    SecondNumber(operand1, operatorChoice);
                    break;
                case '/':
                    SecondNumber(operand1, operatorChoice);
                    break;
                default:
                    Console.WriteLine($"\n\"{operatorChoice.KeyChar}\" is an invalid operator - Please try again.");
                    ChooseOperator(operand1);
                    break;
            }

        }
        public static void SecondNumber(double operand1, ConsoleKeyInfo operatorChoice)
        {

            Console.WriteLine("\nInput the second number, please:");
            double operand2 = Convert.ToDouble(Console.ReadLine());


            switch (operatorChoice.KeyChar)
            {
                case '+':
                    Operations.Addition(operand1, operand2);
                    Calculator();
                    break;
                case '-':
                    Operations.Subtraction(operand1, operand2);
                    Calculator();
                    break;
                case '*':
                    Operations.Multiplication(operand1, operand2);
                    Calculator();
                    break;
                case '/':
                    Operations.Division(operand1, operand2);
                    Calculator();
                    break;
                default: break;

            }
        }



        public static void Calculator()
        {
            Console.Clear();
            Console.WriteLine("imma Calculatoring! :D");

            do
            {
                FirstNumber();

            } while (Console.ReadLine() != "exit");

        }

        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("KalkylatorApp\n" +
                              "by Saravasha\n" +
                              "(Siavash Gosheh)\n" +
                              "Ready to Mathematize!"
                              );
            Console.WriteLine("0. Exit Console\n1. Run Calculator");
            Console.Write("Select an option:");
            ConsoleKeyInfo menuInput = Console.ReadKey();

            switch (menuInput.KeyChar)
            {
                case '0':
                    Console.WriteLine("Good bye!");
                    Environment.Exit(0);
                    break;
                case '1':
                    Calculator();
                    break;
                default:
                    Console.Write($"\n\"{menuInput.KeyChar}\" is an invalid option, press any key to return to the Main Menu...");
                    Console.ReadKey();
                    MainMenu();
                    break;
            }
        }

        static void Main(string[] args)
        {
            MainMenu();
        }

        public static void Division(double operand1, ConsoleKeyInfo operatorChoice, double operand2)
        {

            try
            {
                Console.WriteLine(operand1 / operand2);
                Calculator();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Ahem, only Mantis Shrimp are allowed to do that. Sorry!", e);
                SecondNumber(operand1, operatorChoice);
            }
            finally
            {
                Console.WriteLine("Ugh...");
                SecondNumber(operand1, operatorChoice);
            }

        }
    }
}
