using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class CounterBuzz4 : IBuzzCounter
    {
        private ICounterItem counterStandard;

        public CounterBuzz4(ICounterItem counterStandard)
        {
            // TODO: Complete member initialization
            this.counterStandard = counterStandard;
        }

        public IBuzzCounter GetNewItem()
        {
            return new CounterBuzz5(counterStandard.GetNewItem());
        }

        public string GetResult()
        {
            return counterStandard.GetResult();
        }

        public string GetMessageForFizz()
        {
            return string.Empty;
        }
    }
}
