using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    internal class CounterBuzz1 : IBuzzCounter
    {
        private ICounterItem counterStandard;

        public CounterBuzz1(ICounterItem counterStandard)
        {
            this.counterStandard = counterStandard;
        }

        public string GetResult()
        {
            return counterStandard.GetResult(); 
        }

        public IBuzzCounter GetNewItem()
        {
            return new CounterBuzz2(counterStandard.GetNewItem());
        }

        public string GetMessageForFizz()
        {
            counterStandard.GetResult(); 
            return string.Empty;
        }
    }
}
