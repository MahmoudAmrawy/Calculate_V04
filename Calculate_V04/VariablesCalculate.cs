using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_V04
{
    internal class VariablesCalculate : BasicMaths
    {
        double sum;
        public double Number1
        {
            get 
            { Console.WriteLine("enter your first number");
                double Number1 = Convert.ToDouble(Console.ReadLine());
                return Number1; 
            }
            set { Number1 = value; }
        }
        public double Number2
        {
            get
            { Console.WriteLine("enter your secound number");
                double Number2 = Convert.ToDouble(Console.ReadLine());
                return Number2;
            }
            set
            { Number2 = value;}
        }
        public override void Calculate() 
        {
            double num1 = Number1;
            Console.WriteLine("enter your operator {+ , - , * , /  }");
            string operatorr = Console.ReadLine();
            double num2 = Number2;

            if (operatorr == "+")
                Console.WriteLine($"Result = {sum = num1 + num2}");
            else
                Console.WriteLine($"Result = Invalid");
        }
    }
}