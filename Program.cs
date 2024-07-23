using System;

namespace MultiPurpose_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1 = Multiplication, 2 = Division, 3 = Addition, 4 = Subtraction");
            int input = Convert.ToInt32(Console.ReadLine());

            switch(input)
            {
                case 1:
                    Console.Write("Input first number: ");
                    double firstNum = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Input second number: ");
                    double secondNum = Convert.ToDouble(Console.ReadLine());
                    double output = firstNum * secondNum;
                    Console.WriteLine("\n-----------------");
                    Console.WriteLine(output);
                 break;

                case 2:
                    Console.Write("Input first number: ");
                    double firstNum2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Input second number: ");
                    double secondNum2 = Convert.ToDouble(Console.ReadLine());
                    double output2 = firstNum2 / secondNum2;
                    Console.WriteLine("\n-----------------");
                    Console.WriteLine(output2);
                    break;

                case 3:
                    Console.Write("Input first number: ");
                    double firstNum3 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Input second number: ");
                    double secondNum3 = Convert.ToDouble(Console.ReadLine());
                    double output3 = firstNum3 + secondNum3;
                    Console.WriteLine("\n-----------------");
                    Console.WriteLine(output3);
                break;

                case 4:
                    Console.Write("Input first number: ");
                    double firstNum4 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Input second number: ");
                    double secondNum4 = Convert.ToDouble(Console.ReadLine());
                    double output4 = firstNum4 - secondNum4;
                    Console.WriteLine("\n-----------------");
                    Console.WriteLine(output4);
                break;
             }
            Console.ReadKey();
        }
    }
}
