using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class CounterBuzz2 : IBuzzCounter
    {
        private ICounterItem counterStandard;

        public CounterBuzz2(ICounterItem counterStandard)
        {
            this.counterStandard = counterStandard;
        }

        public IBuzzCounter GetNewItem()
        {
            return new CounterBuzz3(counterStandard.GetNewItem());
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
