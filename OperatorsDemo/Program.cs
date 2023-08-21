using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = 5;

            y = y + 5;
            Console.WriteLine(y);

            y += 5;
            Console.WriteLine(y);

            y /= 3;
            Console.WriteLine(y);

            y *= 6;
            Console.WriteLine(y);

            bool isSuccess = true;
            bool isComplete = false;

            if (isSuccess && isComplete)
            {
                Console.WriteLine("Perfect!");
            }

            if (isSuccess || isComplete)
            {
                Console.WriteLine("Perfect!");
            }

            if (isSuccess && !isComplete)
            {
                Console.WriteLine("Fine!");
            }

            int a = 3;
            int b = 5;

            bool result = a < b;
            Console.WriteLine(result);


        }
    }
}
