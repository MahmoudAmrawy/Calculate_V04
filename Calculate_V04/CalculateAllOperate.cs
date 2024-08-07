using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_V04
{
    internal class CalculateAllOperate : VariablesCalculate
    {
        double sum;
        public override void Calculate()
        {
            while (true)
            {
                double num1 = Number1;
                Console.WriteLine("enter your operator {+ , - , * , /  }");
                string operatorr = Console.ReadLine();
                double num2 = Number2;

                switch (operatorr)
                {
                    case "+":
                        Console.WriteLine($"Result = {sum = num1 + num2}");
                        break;
                    case "-":
                        Console.WriteLine($"Result = {sum = num1 - num2}");
                        break;
                    case "*":
                        Console.WriteLine($"Result = {sum = num1 * num2}");
                        break;

                    case "/":
                        if (operatorr == "/")
                        {
                            if (num2 == 0)
                            {
                                Console.WriteLine($"Result = Invalid becouse num2 = 0");
                            }
                            else
                            {
                                Console.WriteLine($"Result = {sum = num1 / num2}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Result = Invalid");
                        }
                        break;
                    default:
                        Console.WriteLine($"Result = Invalid");
                        break;

                }
            }
        }
    }
}
