﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    class sample9
    {
        public static void Main()
        {
            Console.WriteLine("Enter two numbers:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Operator: ");
            char op = Convert.ToChar(Console.ReadLine());
            int res = 0;
            if (op == '+')
            {
                res = num1 + num2;
            }
            else if (op == '-')
                res = num1 - num2;
            else if (op == '*')
                res = num1 * num2;
            else if (op == '/')
                res = num1 / num2;
            else if (op == '%')
                res = num1 % num2;
            else
                Console.WriteLine("Invalid Operator..!");
            Console.WriteLine("Result is: " + res);
        }
        }
    }

