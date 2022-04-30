using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_project_Q8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("insert a number so that to be checked whether the number is divisible by 5 and 7: ");
            string y = Console.ReadLine();
            int input = Int32.Parse(y);
            if((input %5==0) && (input%7==0))
            {
                Console.WriteLine("its divisible by 5 and 7");
            }
            else
            {
                Console.WriteLine("its not divisible by 5 and 7");
            }
        }
    }
}
