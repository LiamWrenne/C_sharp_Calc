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
            int inum1 = 0;
            int inum2 = 0;
            int ianswer = 0;
            char cOption;
            bool now = true;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Menu");
                Console.WriteLine("A is for Addition");
                Console.WriteLine("S is for Subtraction");
                Console.WriteLine("M is for Multiplication");
                Console.WriteLine("D is for Devision resulting in whole number answers!");
                Console.WriteLine("Please choose menu option for operator");
                cOption = char.Parse(Console.ReadLine());
                cOption = char.ToUpper(cOption);

                Console.WriteLine("Please enter first number");
                inum1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter second number");
                inum2 = int.Parse(Console.ReadLine());

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
                }

                Console.WriteLine("The answer is " + ianswer);
                Console.WriteLine("\n");

            }    while (now == true);
        }
    }
}
