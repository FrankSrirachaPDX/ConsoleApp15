using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 holder = new Class1();
            int num1;
            int num2;
            string temp;

            Console.WriteLine("Enter an integer.");
            temp = Console.ReadLine();
            num1 = Convert.ToInt32(temp);

            Console.WriteLine("Enter a second integer, or leave it blank.");
            temp = Console.ReadLine();
            if (temp == "")
            {
                num1 = Class1.Math(num1);
            }
            else
            {
                num2 = Convert.ToInt32(temp);

                num1 = Class1.Math(num1, num2);
            }

            
            Console.WriteLine(num1);

            Console.ReadLine();

        }
    }
}
