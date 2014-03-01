using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public class CounterFizz1 : ICounterItem
    {
        private IBuzzCounter counterBuzz;

        public CounterFizz1(IBuzzCounter counterBuzz)
        {
            this.counterBuzz = counterBuzz;
        }

        public string GetResult()
        {
            return counterBuzz.GetResult();
        }

        public ICounterItem GetNewItem()
        {
            return new CounterFizz2(counterBuzz.GetNewItem());
        }
    }
}
