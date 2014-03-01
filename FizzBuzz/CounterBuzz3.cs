using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class CounterBuzz3 : IBuzzCounter
    {
        private ICounterItem counterStandard;

        public CounterBuzz3(ICounterItem counterStandard)
        {
            this.counterStandard = counterStandard;
        }
        public IBuzzCounter GetNewItem()
        {
            return new CounterBuzz4(counterStandard.GetNewItem());
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
