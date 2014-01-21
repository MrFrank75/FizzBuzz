using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            IFizzBuzzSolver solver = new FizzBuzzSolver();

            for (int i = 1; i <= 60; i++)
            {
                Console.WriteLine(solver.Solve(i));
            }

            Console.ReadKey();
        }
    }
}
