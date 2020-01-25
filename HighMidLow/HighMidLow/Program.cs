using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighMidLow
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1Input, num2Input, num3Input;

            int num1, num2, num3, lowest, mid, highest;

            Console.Write("Enter Number 1: ");
            num1Input = Console.ReadLine();
            num1 = int.Parse(num1Input);

            Console.Write("Enter Number 2: ");
            num2Input = Console.ReadLine();
            num2 = int.Parse(num2Input);

            Console.Write("Enter Number 3: ");
            num3Input = Console.ReadLine();
            num3 = int.Parse(num3Input);

            highest = num1;
            mid = num2;
            lowest = num3;

            if (num2 > highest)
            {
                highest = num2;
            
                if (num3 > highest)
                {
                    highest = num3;
                    mid = num2;
                    lowest = num1;
                }

                else
                {
                    if (num3 > num1)
                    {
                        highest = num2;
                        mid = num3;
                        lowest = num1;
                    }    
                }
            
            }
            else
            {
                if (num2 > num3)
                {
                    highest = num1;
                    mid = num2;
                    highest = num3;
                }

                else
                {
                    highest = num1;
                    mid = num3;
                    lowest = num2;
                }

            }

            Console.WriteLine($"The Numbers you have entered of {num1} , {num2} and  {num3} . {highest} is the highest number, {mid} is the middle number, and {lowest} is the lowest number! ");
            Console.ReadKey();
        }
    }
}
