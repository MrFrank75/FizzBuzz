using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class CounterFizz3 : ICounterItem
    {
        private IBuzzCounter counterBuzz;

        public CounterFizz3(IBuzzCounter counterBuzz)
        {
            this.counterBuzz = counterBuzz;
        }

        public string GetResult()
        {
            return string.Format("Fizz{0}",counterBuzz.GetMessageForFizz());
        }

        public ICounterItem GetNewItem()
        {
            return new CounterFizz1(counterBuzz.GetNewItem());
        }
    }
}
