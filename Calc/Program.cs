using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            double inum1 = 0;
            double inum2 = 0;
            double ianswer = 0;
            char cOption;
            bool now = true;
            int counter = 1;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Menu\nA is for Addition\nS is for Subtraction\nM is for Multiplication\nD is for Devision\nL is for last answer\nE is for Exit\nPlease choose menu option for operator");

                cOption = char.Parse(Console.ReadLine());
                cOption = char.ToUpper(cOption);

                Console.WriteLine("Please enter first number");
                inum1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter second number");
                inum2 = double.Parse(Console.ReadLine());

                switch (cOption)
                {
                    case 'A':
                        ianswer = inum1 + inum2;
                        break;
                    case 'S':
                        ianswer = inum1 - inum2;
                        break;
                    case 'M':
                        ianswer = inum1 * inum2;
                        break;
                    case 'D':
                        ianswer = inum1 / inum2;
                        break;
                    case 'L':
                        break;
                    case 'E':
                        now = false;
                        break;
                    default:
                        Console.WriteLine("Error try again");
                        break;
                }

                Console.WriteLine("\nThe answer is " + ianswer + "\n");

                counter = counter + 1;
                Console.WriteLine("Calculation Number: " + counter + "\n");
            }    while (now == true);
        }
    }
}
