using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveOrNegative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number : ");

            float num = float.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("Your number is Zero!");

            }
            else if (num > 0)
            {
                Console.WriteLine("Your number is positive !  ");
            }
            else {
                Console.WriteLine("your number is Negative");
            }

            Console.ReadLine();
        }
    }
}
