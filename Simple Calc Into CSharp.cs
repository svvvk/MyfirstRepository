using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, opt;
                float result;

            Console.Write("\n\nEnter first number:\t");
            num = Convert.ToInt32(Console.ReadLine());
            if (opt == 1)
            {
                result = num1 + num2;
                Console.WriteLine("\n{0} + {1} = {2}", num1, num2, result);
            }
            else if (opt == 2)
            {
                result = num1 - num2;
                Console.WriteLine("\n{0} - {1} = {2}", num1, num2, result);
            }
            if (opt == 1)
            {
                result = num1 + num2;
                Console.WriteLine("\n{0} + {1} = {2}", num1, num2, result);
            }
            else if (opt == 2)
            {
                result = num1 - num2;
                Console.WriteLine("\n{0} - {1} = {2}", num1, num2, result);
            }
        }
    }
}
