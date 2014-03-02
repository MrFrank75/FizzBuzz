using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzSolver : FizzBuzz.IFizzBuzzSolver
    {
        public string Solve(int numberToPrint)
        {
            IFizzCounter fizzCounter = new FizzCounter1(new BuzzCounter1(new NumberCounter()));
            string result = string.Empty;

            for (int i = 0; i < numberToPrint; i++)
            {
                result = fizzCounter.GetResult();
                fizzCounter = fizzCounter.Move();
            }

            return result;
        }
    }
}
