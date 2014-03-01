using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class CounterFizz2 : ICounterItem
    {
        private IBuzzCounter counterBuzz;

        public CounterFizz2(IBuzzCounter counterBuzz)
        {
            this.counterBuzz = counterBuzz;
        }

        public string GetResult()
        {
            return counterBuzz.GetResult();
        }

        public ICounterItem GetNewItem()
        {
            return new CounterFizz3(counterBuzz.GetNewItem());
        }
    }
}
