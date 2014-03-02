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
            string result = string.Empty;
            ICounterItem fizzCounter = new CounterFizz1(new CounterBuzz1(new CounterStandard()));

            for (int i = 1; i <= numberToPrint; i++)
            {
                result = string.Empty;
                result += fizzCounter.GetResult();
                fizzCounter = fizzCounter.GetNewItem();
            }

            return result;
        }
    }
}
