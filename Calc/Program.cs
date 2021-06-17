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
            int inum3 = 0;
            double ianswer = 0;
            char cOption;
            bool now = true;
            int counter = 1;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Menu\nA is for Addition\nS is for Subtraction\nM is for Multiplication\nD is for Division\nP is for Square\nR is for Square root\nL is for last answer\nE is for Exit\nPlease choose menu option for operator");

                cOption = char.Parse(Console.ReadLine());
                cOption = char.ToUpper(cOption);

                switch (cOption)
                {
                    case 'A':
                        Console.WriteLine("Please enter first number");
                        inum1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter second number");
                        inum2 = double.Parse(Console.ReadLine());
                        ianswer = inum1 + inum2;
                        break;
                    case 'S':
                        Console.WriteLine("Please enter first number");
                        inum1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter second number");
                        inum2 = double.Parse(Console.ReadLine());
                        ianswer = inum1 - inum2;
                        break;
                    case 'M':
                        Console.WriteLine("Please enter first number");
                        inum1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter second number");
                        inum2 = double.Parse(Console.ReadLine());
                        ianswer = inum1 * inum2;
                        break;
                    case 'D':
                        Console.WriteLine("Please enter first number");
                        inum1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter second number");
                        inum2 = double.Parse(Console.ReadLine());
                        ianswer = inum1 / inum2;
                        break;
                    case 'P':
                        Console.WriteLine("What number do you want to Square?");
                        inum3 = int.Parse(Console.ReadLine());
                        ianswer = inum3 * inum3;
                        break;
                    case 'R':
                        Console.WriteLine("What number do you want to Square root?");
                        inum3 = int.Parse(Console.ReadLine());
                        ianswer = Math.Sqrt(inum3);
                        break;
                    case 'L':
                        Console.WriteLine("What Calculation number would you like to see? ");
                        inum3 = int.Parse(Console.ReadLine());
                        List<double> mem = new List<double> { };
                        mem.Add(ianswer);
                        Console.WriteLine(mem[inum3]);
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
