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
            //Set variable peramaters
            double inum1 = 0;
            double inum2 = 0;
            int inum3 = 0;
            double ianswer = 0;
            char cOption;
            bool now = true;
            bool ans = true;
            int counter = 0;
            
            //create list for memory
            List<double> mem = new List<double> { };
            
            //start of loop
            do
            {
                //Create colour scheme in green
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Black;

                //counter to count how many calculations the user has made
                counter += 1;
                Console.WriteLine("Calculation Number: " + counter + "\n");

                //main menu for choice of operations
                Console.WriteLine("Menu\nA is for Addition\nS is for Subtraction\nM is for Multiplication\nD is for Division\nP is for Power\nR is for Square root\nL is for last answer\nC is for Clear screen\nE is for Exit");

                //in order to avoid errors all input it made into uppercase 
                cOption = char.Parse(Console.ReadLine());
                cOption = char.ToUpper(cOption);

                //switch case for the different operations including (+, -, *, /, Square, Square root, Memory, Clear screen, Exit and error handling)
                switch (cOption)
                {
                    //if A is inputed it will add the two inputs
                    case 'A':
                        Console.WriteLine("Please enter first number");
                        inum1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter second number");
                        inum2 = double.Parse(Console.ReadLine());
                        ianswer = inum1 + inum2;
                        break;
                    //if S is inputed it will subtract the two inputs
                    case 'S':
                        Console.WriteLine("Please enter first number");
                        inum1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter second number");
                        inum2 = double.Parse(Console.ReadLine());
                        ianswer = inum1 - inum2;
                        break;
                    //if M is inputed it will multiply the two inputs
                    case 'M':
                        Console.WriteLine("Please enter first number");
                        inum1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter second number");
                        inum2 = double.Parse(Console.ReadLine());
                        ianswer = inum1 * inum2;
                        break;
                    //if D is inputed it will divide the two inputs
                    case 'D':
                        Console.WriteLine("Please enter first number");
                        inum1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter second number");
                        inum2 = double.Parse(Console.ReadLine());
                        ianswer = inum1 / inum2;
                        break;
                    //if P is inputed it will square the input
                    case 'P':
                        Console.WriteLine("Value to Power");
                        inum1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Power to");
                        inum2 = double.Parse(Console.ReadLine());
                        ianswer = Math.Pow(inum1, inum2);
                        break;
                    //if R is inputed it will square root the input
                    case 'R':
                        Console.WriteLine("What number do you want to Square root?");
                        inum3 = int.Parse(Console.ReadLine());
                        ianswer = Math.Sqrt(inum3);
                        break;
                    //if L is inputed it will give the answer of the calulation of the input the user gave
                    case 'L':
                        Console.WriteLine("What Calculation number would you like to see? ");
                        Console.ReadLine();
                        Console.WriteLine("\nThe answer you are looking for: " + mem[inum3] + "\n");
                        ans = false;
                        break;
                    //if E is inputed it will quit the apllication
                    case 'E':
                        now = false;
                        break;
                    //if C is inputed it will clear the screen
                    case 'C':
                        Console.Clear();
                        break;
                    //if anything else is inputed it will give an error message
                    default:
                        Console.WriteLine("Error try again");
                        break;
                }
                //if statement to see if an answer is needed as an alternative to memory
                if (ans == true) Console.WriteLine("\nThe answer is " + ianswer + "\n");

                //adds the answer to memory
                mem.Add(ianswer);

                //loops back to the top
            }    while (now == true);
        }
    }
}
